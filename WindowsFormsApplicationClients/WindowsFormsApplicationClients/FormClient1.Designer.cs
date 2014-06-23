namespace WindowsFormsApplicationClients
{
    partial class FormClient2
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
            this.ButtonSendData = new System.Windows.Forms.Button();
            this.ComboBoxSendData = new System.Windows.Forms.ComboBox();
            this.LabelClientConn = new System.Windows.Forms.Label();
            this.TextBoxDialog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonSendData
            // 
            this.ButtonSendData.Location = new System.Drawing.Point(36, 307);
            this.ButtonSendData.Name = "ButtonSendData";
            this.ButtonSendData.Size = new System.Drawing.Size(75, 23);
            this.ButtonSendData.TabIndex = 0;
            this.ButtonSendData.Text = "Send Data";
            this.ButtonSendData.UseVisualStyleBackColor = true;
            this.ButtonSendData.Click += new System.EventHandler(this.ButtonSendData_Click);
            // 
            // ComboBoxSendData
            // 
            this.ComboBoxSendData.FormattingEnabled = true;
            this.ComboBoxSendData.Items.AddRange(new object[] {
            "ADD",
            "MINUS",
            "DIVIDE"});
            this.ComboBoxSendData.Location = new System.Drawing.Point(130, 309);
            this.ComboBoxSendData.Name = "ComboBoxSendData";
            this.ComboBoxSendData.Size = new System.Drawing.Size(276, 21);
            this.ComboBoxSendData.TabIndex = 1;
            this.ComboBoxSendData.Text = "Select Data to be Sent";
            this.ComboBoxSendData.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSendData_SelectedIndexChanged);
            // 
            // LabelClientConn
            // 
            this.LabelClientConn.AutoSize = true;
            this.LabelClientConn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelClientConn.Location = new System.Drawing.Point(53, 24);
            this.LabelClientConn.Name = "LabelClientConn";
            this.LabelClientConn.Size = new System.Drawing.Size(311, 19);
            this.LabelClientConn.TabIndex = 2;
            this.LabelClientConn.Text = "Client Connected to Advanced Application Server";
            this.LabelClientConn.Click += new System.EventHandler(this.LabelClientConn_Click);
            // 
            // TextBoxDialog
            // 
            this.TextBoxDialog.Location = new System.Drawing.Point(36, 58);
            this.TextBoxDialog.Multiline = true;
            this.TextBoxDialog.Name = "TextBoxDialog";
            this.TextBoxDialog.Size = new System.Drawing.Size(370, 231);
            this.TextBoxDialog.TabIndex = 3;
            this.TextBoxDialog.TextChanged += new System.EventHandler(this.TextBoxDialog_TextChanged);
            // 
            // FormClient2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 364);
            this.Controls.Add(this.TextBoxDialog);
            this.Controls.Add(this.LabelClientConn);
            this.Controls.Add(this.ComboBoxSendData);
            this.Controls.Add(this.ButtonSendData);
            this.Name = "FormClient2";
            this.Text = "Client --> # 1";
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSendData;
        private System.Windows.Forms.ComboBox ComboBoxSendData;
        private System.Windows.Forms.Label LabelClientConn;
        private System.Windows.Forms.TextBox TextBoxDialog;
    }
}