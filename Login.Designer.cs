
namespace ImageRepository
{
    partial class Login
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
            this.userBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.createAccount = new System.Windows.Forms.Button();
            this.msgLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(337, 163);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(100, 22);
            this.userBox.TabIndex = 0;
            this.userBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(337, 214);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(100, 22);
            this.passBox.TabIndex = 1;
            this.passBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(260, 163);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(47, 17);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Login:";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(260, 217);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(73, 17);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "Password:";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(337, 258);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 29);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // createAccount
            // 
            this.createAccount.Location = new System.Drawing.Point(337, 293);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(123, 33);
            this.createAccount.TabIndex = 5;
            this.createAccount.Text = "Create Account";
            this.createAccount.UseVisualStyleBackColor = true;
            this.createAccount.Click += new System.EventHandler(this.createAccount_Click);
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.ForeColor = System.Drawing.Color.Red;
            this.msgLabel.Location = new System.Drawing.Point(334, 131);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(0, 17);
            this.msgLabel.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.createAccount);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.userBox);
            this.Name = "Login";
            this.Text = "Password:";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button createAccount;
        private System.Windows.Forms.Label msgLabel;
    }
}