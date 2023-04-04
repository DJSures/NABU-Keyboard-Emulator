using System;

namespace EZ_B {

  public abstract class DisposableBase : IDisposable {

    public bool IsDisposing {
      get;
      private set;
    } = false;

    public bool IsDisposed {
      get;
      private set;
    } = false;

    public void Dispose() {

      Dispose(true);
    }

    private void Dispose(bool disposing) {

      if (disposing && IsDisposed == false) {

        IsDisposing = true;

        DisposeOverride();

        IsDisposed = true;
      }

      GC.SuppressFinalize(this);
    }

    protected abstract void DisposeOverride();
  }
}
