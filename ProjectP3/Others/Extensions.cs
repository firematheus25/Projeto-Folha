using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectP3.Others
{
    public static class Extensions
    {
        public static void DropDownWidth(this ComboBox combo)
        {
            var maxWidth = 0;
            int temp;
            var label1 = new Label();

            foreach (var obj in combo.Items)
            {
                label1.Text = obj.ToString();
                temp = label1.PreferredWidth;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            label1.Dispose();
            combo.DropDownWidth = maxWidth;
        }
    }
}
