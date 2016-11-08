namespace ReactionTimeTester
{
    partial class Form_Main
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
            this._lblUsrn = new System.Windows.Forms.Label();
            this._lblPwd = new System.Windows.Forms.Label();
            this._tbxUsrn = new System.Windows.Forms.TextBox();
            this._tbxPwd = new System.Windows.Forms.TextBox();
            this._tbxCnfmPwd = new System.Windows.Forms.TextBox();
            this._lblCnfmPwd = new System.Windows.Forms.Label();
            this._cbxNew = new System.Windows.Forms.CheckBox();
            this._btnLogin = new System.Windows.Forms.Button();
            this._btnSignup = new System.Windows.Forms.Button();
            this._btnConfig = new System.Windows.Forms.Button();
            this._btnConn = new System.Windows.Forms.Button();
            this._lblStatus = new System.Windows.Forms.Label();
            this._lblCR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblUsrn
            // 
            this._lblUsrn.AutoSize = true;
            this._lblUsrn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblUsrn.Location = new System.Drawing.Point(12, 15);
            this._lblUsrn.Name = "_lblUsrn";
            this._lblUsrn.Size = new System.Drawing.Size(72, 16);
            this._lblUsrn.TabIndex = 0;
            this._lblUsrn.Text = "Username";
            // 
            // _lblPwd
            // 
            this._lblPwd.AutoSize = true;
            this._lblPwd.Location = new System.Drawing.Point(12, 43);
            this._lblPwd.Name = "_lblPwd";
            this._lblPwd.Size = new System.Drawing.Size(69, 16);
            this._lblPwd.TabIndex = 1;
            this._lblPwd.Text = "Password";
            // 
            // _tbxUsrn
            // 
            this._tbxUsrn.Location = new System.Drawing.Point(141, 12);
            this._tbxUsrn.Name = "_tbxUsrn";
            this._tbxUsrn.Size = new System.Drawing.Size(132, 22);
            this._tbxUsrn.TabIndex = 2;
            // 
            // _tbxPwd
            // 
            this._tbxPwd.Location = new System.Drawing.Point(141, 40);
            this._tbxPwd.Name = "_tbxPwd";
            this._tbxPwd.Size = new System.Drawing.Size(132, 22);
            this._tbxPwd.TabIndex = 3;
            // 
            // _tbxCnfmPwd
            // 
            this._tbxCnfmPwd.Location = new System.Drawing.Point(141, 68);
            this._tbxCnfmPwd.Name = "_tbxCnfmPwd";
            this._tbxCnfmPwd.Size = new System.Drawing.Size(132, 22);
            this._tbxCnfmPwd.TabIndex = 4;
            // 
            // _lblCnfmPwd
            // 
            this._lblCnfmPwd.AutoSize = true;
            this._lblCnfmPwd.Location = new System.Drawing.Point(12, 71);
            this._lblCnfmPwd.Name = "_lblCnfmPwd";
            this._lblCnfmPwd.Size = new System.Drawing.Size(123, 16);
            this._lblCnfmPwd.TabIndex = 5;
            this._lblCnfmPwd.Text = "Confirm Password";
            // 
            // _cbxNew
            // 
            this._cbxNew.AutoSize = true;
            this._cbxNew.Location = new System.Drawing.Point(279, 42);
            this._cbxNew.Name = "_cbxNew";
            this._cbxNew.Size = new System.Drawing.Size(87, 20);
            this._cbxNew.TabIndex = 6;
            this._cbxNew.Text = "New User";
            this._cbxNew.UseVisualStyleBackColor = true;
            // 
            // _btnLogin
            // 
            this._btnLogin.Location = new System.Drawing.Point(65, 127);
            this._btnLogin.Name = "_btnLogin";
            this._btnLogin.Size = new System.Drawing.Size(99, 29);
            this._btnLogin.TabIndex = 7;
            this._btnLogin.Text = "Log in";
            this._btnLogin.UseVisualStyleBackColor = true;
            // 
            // _btnSignup
            // 
            this._btnSignup.Location = new System.Drawing.Point(209, 127);
            this._btnSignup.Name = "_btnSignup";
            this._btnSignup.Size = new System.Drawing.Size(99, 29);
            this._btnSignup.TabIndex = 8;
            this._btnSignup.Text = "Sign up";
            this._btnSignup.UseVisualStyleBackColor = true;
            // 
            // _btnConfig
            // 
            this._btnConfig.Location = new System.Drawing.Point(66, 162);
            this._btnConfig.Name = "_btnConfig";
            this._btnConfig.Size = new System.Drawing.Size(99, 29);
            this._btnConfig.TabIndex = 9;
            this._btnConfig.Text = "Config";
            this._btnConfig.UseVisualStyleBackColor = true;
            this._btnConfig.Click += new System.EventHandler(this._btnConfig_Click);
            // 
            // _btnConn
            // 
            this._btnConn.Location = new System.Drawing.Point(209, 162);
            this._btnConn.Name = "_btnConn";
            this._btnConn.Size = new System.Drawing.Size(99, 29);
            this._btnConn.TabIndex = 10;
            this._btnConn.Text = "Connect";
            this._btnConn.UseVisualStyleBackColor = true;
            // 
            // _lblStatus
            // 
            this._lblStatus.AutoSize = true;
            this._lblStatus.Location = new System.Drawing.Point(12, 93);
            this._lblStatus.Name = "_lblStatus";
            this._lblStatus.Size = new System.Drawing.Size(152, 16);
            this._lblStatus.TabIndex = 11;
            this._lblStatus.Text = "xxxxxxxxxxxxxxxxxx";
            // 
            // _lblCR
            // 
            this._lblCR.AutoSize = true;
            this._lblCR.Location = new System.Drawing.Point(65, 218);
            this._lblCR.Name = "_lblCR";
            this._lblCR.Size = new System.Drawing.Size(292, 16);
            this._lblCR.TabIndex = 12;
            this._lblCR.Text = "© Copyright 2016 by Andy Tran and YunJie Li";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 243);
            this.Controls.Add(this._lblCR);
            this.Controls.Add(this._lblStatus);
            this.Controls.Add(this._btnConn);
            this.Controls.Add(this._btnConfig);
            this.Controls.Add(this._btnSignup);
            this.Controls.Add(this._btnLogin);
            this.Controls.Add(this._cbxNew);
            this.Controls.Add(this._lblCnfmPwd);
            this.Controls.Add(this._tbxCnfmPwd);
            this.Controls.Add(this._tbxPwd);
            this.Controls.Add(this._tbxUsrn);
            this.Controls.Add(this._lblPwd);
            this.Controls.Add(this._lblUsrn);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_Main";
            this.Text = "Reaction Time Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblUsrn;
        private System.Windows.Forms.Label _lblPwd;
        private System.Windows.Forms.TextBox _tbxUsrn;
        private System.Windows.Forms.TextBox _tbxPwd;
        private System.Windows.Forms.TextBox _tbxCnfmPwd;
        private System.Windows.Forms.Label _lblCnfmPwd;
        private System.Windows.Forms.CheckBox _cbxNew;
        private System.Windows.Forms.Button _btnLogin;
        private System.Windows.Forms.Button _btnSignup;
        private System.Windows.Forms.Button _btnConfig;
        private System.Windows.Forms.Button _btnConn;
        private System.Windows.Forms.Label _lblStatus;
        private System.Windows.Forms.Label _lblCR;
    }
}

