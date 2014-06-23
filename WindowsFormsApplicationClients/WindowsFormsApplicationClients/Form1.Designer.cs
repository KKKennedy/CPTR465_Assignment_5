namespace WindowsFormsApplicationClients
{
    partial class FormMainClients
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
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ButtonClient1 = new System.Windows.Forms.Button();
            this.ButtonClient2 = new System.Windows.Forms.Button();
            this.ButtonClient3 = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(51, 23);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(221, 24);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Main Menu For Clients";
            // 
            // ButtonClient1
            // 
            this.ButtonClient1.Location = new System.Drawing.Point(108, 75);
            this.ButtonClient1.Name = "ButtonClient1";
            this.ButtonClient1.Size = new System.Drawing.Size(96, 23);
            this.ButtonClient1.TabIndex = 1;
            this.ButtonClient1.Text = "Start Client # 1";
            this.ButtonClient1.UseVisualStyleBackColor = true;
            this.ButtonClient1.Click += new System.EventHandler(this.ButtonClient1_Click);
            // 
            // ButtonClient2
            // 
            this.ButtonClient2.Location = new System.Drawing.Point(108, 131);
            this.ButtonClient2.Name = "ButtonClient2";
            this.ButtonClient2.Size = new System.Drawing.Size(96, 23);
            this.ButtonClient2.TabIndex = 2;
            this.ButtonClient2.Text = "Start Client # 2";
            this.ButtonClient2.UseVisualStyleBackColor = true;
            this.ButtonClient2.Click += new System.EventHandler(this.ButtonClient2_Click);
            // 
            // ButtonClient3
            // 
            this.ButtonClient3.Location = new System.Drawing.Point(108, 190);
            this.ButtonClient3.Name = "ButtonClient3";
            this.ButtonClient3.Size = new System.Drawing.Size(96, 23);
            this.ButtonClient3.TabIndex = 3;
            this.ButtonClient3.Text = "Start Client # 3";
            this.ButtonClient3.UseVisualStyleBackColor = true;
            this.ButtonClient3.Click += new System.EventHandler(this.ButtonClient3_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(117, 265);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(75, 23);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // FormMainClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 342);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonClient3);
            this.Controls.Add(this.ButtonClient2);
            this.Controls.Add(this.ButtonClient1);
            this.Controls.Add(this.LabelTitle);
            this.Name = "FormMainClients";
            this.Text = "Clients Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button ButtonClient1;
        private System.Windows.Forms.Button ButtonClient2;
        private System.Windows.Forms.Button ButtonClient3;
        private System.Windows.Forms.Button ButtonExit;
    }
}

