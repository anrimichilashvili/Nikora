namespace Nikora.Forms
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.registerUserNameTextBox = new System.Windows.Forms.Label();
            this.registerUserPass = new System.Windows.Forms.Label();
            this.registerUserPasswordTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "რეგისტრაცია";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(363, 23);
            this.textBox1.TabIndex = 1;
            // 
            // registerUserNameTextBox
            // 
            this.registerUserNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registerUserNameTextBox.AutoSize = true;
            this.registerUserNameTextBox.Location = new System.Drawing.Point(12, 100);
            this.registerUserNameTextBox.Name = "registerUserNameTextBox";
            this.registerUserNameTextBox.Size = new System.Drawing.Size(88, 15);
            this.registerUserNameTextBox.TabIndex = 2;
            this.registerUserNameTextBox.Text = "User UserName";
            // 
            // registerUserPass
            // 
            this.registerUserPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registerUserPass.AutoSize = true;
            this.registerUserPass.Location = new System.Drawing.Point(12, 198);
            this.registerUserPass.Name = "registerUserPass";
            this.registerUserPass.Size = new System.Drawing.Size(83, 15);
            this.registerUserPass.TabIndex = 3;
            this.registerUserPass.Text = "User Password";
            // 
            // registerUserPasswordTextBox
            // 
            this.registerUserPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registerUserPasswordTextBox.Location = new System.Drawing.Point(12, 216);
            this.registerUserPasswordTextBox.Name = "registerUserPasswordTextBox";
            this.registerUserPasswordTextBox.Size = new System.Drawing.Size(363, 23);
            this.registerUserPasswordTextBox.TabIndex = 4;
            // 
            // registerButton
            // 
            this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.registerButton.Location = new System.Drawing.Point(300, 381);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 416);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.registerUserPasswordTextBox);
            this.Controls.Add(this.registerUserPass);
            this.Controls.Add(this.registerUserNameTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label registerUserNameTextBox;
        private Label registerUserPass;
        private TextBox registerUserPasswordTextBox;
        private Button registerButton;
    }
}