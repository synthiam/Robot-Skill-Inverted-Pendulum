using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ARC;
using ARC.Config.Sub;

namespace Inverted_Pendulum_Mega {

  public partial class FormMain : ARC.UCForms.FormPluginMaster {

    bool _isClosing = false;

    System.Timers.Timer _timer = new System.Timers.Timer();

    public FormMain() {

      InitializeComponent();

      ConfigButton = false;
    }

    private void FormMain_Load(object sender, EventArgs e) {

      _timer.Interval = 500;
      _timer.Elapsed += _timer_Elapsed;

      EZBManager.EZBs[0].OnConnectionChange += FormMain_OnConnectionChange;
    }

    private void FormMain_OnConnectionChange(bool isConnected) {

      if (isConnected)
        sendConfig();
    }

    private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {

      _isClosing = true;
    }

    public override void SetConfiguration(PluginV1 cf) {

      cf.STORAGE.AddIfNotExist(ConfigTitles.KP, 3500);
      cf.STORAGE.AddIfNotExist(ConfigTitles.KI, 1200);
      cf.STORAGE.AddIfNotExist(ConfigTitles.KD, 900);
      cf.STORAGE.AddIfNotExist(ConfigTitles.AngleOffset, 10);

      tbKp.Value = Convert.ToInt16(cf.STORAGE[ConfigTitles.KP]);
      tbKi.Value = Convert.ToInt16(cf.STORAGE[ConfigTitles.KI]);
      tbKd.Value = Convert.ToInt16(cf.STORAGE[ConfigTitles.KD]);
      tbAngleOffset.Value = Convert.ToInt16(cf.STORAGE[ConfigTitles.AngleOffset]);

      base.SetConfiguration(cf);

      sendConfig();
    }

    public override PluginV1 GetConfiguration() {

      _cf.STORAGE.AddOrUpdate(ConfigTitles.KP, tbKp.Value);
      _cf.STORAGE.AddOrUpdate(ConfigTitles.KI, tbKi.Value);
      _cf.STORAGE.AddOrUpdate(ConfigTitles.KD, tbKd.Value);
      _cf.STORAGE.AddOrUpdate(ConfigTitles.AngleOffset, tbAngleOffset.Value);

      return base.GetConfiguration();
    }

    private void _timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e) {

      if (_isClosing)
        return;

      updateStats();
    }

    void updateStats() {

      try {

        // Custom Command + Get Stats (8 x 4 byte values are returned)
        var retVals = EZBManager.EZBs[0].SendCommandData(44, 0x00, 0x00);

        var kp = (decimal)BitConverter.ToInt32(retVals, 0) / 1000m;
        var ki = (decimal)BitConverter.ToInt32(retVals, 4) / 1000m;
        var kd = (decimal)BitConverter.ToInt32(retVals, 8) / 1000m;
        var omega = (decimal)BitConverter.ToInt32(retVals, 12) / 1000m;
        var angleFiltered = (decimal)BitConverter.ToInt32(retVals, 16) / 1000m;
        var distance = (decimal)BitConverter.ToInt32(retVals, 20) / 1000m;
        var sumLeft = (decimal)BitConverter.ToInt32(retVals, 24) / 1000m;
        var sumRight = (decimal)BitConverter.ToInt32(retVals, 28) / 1000m;
        var angleOffset = (decimal)BitConverter.ToInt32(retVals, 32) / 10m;
        var turnSpeed = BitConverter.ToInt32(retVals, 36);
        var runSpeed = BitConverter.ToInt32(retVals, 40);

        StringBuilderV2 sb = new StringBuilderV2(false);

        sb.AppendFormatLine("Kp: {0}", kp);
        sb.AppendFormatLine("Ki: {0}", ki);
        sb.AppendFormatLine("Kd: {0}", kd);
        sb.AppendFormatLine("Omega: {0}", omega);
        sb.AppendFormatLine("Angle: {0}", angleFiltered);
        sb.AppendFormatLine("Distance: {0}", distance);
        sb.AppendFormatLine("Left Wheel: {0}", sumLeft);
        sb.AppendFormatLine("Right Wheel: {0}", sumRight);
        sb.AppendFormatLine("Angle Offset: {0}", angleOffset);
        sb.AppendFormatLine("Turn Speed: {0}", turnSpeed);
        sb.AppendFormatLine("Run Speed: {0}", runSpeed);

        Invokers.SetText(lblStats, sb);
      } catch (Exception ex) {

        EZBManager.Log(ex.Message);

        _timer.Stop();

        Invokers.SetChecked(cbRealtimeUpdate, false);
      }
    }

