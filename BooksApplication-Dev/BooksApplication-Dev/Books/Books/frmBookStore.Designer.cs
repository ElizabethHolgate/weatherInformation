namespace Books
{
    partial class frmMainBookstore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainBookstore));
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbAdminFeatures = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnEditLibrary = new System.Windows.Forms.Button();
            this.btnAddLibrary = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnStockReport = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstLibs = new System.Windows.Forms.ListBox();
            this.gpbAdminFeatures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBooks
            // 
            this.lstBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 20;
            this.lstBooks.Location = new System.Drawing.Point(309, 413);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(746, 204);
            this.lstBooks.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Books  in stock TODAY";
            // 
            // gpbAdminFeatures
            // 
            this.gpbAdminFeatures.Controls.Add(this.btnExit);
            this.gpbAdminFeatures.Controls.Add(this.btnEditBook);
            this.gpbAdminFeatures.Controls.Add(this.btnEditLibrary);
            this.gpbAdminFeatures.Controls.Add(this.btnAddLibrary);
            this.gpbAdminFeatures.Controls.Add(this.btnAddBook);
            this.gpbAdminFeatures.Controls.Add(this.btnStockReport);
            this.gpbAdminFeatures.Location = new System.Drawing.Point(30, 273);
            this.gpbAdminFeatures.Name = "gpbAdminFeatures";
            this.gpbAdminFeatures.Size = new System.Drawing.Size(237, 344);
            this.gpbAdminFeatures.TabIndex = 2;
            this.gpbAdminFeatures.TabStop = false;
            this.gpbAdminFeatures.Text = "Admin Features";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(42, 295);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(156, 34);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBook.Location = new System.Drawing.Point(42, 232);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(156, 34);
            this.btnEditBook.TabIndex = 4;
            this.btnEditBook.Text = "Edit Book";
            this.btnEditBook.UseVisualStyleBackColor = true;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnEditLibrary
            // 
            this.btnEditLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditLibrary.Location = new System.Drawing.Point(42, 128);
            this.btnEditLibrary.Name = "btnEditLibrary";
            this.btnEditLibrary.Size = new System.Drawing.Size(156, 34);
            this.btnEditLibrary.TabIndex = 4;
            this.btnEditLibrary.Text = "Edit Library";
            this.btnEditLibrary.UseVisualStyleBackColor = true;
            this.btnEditLibrary.Click += new System.EventHandler(this.btnEditLibrary_Click);
            // 
            // btnAddLibrary
            // 
            this.btnAddLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLibrary.Location = new System.Drawing.Point(42, 88);
            this.btnAddLibrary.Name = "btnAddLibrary";
            this.btnAddLibrary.Size = new System.Drawing.Size(156, 34);
            this.btnAddLibrary.TabIndex = 2;
            this.btnAddLibrary.Text = "Add Library";
            this.btnAddLibrary.UseVisualStyleBackColor = true;
            this.btnAddLibrary.Click += new System.EventHandler(this.btnAddLibrary_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.Location = new System.Drawing.Point(42, 192);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(156, 34);
            this.btnAddBook.TabIndex = 1;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnStockReport
            // 
            this.btnStockReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockReport.Location = new System.Drawing.Point(42, 24);
            this.btnStockReport.Name = "btnStockReport";
            this.btnStockReport.Size = new System.Drawing.Size(156, 34);
            this.btnStockReport.TabIndex = 0;
            this.btnStockReport.Text = "Run Stock Report";
            this.btnStockReport.UseVisualStyleBackColor = true;
            this.btnStockReport.Click += new System.EventHandler(this.btnStockReport_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1435, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lstLibs
            // 
            this.lstLibs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLibs.FormattingEnabled = true;
            this.lstLibs.ItemHeight = 20;
            this.lstLibs.Location = new System.Drawing.Point(309, 287);
            this.lstLibs.Name = "lstLibs";
            this.lstLibs.Size = new System.Drawing.Size(746, 104);
            this.lstLibs.TabIndex = 4;
            this.lstLibs.SelectedIndexChanged += new System.EventHandler(this.lstLibs_SelectedIndexChanged);
            // 
            // frmMainBookstore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 647);
            this.Controls.Add(this.lstLibs);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpbAdminFeatures);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBooks);
            this.Name = "frmMainBookstore";
            this.Text = "Bookstore";
            this.Load += new System.EventHandler(this.frmMainBookstore_Load);
            this.gpbAdminFeatures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbAdminFeatures;
        private System.Windows.Forms.Button btnStockReport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnEditLibrary;
        private System.Windows.Forms.Button btnAddLibrary;
        private System.Windows.Forms.ListBox lstLibs;
    }
}

