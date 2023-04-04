using System;
using System.Collections.Generic;
using SharpDX.XInput;

namespace XInput_Joystick {

  public class JoystickController : EZ_B.DisposableBase {

    public delegate void OnStopHandler(object sender, string reason);
    public event OnStopHandler OnStop;

    public delegate void OnChangeHandler(object sender, State previousState, State currentState);
    public event OnChangeHandler OnChange;

    static Controller [] _controllerList = new[] {
      new Controller(UserIndex.One),
      new Controller(UserIndex.Two),
      new Controller(UserIndex.Three),
      new Controller(UserIndex.Four) };

    bool _isRunning = false;

    public static Controller[] GetAvailableControllers() {

      List<Controller> connectedList = new List<Controller>();

      foreach (var c in _controllerList)
        if (c.IsConnected)
          connectedList.Add(c);

      return connectedList.ToArray();
    }

    Controller _controller;
    System.Timers.Timer _timer;
    State _previousState;

    State invertState(State state) {

      state.Gamepad.LeftThumbY = (short)Math.Min(short.MaxValue, -(int)state.Gamepad.LeftThumbY);
      state.Gamepad.RightThumbY = (short)Math.Min(short.MaxValue, -(int)state.Gamepad.RightThumbY);

      return state;
    }

    public JoystickController(Controller controller) {

      try {

        _controller = controller;

        _previousState = invertState(_controller.GetState());

        _timer = new System.Timers.Timer();
        _timer.Interval = 100;
        _timer.Elapsed += _timer_Elapsed;
        _timer.Start();
      } catch (Exception ex) {

        OnStop?.Invoke(this, ex.Message);
      }
    }

    public Controller GetCurrentController => _controller;

    public bool IsRunning => _timer.Enabled;

    Vibration _vibration = new Vibration();

    public bool Paused
    {
      get;
      set;
    }

    public void VibrateStop() {

      if (!IsRunning)
        return;

      _vibration.LeftMotorSpeed = 0;
      _vibration.RightMotorSpeed = 0;

      _controller.SetVibration(_vibration);
    }

    private void _timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e) {

      if (Paused)
        return;

      if (_isRunning)
        return;

      _isRunning = true;

      try {

        if (!_controller.IsConnected)
          throw new Exception("Joystick has been disconnected");

        var state = invertState(_controller.GetState());

        if (_previousState.PacketNumber != state.PacketNumber)
          OnChange?.Invoke(this, _previousState, state);

        _previousState = state;
      } catch (Exception ex) {

        OnStop?.Invoke(this, ex.Message);
      } finally {

        _isRunning = false;
      }
    }

    protected override void DisposeOverride() {

      try {

        _timer.Stop();
        _timer.Dispose();
        _timer = null;

        _controller = null;
      } catch {

      }
    }
  }
}
