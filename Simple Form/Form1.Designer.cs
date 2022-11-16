namespace Simple_Form
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Thoughts = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.UserName = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.SignIn = new System.Windows.Forms.Button();
            this.SignInObjects = new System.Windows.Forms.GroupBox();
            this.SubmitYourThoughts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SignInObjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // Thoughts
            // 
            this.Thoughts.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoughts.Location = new System.Drawing.Point(139, 61);
            this.Thoughts.Multiline = true;
            this.Thoughts.Name = "Thoughts";
            this.Thoughts.PasswordChar = '*';
            this.Thoughts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Thoughts.Size = new System.Drawing.Size(592, 240);
            this.Thoughts.TabIndex = 1;
            this.Thoughts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Thoughts_MouseClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(207, 323);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 28);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Show Text";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // UserName
            // 
            this.UserName.AccessibleName = "";
            this.UserName.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Bold);
            this.UserName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UserName.Location = new System.Drawing.Point(11, 99);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(122, 39);
            this.UserName.TabIndex = 3;
            this.UserName.Tag = "";
            this.UserName.Text = "User Name";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Password
            // 
            this.Password.AccessibleName = "";
            this.Password.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Bold);
            this.Password.Location = new System.Drawing.Point(11, 145);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(121, 33);
            this.Password.TabIndex = 4;
            this.Password.Tag = "";
            this.Password.Text = "Password";
            this.Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameTxt
            // 
            this.usernameTxt.AccessibleName = "";
            this.usernameTxt.Font = new System.Drawing.Font("Old English Text MT", 14F, System.Drawing.FontStyle.Bold);
            this.usernameTxt.Location = new System.Drawing.Point(139, 99);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(359, 36);
            this.usernameTxt.TabIndex = 5;
            this.usernameTxt.Tag = "";
            // 
            // passwordTxt
            // 
            this.passwordTxt.AccessibleName = "";
            this.passwordTxt.Font = new System.Drawing.Font("Old English Text MT", 14F, System.Drawing.FontStyle.Bold);
            this.passwordTxt.Location = new System.Drawing.Point(139, 142);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '?';
            this.passwordTxt.Size = new System.Drawing.Size(359, 36);
            this.passwordTxt.TabIndex = 6;
            this.passwordTxt.Tag = "";
            // 
            // SignIn
            // 
            this.SignIn.AccessibleName = "";
            this.SignIn.Font = new System.Drawing.Font("Old English Text MT", 16F, System.Drawing.FontStyle.Bold);
            this.SignIn.Location = new System.Drawing.Point(219, 191);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(165, 48);
            this.SignIn.TabIndex = 7;
            this.SignIn.Tag = "";
            this.SignIn.Text = "Sign In";
            this.SignIn.UseVisualStyleBackColor = true;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // SignInObjects
            // 
            this.SignInObjects.Controls.Add(this.Thoughts);
            this.SignInObjects.Controls.Add(this.SubmitYourThoughts);
            this.SignInObjects.Controls.Add(this.checkBox1);
            this.SignInObjects.Location = new System.Drawing.Point(-2, 67);
            this.SignInObjects.Name = "SignInObjects";
            this.SignInObjects.Size = new System.Drawing.Size(904, 381);
            this.SignInObjects.TabIndex = 8;
            this.SignInObjects.TabStop = false;
            this.SignInObjects.Visible = false;
            // 
            // SubmitYourThoughts
            // 
            this.SubmitYourThoughts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SubmitYourThoughts.Font = new System.Drawing.Font("Old English Text MT", 10F, System.Drawing.FontStyle.Bold);
            this.SubmitYourThoughts.Location = new System.Drawing.Point(354, 307);
            this.SubmitYourThoughts.Name = "SubmitYourThoughts";
            this.SubmitYourThoughts.Size = new System.Drawing.Size(245, 58);
            this.SubmitYourThoughts.TabIndex = 3;
            this.SubmitYourThoughts.Text = "Submit Your Thoughts";
            this.SubmitYourThoughts.UseVisualStyleBackColor = false;
            this.SubmitYourThoughts.Click += new System.EventHandler(this.SubmitYourThoughts_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(-2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(904, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hellow World This is my first label! maybe!=D";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.SignInObjects);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Font = new System.Drawing.Font("Old English Text MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SignInObjects.ResumeLayout(false);
            this.SignInObjects.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Thoughts;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.GroupBox SignInObjects;
        private System.Windows.Forms.Button SubmitYourThoughts;
        private System.Windows.Forms.Label label1;
    }
}

