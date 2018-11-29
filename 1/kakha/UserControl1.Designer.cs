namespace kakha
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btt = new System.Windows.Forms.Button();
            this.lab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btt
            // 
            this.btt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt.ForeColor = System.Drawing.Color.Gold;
            this.btt.Location = new System.Drawing.Point(3, 3);
            this.btt.Name = "btt";
            this.btt.Size = new System.Drawing.Size(116, 102);
            this.btt.TabIndex = 0;
            this.btt.Text = "button1";
            this.btt.UseVisualStyleBackColor = false;
            this.btt.Click += new System.EventHandler(this.btt_Click);
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lab.Location = new System.Drawing.Point(34, 67);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(52, 17);
            this.lab.TabIndex = 1;
            this.lab.Text = "label1";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lab);
            this.Controls.Add(this.btt);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(124, 110);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btt;
        private System.Windows.Forms.Label lab;
    }
}
