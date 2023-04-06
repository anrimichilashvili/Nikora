using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikora.Helpers
{
    public class LoginFormHelper
    {
        public LoginFormHelper()
        {

        }
        public bool Validation(List<Control> textBoxes)
        {
            foreach (var textbox in textBoxes)
            {
                if (textbox is TextBoxBase && textbox.Text == String.Empty)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
