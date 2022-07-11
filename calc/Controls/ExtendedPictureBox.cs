namespace murrty.controls;

using System.Windows.Forms;

/// <inheritdoc/>
public class ExtendedPictureBox : PictureBox {
    /// <inheritdoc/>
    protected override void WndProc(ref Message m) {
        switch (m.Msg) {
            case ControlCursors.WM_SETCURSOR: {
                if (Cursor == Cursors.Hand) {
                    NativeMethods.SetCursor(ControlCursors.SystemHand);
                    m.Result = (IntPtr)0;
                    return;
                }
                base.WndProc(ref m);
            } break;

            default: {
                base.WndProc(ref m);
            } break;
        }
    }

}