using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Control;
using DevExpress.XtraPrinting.Native;

namespace Common
{
    public class ClosePreview : ICommandHandler
    {
        public virtual void HandleCommand(PrintingSystemCommand command, object[] args, PrintControl control, ref bool handled)
        {
            if (!CanHandleCommand(command, control)) return;
            control.Dispose();
            handled = true;
        }

        public virtual bool CanHandleCommand(PrintingSystemCommand command, PrintControl control)
        {
            return command == PrintingSystemCommand.ClosePreview;
        }
    }
}
