namespace GroupProjectLoginForm
{
    partial class formLogin
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
            this.txtboxUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtboxPass = new System.Windows.Forms.TextBox();
            this.chkboxShowPass = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblHaveAccount = new System.Windows.Forms.Label();
            this.lblGoToSignUp = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxUser
            // 
            this.txtboxUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtboxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxUser.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxUser.Location = new System.Drawing.Point(60, 135);
            this.txtboxUser.Multiline = true;
            this.txtboxUser.Name = "txtboxUser";
            this.txtboxUser.Size = new System.Drawing.Size(208, 31);
            this.txtboxUser.TabIndex = 4;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Gray;
            this.lblUser.Location = new System.Drawing.Point(57, 114);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(69, 17);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "Username";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.Gray;
            this.lblPass.Location = new System.Drawing.Point(57, 180);
            this.lblPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(66, 17);
            this.lblPass.TabIndex = 7;
            this.lblPass.Text = "Password";
            // 
            // txtboxPass
            // 
            this.txtboxPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtboxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxPass.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPass.Location = new System.Drawing.Point(60, 201);
            this.txtboxPass.Multiline = true;
            this.txtboxPass.Name = "txtboxPass";
            this.txtboxPass.Size = new System.Drawing.Size(208, 31);
            this.txtboxPass.TabIndex = 6;
            // 
            // chkboxShowPass
            // 
            this.chkboxShowPass.AutoSize = true;
            this.chkboxShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkboxShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkboxShowPass.Location = new System.Drawing.Point(149, 238);
            this.chkboxShowPass.Name = "chkboxShowPass";
            this.chkboxShowPass.Size = new System.Drawing.Size(119, 21);
            this.chkboxShowPass.TabIndex = 10;
            this.chkboxShowPass.Text = "Show Password";
            this.chkboxShowPass.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.btnClear.Location = new System.Drawing.Point(95, 337);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 38);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblHaveAccount
            // 
            this.lblHaveAccount.AutoSize = true;
            this.lblHaveAccount.Location = new System.Drawing.Point(86, 405);
            this.lblHaveAccount.Name = "lblHaveAccount";
            this.lblHaveAccount.Size = new System.Drawing.Size(152, 17);
            this.lblHaveAccount.TabIndex = 15;
            this.lblHaveAccount.Text = "Don\'t have an account?";
            // 
            // lblGoToSignUp
            // 
            this.lblGoToSignUp.AutoSize = true;
            this.lblGoToSignUp.Location = new System.Drawing.Point(120, 433);
            this.lblGoToSignUp.Name = "lblGoToSignUp";
            this.lblGoToSignUp.Size = new System.Drawing.Size(86, 17);
            this.lblGoToSignUp.TabIndex = 16;
            this.lblGoToSignUp.Text = "Sign up here";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(95, 282);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(134, 38);
            this.btnLogin.TabIndex = 17;
            this.btnLogin.Text = "LOG IN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(330, 500);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblGoToSignUp);
            this.Controls.Add(this.lblHaveAccount);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.chkboxShowPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtboxPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtboxUser);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtboxUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtboxPass;
        private System.Windows.Forms.CheckBox chkboxShowPass;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblHaveAccount;
        private System.Windows.Forms.Label lblGoToSignUp;
        private System.Windows.Forms.Button btnLogin;
    }
}

