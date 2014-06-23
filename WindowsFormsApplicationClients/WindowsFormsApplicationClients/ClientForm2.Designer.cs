namespace WindowsFormsApplicationClients
{
    partial class ClientForm2
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
            this.TextBoxDialog = new System.Windows.Forms.TextBox();
            this.LabelClientConn = new System.Windows.Forms.Label();
            this.ComboBoxSendData = new System.Windows.Forms.ComboBox();
            this.ButtonSendData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxDialog
            // 
            this.TextBoxDialog.Location = new System.Drawing.Point(37, 75);
            this.TextBoxDialog.Multiline = true;
            this.TextBoxDialog.Name = "TextBoxDialog";
            this.TextBoxDialog.Size = new System.Drawing.Size(370, 231);
            this.TextBoxDialog.TabIndex = 7;
            // 
            // LabelClientConn
            // 
            this.LabelClientConn.AutoSize = true;
            this.LabelClientConn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelClientConn.Location = new System.Drawing.Point(60, 34);
            this.LabelClientConn.Name = "LabelClientConn";
            this.LabelClientConn.Size = new System.Drawing.Size(311, 19);
            this.LabelClientConn.TabIndex = 6;
            this.LabelClientConn.Text = "Client Connected to Advanced Application Server";
            // 
            // ComboBoxSendData
            // 
            this.ComboBoxSendData.FormattingEnabled = true;
            this.ComboBoxSendData.Items.AddRange(new object[] {
            "ADD",
            "MINUS",
            "DIVIDE"});
            this.ComboBoxSendData.Location = new System.Drawing.Point(131, 329);
            this.ComboBoxSendData.Name = "ComboBoxSendData";
            this.ComboBoxSendData.Size = new System.Drawing.Size(276, 21);
            this.ComboBoxSendData.TabIndex = 5;
            this.ComboBoxSendData.Text = "Select Data to be Sent";
            // 
            // ButtonSendData
            // 
            this.ButtonSendData.Location = new System.Drawing.Point(37, 329);
            this.ButtonSendData.Name = "ButtonSendData";
            this.ButtonSendData.Size = new System.Drawing.Size(75, 23);
            this.ButtonSendData.TabIndex = 4;
            this.ButtonSendData.Text = "Send Data";
            this.ButtonSendData.UseVisualStyleBackColor = true;
            this.ButtonSendData.Click += new System.EventHandler(this.ButtonSendData_Click);
            // 
            // ClientForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 380);
            this.Controls.Add(this.TextBoxDialog);
            this.Controls.Add(this.LabelClientConn);
            this.Controls.Add(this.ComboBoxSendData);
            this.Controls.Add(this.ButtonSendData);
            this.Name = "ClientForm2";
            this.Text = "Client --> # 2";
            this.Load += new System.EventHandler(this.ClientForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxDialog;
        private System.Windows.Forms.Label LabelClientConn;
        private System.Windows.Forms.ComboBox ComboBoxSendData;
        private System.Windows.Forms.Button ButtonSendData;
    }
}