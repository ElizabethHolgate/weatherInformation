namespace Books
{
    partial class FrmEditBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditBook));
            this.btnCancelAddBook = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSaveBookEdit = new System.Windows.Forms.Button();
            this.grpNewBookDetails = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtNumCopies = new System.Windows.Forms.TextBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblNumCopies = new System.Windows.Forms.Label();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpNewBookDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelAddBook
            // 
            this.btnCancelAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddBook.Location = new System.Drawing.Point(657, 592);
            this.btnCancelAddBook.Name = "btnCancelAddBook";
            this.btnCancelAddBook.Size = new System.Drawing.Size(106, 28);
            this.btnCancelAddBook.TabIndex = 9;
            this.btnCancelAddBook.Text = "Cancel";
            this.btnCancelAddBook.UseVisualStyleBackColor = true;
            this.btnCancelAddBook.Click += new System.EventHandler(this.btnCancelAddBook_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(433, 592);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 28);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSaveBookEdit
            // 
            this.btnSaveBookEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBookEdit.Location = new System.Drawing.Point(261, 592);
            this.btnSaveBookEdit.Name = "btnSaveBookEdit";
            this.btnSaveBookEdit.Size = new System.Drawing.Size(151, 28);
            this.btnSaveBookEdit.TabIndex = 7;
            this.btnSaveBookEdit.Text = "Save Edited Book";
            this.btnSaveBookEdit.UseVisualStyleBackColor = true;
            this.btnSaveBookEdit.Click += new System.EventHandler(this.btnSaveBookEdit_Click);
            // 
            // grpNewBookDetails
            // 
            this.grpNewBookDetails.Controls.Add(this.label6);
            this.grpNewBookDetails.Controls.Add(this.label5);
            this.grpNewBookDetails.Controls.Add(this.label4);
            this.grpNewBookDetails.Controls.Add(this.label3);
            this.grpNewBookDetails.Controls.Add(this.label2);
            this.grpNewBookDetails.Controls.Add(this.label1);
            this.grpNewBookDetails.Controls.Add(this.txtYear);
            this.grpNewBookDetails.Controls.Add(this.txtNumCopies);
            this.grpNewBookDetails.Controls.Add(this.txtIsbn);
            this.grpNewBookDetails.Controls.Add(this.txtTitle);
            this.grpNewBookDetails.Controls.Add(this.txtAuthor);
            this.grpNewBookDetails.Controls.Add(this.lblPrice);
            this.grpNewBookDetails.Controls.Add(this.lblNumCopies);
            this.grpNewBookDetails.Controls.Add(this.lblIsbn);
            this.grpNewBookDetails.Controls.Add(this.lblBookTitle);
            this.grpNewBookDetails.Controls.Add(this.lblAuthorName);
            this.grpNewBookDetails.Location = new System.Drawing.Point(32, 254);
            this.grpNewBookDetails.Name = "grpNewBookDetails";
            this.grpNewBookDetails.Size = new System.Drawing.Size(1366, 306);
            this.grpNewBookDetails.TabIndex = 6;
            this.grpNewBookDetails.TabStop = false;
            this.grpNewBookDetails.Text = "Please enter new book details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1259, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "* required field";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(335, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 33);
            this.label5.TabIndex = 14;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(303, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 33);
            this.label3.TabIndex = 12;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1169, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(619, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "*";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(229, 210);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 26);
            this.txtYear.TabIndex = 9;
            // 
            // txtNumCopies
            // 
            this.txtNumCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCopies.Location = new System.Drawing.Point(229, 168);
            this.txtNumCopies.Name = "txtNumCopies";
            this.txtNumCopies.Size = new System.Drawing.Size(72, 26);
            this.txtNumCopies.TabIndex = 8;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsbn.Location = new System.Drawing.Point(229, 127);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(214, 26);
            this.txtIsbn.TabIndex = 7;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(229, 85);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(934, 26);
            this.txtTitle.TabIndex = 6;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(229, 47);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(372, 26);
            this.txtAuthor.TabIndex = 5;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(167, 216);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(52, 20);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Year:";
            // 
            // lblNumCopies
            // 
            this.lblNumCopies.AutoSize = true;
            this.lblNumCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCopies.Location = new System.Drawing.Point(66, 174);
            this.lblNumCopies.Name = "lblNumCopies";
            this.lblNumCopies.Size = new System.Drawing.Size(157, 20);
            this.lblNumCopies.TabIndex = 3;
            this.lblNumCopies.Text = "Number of Copies:";
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsbn.Location = new System.Drawing.Point(167, 133);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(56, 20);
            this.lblIsbn.TabIndex = 2;
            this.lblIsbn.Text = "ISBN:";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.Location = new System.Drawing.Point(129, 91);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(94, 20);
            this.lblBookTitle.TabIndex = 1;
            this.lblBookTitle.Text = "Book Title:";
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorName.Location = new System.Drawing.Point(104, 50);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(119, 20);
            this.lblAuthorName.TabIndex = 0;
            this.lblAuthorName.Text = "Author Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1435, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FrmEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 635);
            this.Controls.Add(this.btnCancelAddBook);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSaveBookEdit);
            this.Controls.Add(this.grpNewBookDetails);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmEditBook";
            this.Text = "FrmEditBook";
            this.Load += new System.EventHandler(this.FrmEditBook_Load);
            this.grpNewBookDetails.ResumeLayout(false);
            this.grpNewBookDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelAddBook;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSaveBookEdit;
        private System.Windows.Forms.GroupBox grpNewBookDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtNumCopies;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblNumCopies;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}