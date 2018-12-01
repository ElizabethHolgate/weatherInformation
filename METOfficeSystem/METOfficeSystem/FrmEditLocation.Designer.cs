namespace METOfficeSystem
{
    partial class FrmEditLocation
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtLocationName = new System.Windows.Forms.TextBox();
            this.txtStreetNameNum = new System.Windows.Forms.TextBox();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.lblStrtNameNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(704, 393);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 31);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtLocationName
            // 
            this.txtLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationName.Location = new System.Drawing.Point(263, 63);
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.Size = new System.Drawing.Size(284, 30);
            this.txtLocationName.TabIndex = 1;
            // 
            // txtStreetNameNum
            // 
            this.txtStreetNameNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreetNameNum.Location = new System.Drawing.Point(263, 112);
            this.txtStreetNameNum.Name = "txtStreetNameNum";
            this.txtStreetNameNum.Size = new System.Drawing.Size(543, 30);
            this.txtStreetNameNum.TabIndex = 2;
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationName.Location = new System.Drawing.Point(108, 63);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(149, 25);
            this.lblLocationName.TabIndex = 3;
            this.lblLocationName.Text = "Location Name:";
            // 
            // lblStrtNameNum
            // 
            this.lblStrtNameNum.AutoSize = true;
            this.lblStrtNameNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrtNameNum.Location = new System.Drawing.Point(18, 112);
            this.lblStrtNameNum.Name = "lblStrtNameNum";
            this.lblStrtNameNum.Size = new System.Drawing.Size(239, 25);
            this.lblStrtNameNum.TabIndex = 4;
            this.lblStrtNameNum.Text = "Street Number and Name:";
            // 
            // FrmEditLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.lblStrtNameNum);
            this.Controls.Add(this.lblLocationName);
            this.Controls.Add(this.txtStreetNameNum);
            this.Controls.Add(this.txtLocationName);
            this.Controls.Add(this.btnCancel);
            this.Name = "FrmEditLocation";
            this.Text = "FrmEditLocation";
            this.Load += new System.EventHandler(this.FrmEditLocation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtLocationName;
        private System.Windows.Forms.TextBox txtStreetNameNum;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.Label lblStrtNameNum;
    }
}