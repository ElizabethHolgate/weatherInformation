namespace Books
{
    partial class FrmAddLibrary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddLibrary));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpNewLibrary = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLibPostcode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLibCounty = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLibCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLibStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLibStNum = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNumTitles = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLibraryName = new System.Windows.Forms.TextBox();
            this.lblNumTitles = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLibraryName = new System.Windows.Forms.Label();
            this.btnSaveLibrary = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.btnReturnMainFrm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpNewLibrary.SuspendLayout();
            this.grpAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1435, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grpNewLibrary
            // 
            this.grpNewLibrary.Controls.Add(this.label10);
            this.grpNewLibrary.Controls.Add(this.label3);
            this.grpNewLibrary.Controls.Add(this.grpAddress);
            this.grpNewLibrary.Controls.Add(this.txtNumTitles);
            this.grpNewLibrary.Controls.Add(this.label2);
            this.grpNewLibrary.Controls.Add(this.txtEmail);
            this.grpNewLibrary.Controls.Add(this.label1);
            this.grpNewLibrary.Controls.Add(this.txtLibraryName);
            this.grpNewLibrary.Controls.Add(this.lblNumTitles);
            this.grpNewLibrary.Controls.Add(this.lblEmail);
            this.grpNewLibrary.Controls.Add(this.lblLibraryName);
            this.grpNewLibrary.Location = new System.Drawing.Point(33, 316);
            this.grpNewLibrary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNewLibrary.Name = "grpNewLibrary";
            this.grpNewLibrary.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNewLibrary.Size = new System.Drawing.Size(1836, 475);
            this.grpNewLibrary.TabIndex = 1;
            this.grpNewLibrary.TabStop = false;
            this.grpNewLibrary.Text = "Please enter new library details";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1679, 434);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "* required field";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 42);
            this.label3.TabIndex = 16;
            this.label3.Text = "*";
            // 
            // grpAddress
            // 
            this.grpAddress.Controls.Add(this.label9);
            this.grpAddress.Controls.Add(this.txtLibPostcode);
            this.grpAddress.Controls.Add(this.label8);
            this.grpAddress.Controls.Add(this.label7);
            this.grpAddress.Controls.Add(this.txtLibCounty);
            this.grpAddress.Controls.Add(this.lblCounty);
            this.grpAddress.Controls.Add(this.label6);
            this.grpAddress.Controls.Add(this.txtLibCity);
            this.grpAddress.Controls.Add(this.lblCity);
            this.grpAddress.Controls.Add(this.label5);
            this.grpAddress.Controls.Add(this.txtLibStreet);
            this.grpAddress.Controls.Add(this.lblStreet);
            this.grpAddress.Controls.Add(this.label4);
            this.grpAddress.Controls.Add(this.txtLibStNum);
            this.grpAddress.Controls.Add(this.lblNumber);
            this.grpAddress.Location = new System.Drawing.Point(49, 201);
            this.grpAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAddress.Size = new System.Drawing.Size(956, 256);
            this.grpAddress.TabIndex = 15;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(428, 202);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 42);
            this.label9.TabIndex = 29;
            this.label9.Text = "*";
            // 
            // txtLibPostcode
            // 
            this.txtLibPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibPostcode.Location = new System.Drawing.Point(212, 194);
            this.txtLibPostcode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLibPostcode.Name = "txtLibPostcode";
            this.txtLibPostcode.Size = new System.Drawing.Size(207, 30);
            this.txtLibPostcode.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(85, 202);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "Postcode:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(644, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 42);
            this.label7.TabIndex = 26;
            this.label7.Text = "*";
            // 
            // txtLibCounty
            // 
            this.txtLibCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibCounty.Location = new System.Drawing.Point(212, 150);
            this.txtLibCounty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLibCounty.Name = "txtLibCounty";
            this.txtLibCounty.Size = new System.Drawing.Size(423, 30);
            this.txtLibCounty.TabIndex = 25;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(111, 158);
            this.lblCounty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(88, 25);
            this.lblCounty.TabIndex = 24;
            this.lblCounty.Text = "County:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(759, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 42);
            this.label6.TabIndex = 23;
            this.label6.Text = "*";
            // 
            // txtLibCity
            // 
            this.txtLibCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibCity.Location = new System.Drawing.Point(212, 103);
            this.txtLibCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLibCity.Name = "txtLibCity";
            this.txtLibCity.Size = new System.Drawing.Size(537, 30);
            this.txtLibCity.TabIndex = 22;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(145, 111);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(57, 25);
            this.lblCity.TabIndex = 21;
            this.lblCity.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(880, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 42);
            this.label5.TabIndex = 20;
            this.label5.Text = "*";
            // 
            // txtLibStreet
            // 
            this.txtLibStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibStreet.Location = new System.Drawing.Point(212, 58);
            this.txtLibStreet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLibStreet.Name = "txtLibStreet";
            this.txtLibStreet.Size = new System.Drawing.Size(659, 30);
            this.txtLibStreet.TabIndex = 19;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(119, 65);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(77, 25);
            this.lblStreet.TabIndex = 18;
            this.lblStreet.Text = "Street:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(385, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 42);
            this.label4.TabIndex = 17;
            this.label4.Text = "*";
            // 
            // txtLibStNum
            // 
            this.txtLibStNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibStNum.Location = new System.Drawing.Point(212, 16);
            this.txtLibStNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLibStNum.Name = "txtLibStNum";
            this.txtLibStNum.Size = new System.Drawing.Size(164, 30);
            this.txtLibStNum.TabIndex = 17;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(103, 20);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(94, 25);
            this.lblNumber.TabIndex = 4;
            this.lblNumber.Text = "Number:";
            // 
            // txtNumTitles
            // 
            this.txtNumTitles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTitles.Location = new System.Drawing.Point(261, 127);
            this.txtNumTitles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumTitles.Name = "txtNumTitles";
            this.txtNumTitles.Size = new System.Drawing.Size(135, 30);
            this.txtNumTitles.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1191, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 42);
            this.label2.TabIndex = 13;
            this.label2.Text = "*";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(261, 82);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(920, 30);
            this.txtEmail.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1361, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "*";
            // 
            // txtLibraryName
            // 
            this.txtLibraryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibraryName.Location = new System.Drawing.Point(261, 37);
            this.txtLibraryName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLibraryName.Name = "txtLibraryName";
            this.txtLibraryName.Size = new System.Drawing.Size(1091, 30);
            this.txtLibraryName.TabIndex = 6;
            // 
            // lblNumTitles
            // 
            this.lblNumTitles.AutoSize = true;
            this.lblNumTitles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTitles.Location = new System.Drawing.Point(60, 134);
            this.lblNumTitles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumTitles.Name = "lblNumTitles";
            this.lblNumTitles.Size = new System.Drawing.Size(177, 25);
            this.lblNumTitles.TabIndex = 3;
            this.lblNumTitles.Text = "Number of Titles:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(176, 90);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 25);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblLibraryName
            // 
            this.lblLibraryName.AutoSize = true;
            this.lblLibraryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibraryName.Location = new System.Drawing.Point(95, 44);
            this.lblLibraryName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLibraryName.Name = "lblLibraryName";
            this.lblLibraryName.Size = new System.Drawing.Size(147, 25);
            this.lblLibraryName.TabIndex = 1;
            this.lblLibraryName.Text = "Library Name:";
            // 
            // btnSaveLibrary
            // 
            this.btnSaveLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveLibrary.Location = new System.Drawing.Point(295, 818);
            this.btnSaveLibrary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveLibrary.Name = "btnSaveLibrary";
            this.btnSaveLibrary.Size = new System.Drawing.Size(208, 42);
            this.btnSaveLibrary.TabIndex = 3;
            this.btnSaveLibrary.Text = "Save Library";
            this.btnSaveLibrary.UseVisualStyleBackColor = true;
            this.btnSaveLibrary.Click += new System.EventHandler(this.btnSaveLibrary_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.Location = new System.Drawing.Point(553, 818);
            this.btnResetForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(208, 42);
            this.btnResetForm.TabIndex = 4;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // btnReturnMainFrm
            // 
            this.btnReturnMainFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMainFrm.Location = new System.Drawing.Point(957, 818);
            this.btnReturnMainFrm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReturnMainFrm.Name = "btnReturnMainFrm";
            this.btnReturnMainFrm.Size = new System.Drawing.Size(208, 42);
            this.btnReturnMainFrm.TabIndex = 5;
            this.btnReturnMainFrm.Text = "Cancel";
            this.btnReturnMainFrm.UseVisualStyleBackColor = true;
            this.btnReturnMainFrm.Click += new System.EventHandler(this.btnReturnMainFrm_Click);
            // 
            // FrmAddLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 875);
            this.Controls.Add(this.btnReturnMainFrm);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnSaveLibrary);
            this.Controls.Add(this.grpNewLibrary);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAddLibrary";
            this.Text = "Add New Library";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpNewLibrary.ResumeLayout(false);
            this.grpNewLibrary.PerformLayout();
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpNewLibrary;
        private System.Windows.Forms.Label lblLibraryName;
        private System.Windows.Forms.Label lblNumTitles;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtLibraryName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumTitles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLibPostcode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLibCounty;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLibCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLibStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLibStNum;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSaveLibrary;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Button btnReturnMainFrm;
    }
}