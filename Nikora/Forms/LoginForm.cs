using Nikora.Core.Interfaces;
using Nikora.Core.Models.DataLayer;
using Nikora.Forms;
using Nikora.Helpers;

namespace Nikora
{
    public partial class LoginForm : Form/*, IUserView*/
    {
        LoginFormHelper LoginFormHelper;
        NikoraDBContext NikoraDBContext;
        public LoginForm()
        {
            LoginFormHelper = new LoginFormHelper();
             NikoraDBContext = new NikoraDBContext();
            InitializeComponent();
        }
        

        //public int UserId 
        //{ 
        //    get => throw new NotImplementedException(); 
        //    set => throw new NotImplementedException(); 
        //}
        //public string UserName 
        //{ 
        //    get => throw new NotImplementedException();
        //    set => throw new NotImplementedException();
        //}
        //public string Password 
        //{ 
        //    get => throw new NotImplementedException(); 
        //    set => throw new NotImplementedException(); 
        //}
        //public string SearchValue 
        //{ 
        //    get => throw new NotImplementedException(); 
        //    set => throw new NotImplementedException(); 
        //}
        //public bool IsEdit
        //{
        //    get => throw new NotImplementedException(); 
        //    set => throw new NotImplementedException(); 
        //}
        //public bool IsSuccessful 
        //{ 
        //    get => throw new NotImplementedException(); 
        //    set => throw new NotImplementedException(); 
        //}
        //public string Message 
        //{ 
        //    get => throw new NotImplementedException(); 
        //    set => throw new NotImplementedException(); 
        //}

        //public event EventHandler SearchEvent;
        //public event EventHandler AddNewEvent;
        //public event EventHandler EditEvent;
        //public event EventHandler DeleteEvent;
        //public event EventHandler SaveEvent;
        //public event EventHandler CancelEvent;

        private void loginButton_Click(object sender, EventArgs e)
        {
            List<Control> texboxes = new List<Control>();
            texboxes.Add(userNameTextBox);
            texboxes.Add(passwordTextBox);
            if (!LoginFormHelper.Validation(texboxes))
            {
                try
                {
                    var user = NikoraDBContext.UserModels.Where(x=>x.UserName== userNameTextBox.Text && x.Password== passwordTextBox.Text);
                    if (user != null)
                    {
                        ScalesForm scalesForm = new ScalesForm();
                        scalesForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("აღნიშნული user არ არსებობს");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("შეავსეთ ყველა ველი");
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }
    }
}