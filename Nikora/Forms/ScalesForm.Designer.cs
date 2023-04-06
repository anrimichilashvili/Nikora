namespace Nikora.Forms
{
    partial class ScalesForm
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
            this.scaleIPTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.scalePortTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.scaleNameTextBox = new System.Windows.Forms.TextBox();
            this.displayScaleButton = new System.Windows.Forms.Button();
            this.disconectButton = new System.Windows.Forms.Button();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sclaesComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scale IP";
            // 
            // scaleIPTextBox
            // 
            this.scaleIPTextBox.Location = new System.Drawing.Point(12, 27);
            this.scaleIPTextBox.Name = "scaleIPTextBox";
            this.scaleIPTextBox.Size = new System.Drawing.Size(134, 23);
            this.scaleIPTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Scale Port";
            // 
            // scalePortTextBox
            // 
            this.scalePortTextBox.Location = new System.Drawing.Point(12, 89);
            this.scalePortTextBox.Name = "scalePortTextBox";
            this.scalePortTextBox.Size = new System.Drawing.Size(134, 23);
            this.scalePortTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Scale Name";
            // 
            // scaleNameTextBox
            // 
            this.scaleNameTextBox.Location = new System.Drawing.Point(12, 157);
            this.scaleNameTextBox.Name = "scaleNameTextBox";
            this.scaleNameTextBox.Size = new System.Drawing.Size(134, 23);
            this.scaleNameTextBox.TabIndex = 5;
            // 
            // displayScaleButton
            // 
            this.displayScaleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.displayScaleButton.Location = new System.Drawing.Point(270, 356);
            this.displayScaleButton.Name = "displayScaleButton";
            this.displayScaleButton.Size = new System.Drawing.Size(75, 23);
            this.displayScaleButton.TabIndex = 6;
            this.displayScaleButton.Text = "Display";
            this.displayScaleButton.UseVisualStyleBackColor = true;
            this.displayScaleButton.Click += new System.EventHandler(this.displayScaleButton_Click);
            // 
            // disconectButton
            // 
            this.disconectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.disconectButton.Location = new System.Drawing.Point(148, 356);
            this.disconectButton.Name = "disconectButton";
            this.disconectButton.Size = new System.Drawing.Size(116, 23);
            this.disconectButton.TabIndex = 7;
            this.disconectButton.Text = "Disconect";
            this.disconectButton.UseVisualStyleBackColor = true;
            this.disconectButton.Click += new System.EventHandler(this.removeDisplay_Click);
            // 
            // weightTextBox
            // 
            this.weightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.weightTextBox.Location = new System.Drawing.Point(245, 27);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 23);
            this.weightTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Weight";
            // 
            // sclaesComboBox
            // 
            this.sclaesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sclaesComboBox.FormattingEnabled = true;
            this.sclaesComboBox.Location = new System.Drawing.Point(224, 89);
            this.sclaesComboBox.Name = "sclaesComboBox";
            this.sclaesComboBox.Size = new System.Drawing.Size(121, 23);
            this.sclaesComboBox.TabIndex = 10;
            this.sclaesComboBox.SelectedIndexChanged += new System.EventHandler(this.sclaesComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Scales";
            // 
            // ScalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 391);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sclaesComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.disconectButton);
            this.Controls.Add(this.displayScaleButton);
            this.Controls.Add(this.scaleNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scalePortTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scaleIPTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ScalesForm";
            this.Text = "ScalesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox scaleIPTextBox;
        private Label label2;
        private TextBox scalePortTextBox;
        private Label label3;
        private TextBox scaleNameTextBox;
        private Button displayScaleButton;
        private Button disconectButton;
        private TextBox weightTextBox;
        private Label label4;
        private ComboBox sclaesComboBox;
        private Label label5;
    }
}