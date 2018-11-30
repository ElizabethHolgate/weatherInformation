namespace METOfficeSystem
{
    partial class FrmMain
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
            this.lstLocation = new System.Windows.Forms.ListBox();
            this.lstYear = new System.Windows.Forms.ListBox();
            this.lstMonths = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstLocation
            // 
            this.lstLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLocation.FormattingEnabled = true;
            this.lstLocation.ItemHeight = 25;
            this.lstLocation.Location = new System.Drawing.Point(246, 88);
            this.lstLocation.Name = "lstLocation";
            this.lstLocation.Size = new System.Drawing.Size(191, 429);
            this.lstLocation.TabIndex = 0;
            // 
            // lstYear
            // 
            this.lstYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstYear.FormattingEnabled = true;
            this.lstYear.ItemHeight = 25;
            this.lstYear.Location = new System.Drawing.Point(464, 88);
            this.lstYear.Name = "lstYear";
            this.lstYear.Size = new System.Drawing.Size(303, 429);
            this.lstYear.TabIndex = 1;
            this.lstYear.SelectedIndexChanged += new System.EventHandler(this.lstYear_SelectedIndexChanged);
            // 
            // lstMonths
            // 
            this.lstMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMonths.FormattingEnabled = true;
            this.lstMonths.ItemHeight = 25;
            this.lstMonths.Location = new System.Drawing.Point(790, 88);
            this.lstMonths.Name = "lstMonths";
            this.lstMonths.Size = new System.Drawing.Size(373, 429);
            this.lstMonths.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 554);
            this.Controls.Add(this.lstMonths);
            this.Controls.Add(this.lstYear);
            this.Controls.Add(this.lstLocation);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstLocation;
        private System.Windows.Forms.ListBox lstYear;
        private System.Windows.Forms.ListBox lstMonths;
    }
}

