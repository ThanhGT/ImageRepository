
namespace ImageRepository
{
    partial class NewAccount
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
            this.passBox2 = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(364, 130);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(100, 22);
            this.userBox.TabIndex = 0;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(364, 158);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(100, 22);
            this.passBox.TabIndex = 1;
            this.passBox.TextChanged += new System.EventHandler(this.passBox_TextChanged);
            // 
            // passBox2
            // 
            this.passBox2.Location = new System.Drawing.Point(364, 186);
            this.passBox2.Name = "passBox2";
            this.passBox2.Size = new System.Drawing.Size(100, 22);
            this.passBox2.TabIndex = 2;
            this.passBox2.TextChanged += new System.EventHandler(this.passBox2_TextChanged);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(285, 130);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(73, 17);
            this.userLabel.TabIndex = 4;
            this.userLabel.Text = "Username";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(285, 161);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(69, 17);
            this.passLabel.TabIndex = 5;
            this.passLabel.Text = "Password";
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Location = new System.Drawing.Point(233, 189);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(121, 17);
            this.confirmLabel.TabIndex = 6;
            this.confirmLabel.Text = "Confirm Password";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(364, 224);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(80, 30);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.passBox2);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.userBox);
            this.Name = "NewAccount";
            this.Text = "NewAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox passBox2;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.Button submitButton;
    }
}