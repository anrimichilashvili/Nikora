using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikora.Helpers
{
    public class ScalesFormHelper
    {
        public ScalesFormHelper()
        {

        }
        public void ClearControls(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = string.Empty;
                }
                if (ctrl is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)ctrl;
                    comboBox.SelectedIndex = -1;
                    comboBox.Text = string.Empty;
                }
                else
                {
                    ClearControls(ctrl.Controls);
                }
            }
        }

        public bool Validation(List<Control> objectList)
        {
            foreach (var objectOfList in objectList)
            {
                if (objectOfList is TextBoxBase && objectOfList.Text == String.Empty)
                {
                    return false;
                }
            }

            return true;
        }

    }

}