    void checkForCapability() {

      EZBManager.EZBs[0].Firmware.CapabilityRequired(EZ_B.Firmware.XMLFirmwareSimulator.CAP_INVERTED_PENDULUM_V1);
    }

    private void cbRealtimeUpdate_CheckedChanged(object sender, EventArgs e) {

      try {

        checkForCapability();

        if (cbRealtimeUpdate.Checked)
          _timer.Start();
        else
          _timer.Stop();
      } catch (Exception ex) {

        Invokers.SetAppendText(tbLog, true, "Connected device to EZ-B index #0 does not support the required capability. {0}", ex.Message);
      }
    }

    void sendConfig() {

      try {

        checkForCapability();

        if (!EZBManager.EZBs[0].IsConnected)
          return;

        List<byte> packet = new List<byte>();

        packet.Add(0x00); // custom command
        packet.Add(0x01); // set values

        packet.AddRange(BitConverter.GetBytes((Int16)tbKp.Value));
        packet.AddRange(BitConverter.GetBytes((Int16)tbKi.Value));
        packet.AddRange(BitConverter.GetBytes((Int16)tbKd.Value));
        packet.AddRange(BitConverter.GetBytes((Int16)tbAngleOffset.Value));

        EZBManager.EZBs[0].SendCommandData(0, packet.ToArray());
      } catch (Exception ex) {

        Invokers.SetAppendText(tbLog, true, "Connected device to EZ-B index #0 does not support the required capability. {0}", ex.Message);
      }

    }

    private void trackBar_Scroll(object sender, EventArgs e) {

      sendConfig();
    }

    void move(Int16 forward, Int16 turn) {
      
      try {

        checkForCapability();

        List<byte> packet = new List<byte>();

        packet.Add(0x00); // custom command
        packet.Add(0x02); // move cmd
        packet.AddRange(BitConverter.GetBytes(forward));
        packet.AddRange(BitConverter.GetBytes(turn));

        EZBManager.EZBs[0].SendCommandData(0, packet.ToArray());

      } catch (Exception ex) {

        Invokers.SetAppendText(tbLog, true, "Connected device to EZ-B index #0 does not support the required capability. {0}", ex.Message);
      }
    }

    void forward() {

      move(5, 0);
    }

    void stop() {

      move(0, 0);
    }

    void reverse() {

      move(-5, 0);
    }

    void left() {

      move(0, -60);
    }

    void right() {

      move(0, 60);
    }

    private void textBox1_KeyDown(object sender, KeyEventArgs e) {

      if (EZBManager.MovementManager.GetCurrentDirection != MovementManager.MovementDirectionEnum.Stop)
        return;

      if (e.KeyCode == Keys.Up)
        forward();
      else if (e.KeyCode == Keys.Right)
        right();
      else if (e.KeyCode == Keys.Down)
        reverse();
      else if (e.KeyCode == Keys.Left)
        left();
      else
        stop();
    }

    private void textBox1_KeyUp(object sender, KeyEventArgs e) {

      stop();
    }

    private void btnCalibrate_Click(object sender, EventArgs e) {

      try {

        checkForCapability();

        // Custom Command, Calibrate
        EZBManager.EZBs[0].SendCommandData(0, 0x00, 0x03);

      } catch (Exception ex) {

        Invokers.SetAppendText(tbLog, true, "Connected device to EZ-B index #0 does not support the required capability. {0}", ex.Message);
      }
    }
  }
}
