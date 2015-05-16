using System.Windows.Forms;
using MetroFramework.Controls;

namespace Sh0utbox
{
    public class MetroTextBoxEx : MetroTextBox
    {
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Back))
            {
                
                SendKeys.SendWait("^+{LEFT}{BACKSPACE}");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.A)
                {
                    base.SelectAll();
                }
            }
        }
    }
}