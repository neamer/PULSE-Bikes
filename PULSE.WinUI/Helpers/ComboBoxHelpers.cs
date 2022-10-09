using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.WinUI.Helpers
{
    public class ComboBoxHelpers
    {
        public static void SetComboBoxPlaceholderColor(ComboBox control)
        {
            if (control.SelectedIndex == 0)
            {
                control.ForeColor = Color.FromArgb(255, 109, 109, 109);
            }
            else
            {
                control.ForeColor = Color.FromArgb(255, 211, 211, 213);
            }
        }

        public static async void LoadComboBoxItemsFromAPI<T>(ComboBox cb, APIService service)
        {
            cb.SelectedIndex = 0;

            var list = await service.Get<List<T>>();

            if(list == null)
            {
                return;
            }

            foreach (var item in list)
            {
                cb.Items.Add(item);
            }

        }

        public static void LoadComboBoxItems<T>(ComboBox cb, List<T> list)
        {
            cb.SelectedIndex = 0;

            if(list == null)
            {
                return;
            }

            foreach (var item in list)
            {
                cb.Items.Add(item);
            }

        }
    }
}
