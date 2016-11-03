namespace ReactionTimeTester
{
    partial class Form_Config
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
            this._lblPortName = new System.Windows.Forms.Label();
            this._lblBaudRate = new System.Windows.Forms.Label();
            this._lblDataBits = new System.Windows.Forms.Label();
            this._lblStopBits = new System.Windows.Forms.Label();
            this._lblHandshake = new System.Windows.Forms.Label();
            this._lblParity = new System.Windows.Forms.Label();
            this._ddlPortName = new System.Windows.Forms.ComboBox();
            this._ddlBaudRate = new System.Windows.Forms.ComboBox();
            this._ddlDataBits = new System.Windows.Forms.ComboBox();
            this._ddlStopBits = new System.Windows.Forms.ComboBox();
            this._ddlHandshake = new System.Windows.Forms.ComboBox();
            this._ddlParity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _lblPortName
            // 
            this._lblPortName.AutoSize = true;
            this._lblPortName.Location = new System.Drawing.Point(33, 45);
            this._lblPortName.Name = "_lblPortName";
            this._lblPortName.Size = new System.Drawing.Size(57, 13);
            this._lblPortName.TabIndex = 0;
            this._lblPortName.Text = "Port Name";
            // 
            // _lblBaudRate
            // 
            this._lblBaudRate.AutoSize = true;
            this._lblBaudRate.Location = new System.Drawing.Point(33, 72);
            this._lblBaudRate.Name = "_lblBaudRate";
            this._lblBaudRate.Size = new System.Drawing.Size(58, 13);
            this._lblBaudRate.TabIndex = 1;
            this._lblBaudRate.Text = "Baud Rate";
            // 
            // _lblDataBits
            // 
            this._lblDataBits.AutoSize = true;
            this._lblDataBits.Location = new System.Drawing.Point(33, 99);
            this._lblDataBits.Name = "_lblDataBits";
            this._lblDataBits.Size = new System.Drawing.Size(50, 13);
            this._lblDataBits.TabIndex = 1;
            this._lblDataBits.Text = "Data Bits";
            // 
            // _lblStopBits
            // 
            this._lblStopBits.AutoSize = true;
            this._lblStopBits.Location = new System.Drawing.Point(33, 126);
            this._lblStopBits.Name = "_lblStopBits";
            this._lblStopBits.Size = new System.Drawing.Size(49, 13);
            this._lblStopBits.TabIndex = 1;
            this._lblStopBits.Text = "Stop Bits";
            // 
            // _lblHandshake
            // 
            this._lblHandshake.AutoSize = true;
            this._lblHandshake.Location = new System.Drawing.Point(33, 153);
            this._lblHandshake.Name = "_lblHandshake";
            this._lblHandshake.Size = new System.Drawing.Size(62, 13);
            this._lblHandshake.TabIndex = 1;
            this._lblHandshake.Text = "Handshake";
            // 
            // _lblParity
            // 
            this._lblParity.AutoSize = true;
            this._lblParity.Location = new System.Drawing.Point(33, 180);
            this._lblParity.Name = "_lblParity";
            this._lblParity.Size = new System.Drawing.Size(33, 13);
            this._lblParity.TabIndex = 1;
            this._lblParity.Text = "Parity";
            // 
            // _ddlPortName
            // 
            this._ddlPortName.FormattingEnabled = true;
            this._ddlPortName.Location = new System.Drawing.Point(94, 42);
            this._ddlPortName.Name = "_ddlPortName";
            this._ddlPortName.Size = new System.Drawing.Size(121, 21);
            this._ddlPortName.TabIndex = 2;
            // 
            // _ddlBaudRate
            // 
            this._ddlBaudRate.FormattingEnabled = true;
            this._ddlBaudRate.Location = new System.Drawing.Point(94, 69);
            this._ddlBaudRate.Name = "_ddlBaudRate";
            this._ddlBaudRate.Size = new System.Drawing.Size(121, 21);
            this._ddlBaudRate.TabIndex = 2;
            // 
            // _ddlDataBits
            // 
            this._ddlDataBits.FormattingEnabled = true;
            this._ddlDataBits.Location = new System.Drawing.Point(94, 96);
            this._ddlDataBits.Name = "_ddlDataBits";
            this._ddlDataBits.Size = new System.Drawing.Size(121, 21);
            this._ddlDataBits.TabIndex = 2;
            // 
            // _ddlStopBits
            // 
            this._ddlStopBits.FormattingEnabled = true;
            this._ddlStopBits.Location = new System.Drawing.Point(94, 123);
            this._ddlStopBits.Name = "_ddlStopBits";
            this._ddlStopBits.Size = new System.Drawing.Size(121, 21);
            this._ddlStopBits.TabIndex = 2;
            // 
            // _ddlHandshake
            // 
            this._ddlHandshake.FormattingEnabled = true;
            this._ddlHandshake.Location = new System.Drawing.Point(94, 150);
            this._ddlHandshake.Name = "_ddlHandshake";
            this._ddlHandshake.Size = new System.Drawing.Size(121, 21);
            this._ddlHandshake.TabIndex = 2;
            // 
            // _ddlParity
            // 
            this._ddlParity.FormattingEnabled = true;
            this._ddlParity.Location = new System.Drawing.Point(94, 177);
            this._ddlParity.Name = "_ddlParity";
            this._ddlParity.Size = new System.Drawing.Size(121, 21);
            this._ddlParity.TabIndex = 2;
            // 
            // Form_Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 227);
            this.Controls.Add(this._ddlParity);
            this.Controls.Add(this._ddlHandshake);
            this.Controls.Add(this._ddlStopBits);
            this.Controls.Add(this._ddlDataBits);
            this.Controls.Add(this._ddlBaudRate);
            this.Controls.Add(this._ddlPortName);
            this.Controls.Add(this._lblParity);
            this.Controls.Add(this._lblHandshake);
            this.Controls.Add(this._lblStopBits);
            this.Controls.Add(this._lblDataBits);
            this.Controls.Add(this._lblBaudRate);
            this.Controls.Add(this._lblPortName);
            this.Name = "Form_Config";
            this.Text = "Serial Port Config";
            this.Load += new System.EventHandler(this.Form_Config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblPortName;
        private System.Windows.Forms.Label _lblBaudRate;
        private System.Windows.Forms.Label _lblDataBits;
        private System.Windows.Forms.Label _lblStopBits;
        private System.Windows.Forms.Label _lblHandshake;
        private System.Windows.Forms.Label _lblParity;
        private System.Windows.Forms.ComboBox _ddlPortName;
        private System.Windows.Forms.ComboBox _ddlBaudRate;
        private System.Windows.Forms.ComboBox _ddlDataBits;
        private System.Windows.Forms.ComboBox _ddlStopBits;
        private System.Windows.Forms.ComboBox _ddlHandshake;
        private System.Windows.Forms.ComboBox _ddlParity;
    }
}