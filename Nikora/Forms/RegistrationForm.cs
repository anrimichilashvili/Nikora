using Nikora.Core.Models.DataLayer;
using Nikora.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nikora.Forms
{
    public partial class RegistrationForm : Form
    {
        RegistrationFormHelper RegistrationFormHelper;
        NikoraDBContext NikoraDBContext;
        public RegistrationForm()
        {
            NikoraDBContext = new NikoraDBContext();
            RegistrationFormHelper = new RegistrationFormHelper();
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            List<Control> texboxes =  new List<Control>();
            texboxes.Add(registerUserNamelabel);
            texboxes.Add(registerUserPasswordTextBox);
            if (RegistrationFormHelper.Validation(texboxes))
            {
                UserModel userModel = new UserModel();
                userModel.UserName = registerUserNameTextBox.Text;
                userModel.Password = registerUserPasswordTextBox.Text;
                try
                {
                   NikoraDBContext.UserModels.Add(userModel);
                   NikoraDBContext.SaveChanges();
                    

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("შეავსეთ ყველა ველი");
            }
        }
    }
}
