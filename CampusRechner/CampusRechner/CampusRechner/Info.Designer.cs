namespace CampusRechner
{
    partial class Info
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
            this.L_info = new System.Windows.Forms.Label();
            this.B_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_info
            // 
            this.L_info.AutoSize = true;
            this.L_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_info.Location = new System.Drawing.Point(12, 9);
            this.L_info.Name = "L_info";
            this.L_info.Size = new System.Drawing.Size(566, 16);
            this.L_info.TabIndex = 0;
            this.L_info.Text = "Das Programm enstand in der Vorlesung Programmierung und Datenverarbeitung";
            this.L_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // B_OK
            // 
            this.B_OK.Location = new System.Drawing.Point(187, 44);
            this.B_OK.Name = "B_OK";
            this.B_OK.Size = new System.Drawing.Size(225, 23);
            this.B_OK.TabIndex = 1;
            this.B_OK.Text = "OK";
            this.B_OK.UseVisualStyleBackColor = true;
            this.B_OK.Click += new System.EventHandler(this.B_OK_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 92);
            this.Controls.Add(this.B_OK);
            this.Controls.Add(this.L_info);
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_info;
        private System.Windows.Forms.Button B_OK;
    }
}