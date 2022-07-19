using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.WinUI
{
    public class Helpers
    {
        public static void SetComboBoxPlaceholderColor(ComboBox control)
        {
            if(control.SelectedIndex == 0)
            {
                control.ForeColor = Color.FromArgb(255, 109, 109, 109);
            }
            else
            {
                control.ForeColor = Color.FromArgb(255, 211, 211, 213);
            }
        }
    }
}
