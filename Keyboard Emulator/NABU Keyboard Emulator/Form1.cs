using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XInput_Joystick;
using System.IO.Ports;
using SharpDX.XInput;

namespace NABU_Keyboard_Emulator {

  public partial class Form1 : Form {

    JoystickController _joy1;
    JoystickController _joy2;
    SerialPort         _sp;

    public Form1() {

      InitializeComponent();

      _sp = new SerialPort();

      cbPort.Items.AddRange(SerialPort.GetPortNames());

      // JOY 1
      // ------------------------------------------------------------------------
      cbJoy1.BeginUpdate();

      cbJoy1.Items.Clear();

      cbJoy1.Items.AddRange(JoystickController.GetAvailableControllers());

      if (cbJoy1.Items.Count == 0)
        groupBox2.Enabled = false;
      else
        groupBox2.Enabled = true;

      cbJoy1.EndUpdate();

      if (cbJoy1.Items.Count > 0)
        cbJoy1.SelectedIndex = 0;

      // JOY 2
      // ------------------------------------------------------------------------
      cbJoy2.BeginUpdate();

      cbJoy2.Items.Clear();

      cbJoy2.Items.AddRange(JoystickController.GetAvailableControllers());

      if (cbJoy2.Items.Count == 0)
        groupBox3.Enabled = false;
      else
        groupBox3.Enabled = true;

      cbJoy2.EndUpdate();

      if (cbJoy2.Items.Count > 1)
        cbJoy2.SelectedIndex = 1;
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e) {

      _sp?.Dispose();

      _joy1?.Dispose();

      _joy2?.Dispose();
    }

    void open() {

      try {

        close();

        _sp.PortName = cbPort.Text;
        _sp.BaudRate = 6992;
        _sp.StopBits = StopBits.Two;
        _sp.Open();

        btnConnect.Text = "Close";
      } catch (Exception ex) {

        log(ex.Message);
      }
    }

    void close() {

      try {

        _sp.Close();

        btnConnect.Text = "Open";
      } catch (Exception ex) {

        log(ex.Message);
      }
    }

    void log(string txt) {

      if (Disposing)
        return;

      if (InvokeRequired) {

        Invoke(new Action(() => log(txt)));
        return;
      }

      tbLog.AppendText(txt);
      tbLog.AppendText(Environment.NewLine);
    }

    private void btnConnect_Click(object sender, EventArgs e) {

      if (_sp.IsOpen) {

        close();
      } else {

        open();
      }
    }

    private void cbJoy1_SelectedIndexChanged(object sender, EventArgs e) {

      try {

        _joy1?.Dispose();

        var controller = (Controller)cbJoy1.SelectedItem;

        _joy1 = new JoystickController(controller);
        _joy1.OnChange += _joy1_OnChange;
        _joy1.OnStop += _joy1_OnStop;
      } catch (Exception ex) {

        log($"Joy1: {ex.Message}");
      }
    }

    private void cbJoy2_SelectedIndexChanged(object sender, EventArgs e) {

      try {

        _joy2?.Dispose();

        var controller = (Controller)cbJoy2.SelectedItem;

        _joy2 = new JoystickController(controller);
        _joy2.OnChange += _joy2_OnChange;
        _joy2.OnStop += _joy2_OnStop;
      } catch (Exception ex) {

        log($"Joy2: {ex.Message}");
      }
    }

    private void _joy1_OnStop(object sender, string reason) {

      log($"Joy 1: {reason}");
    }

    private void _joy1_OnChange(object sender, State previousState, State currentState) {

      byte b = 0;

      if (currentState.Gamepad.LeftThumbX < -16000)
        b |= 0b00000001;
      else if (currentState.Gamepad.LeftThumbX > 16000)
        b |= 0b00000100;

      if (currentState.Gamepad.LeftThumbY < -16000)
        b |= 0b00001000;
      else if (currentState.Gamepad.LeftThumbY > 16000)
        b |= 0b00000010;

      if ((currentState.Gamepad.Buttons & GamepadButtonFlags.A) != 0)
        b |= 0b00010000;

      _sp.Write(new byte[] { 0x80, b}, 0, 2);
    }

    private void _joy2_OnStop(object sender, string reason) {

      log($"Joy 2: {reason}");
    }

    private void _joy2_OnChange(object sender, State previousState, State currentState) {

      byte b = 0;

      if (currentState.Gamepad.LeftThumbX < -16000)
        b |= 0b00000001;
      else if (currentState.Gamepad.LeftThumbX > 16000)
        b |= 0b00000100;

      if (currentState.Gamepad.LeftThumbY < -16000)
        b |= 0b00001000;
      else if (currentState.Gamepad.LeftThumbY > 16000)
        b |= 0b00000010;

      if ((currentState.Gamepad.Buttons & GamepadButtonFlags.A) != 0)
        b |= 0b00010000;

      _sp.Write(new byte[] { 0x81, b }, 0, 2);
    }

    char getChar(KeyEventArgs e) {

      int keyValue = e.KeyValue;

      if (e.Control)
        return (char)(keyValue - 64);

      if (!e.Shift && keyValue >= (int)Keys.A && keyValue <= (int)Keys.Z)
        return (char)(keyValue + 32);

      return (char)keyValue;
    }
    private void tbInput_KeyDown(object sender, KeyEventArgs e) {

      try {

        if (!_sp.IsOpen)
          return;

        if (e.KeyValue == 16 || e.KeyValue == 17)
          return;

        byte b;
        
        switch (e.KeyCode) {

          case Keys.Enter:
            b = 13;
            break;

          case Keys.Up:
            b = 0xe2;
            break;
          case Keys.Right:
            b = 0xe0;
            break;
          case Keys.Down:
            b = 0xe3;
            break;
          case Keys.Left:
            b = 0xe1;
            break;

          case Keys.PageUp:
            b = 0xe4;
            break;
          case Keys.PageDown:
            b = 0xe5;
            break;

          default:
            b = (byte)getChar(e);            
            break;
        }

        _sp.Write(new byte[] { b }, 0, 1);

        e.SuppressKeyPress = true;
        e.Handled = true;
      } catch (Exception ex) {

        log($"{ex.Message}");

        close();
      }
    }

    private void tbInput_KeyUp(object sender, KeyEventArgs e) {

      try {

        if (!_sp.IsOpen)
          return;

        byte b = 0;

        switch (e.KeyCode) {

          case Keys.Up:
            b = 0xf2;
            break;
          case Keys.Right:
            b = 0xf0;
            break;
          case Keys.Down:
            b = 0xf3;
            break;
          case Keys.Left:
            b = 0xf1;
            break;

          case Keys.PageUp:
            b = 0xf4;
            break;
          case Keys.PageDown:
            b = 0xf5;
            break;
        }

        if (b != 0)
          _sp.Write(new byte[] { b }, 0, 1);

        e.SuppressKeyPress = true;
        e.Handled = true;
      } catch (Exception ex) {

        log($"{ex.Message}");

        close();
      }
    }

    private void tbInput_Enter(object sender, EventArgs e) {

      tbInput.BackColor = Color.Green;
    }

    private void tbInput_Leave(object sender, EventArgs e) {

      tbInput.BackColor = Color.Black;
    }
  }
}
