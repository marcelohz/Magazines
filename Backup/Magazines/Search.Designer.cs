namespace Magazines
{
    partial class Search
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
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.uxKeywords = new System.Windows.Forms.TextBox();
			this.uxCategory = new System.Windows.Forms.ComboBox();
			this.uxAuthor = new System.Windows.Forms.ComboBox();
			this.uxArticle = new System.Windows.Forms.TextBox();
			this.uxDelete = new System.Windows.Forms.Button();
			this.uxReset = new System.Windows.Forms.Button();
			this.uxResults = new System.Windows.Forms.ListView();
			this.colEdition = new System.Windows.Forms.ColumnHeader();
			this.colAuthor = new System.Windows.Forms.ColumnHeader();
			this.colCategory = new System.Windows.Forms.ColumnHeader();
			this.colArticle = new System.Windows.Forms.ColumnHeader();
			this.colPage = new System.Windows.Forms.ColumnHeader();
			this.colKeywords = new System.Windows.Forms.ColumnHeader();
			this.uxSearch = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(4, 114);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 13);
			this.label4.TabIndex = 53;
			this.label4.Text = "Keywords: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 79);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 52;
			this.label3.Text = "Article: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 42);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 51;
			this.label2.Text = "Category: ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 10);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 50;
			this.label1.Text = "Author: ";
			// 
			// uxKeywords
			// 
			this.uxKeywords.Location = new System.Drawing.Point(77, 110);
			this.uxKeywords.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.uxKeywords.Name = "uxKeywords";
			this.uxKeywords.Size = new System.Drawing.Size(147, 21);
			this.uxKeywords.TabIndex = 49;
			// 
			// uxCategory
			// 
			this.uxCategory.FormattingEnabled = true;
			this.uxCategory.Location = new System.Drawing.Point(77, 40);
			this.uxCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.uxCategory.Name = "uxCategory";
			this.uxCategory.Size = new System.Drawing.Size(147, 21);
			this.uxCategory.TabIndex = 47;
			// 
			// uxAuthor
			// 
			this.uxAuthor.FormattingEnabled = true;
			this.uxAuthor.Location = new System.Drawing.Point(77, 6);
			this.uxAuthor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.uxAuthor.Name = "uxAuthor";
			this.uxAuthor.Size = new System.Drawing.Size(147, 21);
			this.uxAuthor.TabIndex = 46;
			// 
			// uxArticle
			// 
			this.uxArticle.Location = new System.Drawing.Point(77, 77);
			this.uxArticle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.uxArticle.Name = "uxArticle";
			this.uxArticle.Size = new System.Drawing.Size(147, 21);
			this.uxArticle.TabIndex = 48;
			// 
			// uxDelete
			// 
			this.uxDelete.Location = new System.Drawing.Point(228, 192);
			this.uxDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.uxDelete.Name = "uxDelete";
			this.uxDelete.Size = new System.Drawing.Size(98, 23);
			this.uxDelete.TabIndex = 44;
			this.uxDelete.Text = "Delete Articles";
			this.uxDelete.UseVisualStyleBackColor = true;
			this.uxDelete.Click += new System.EventHandler(this.uxDelete_Click);
			// 
			// uxReset
			// 
			this.uxReset.Location = new System.Drawing.Point(134, 136);
			this.uxReset.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.uxReset.Name = "uxReset";
			this.uxReset.Size = new System.Drawing.Size(90, 23);
			this.uxReset.TabIndex = 41;
			this.uxReset.Text = "Reset";
			this.uxReset.UseVisualStyleBackColor = true;
			this.uxReset.Click += new System.EventHandler(this.uxReset_Click);
			// 
			// uxResults
			// 
			this.uxResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEdition,
            this.colAuthor,
            this.colCategory,
            this.colArticle,
            this.colPage,
            this.colKeywords});
			this.uxResults.FullRowSelect = true;
			this.uxResults.GridLines = true;
			this.uxResults.HideSelection = false;
			this.uxResults.Location = new System.Drawing.Point(228, 0);
			this.uxResults.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.uxResults.Name = "uxResults";
			this.uxResults.Size = new System.Drawing.Size(433, 186);
			this.uxResults.TabIndex = 42;
			this.uxResults.UseCompatibleStateImageBehavior = false;
			this.uxResults.View = System.Windows.Forms.View.Details;
			this.uxResults.DoubleClick += new System.EventHandler(this.uxResults_DoubleClick_1);
			// 
			// colEdition
			// 
			this.colEdition.Text = "Edition";
			this.colEdition.Width = 68;
			// 
			// colAuthor
			// 
			this.colAuthor.Text = "Author";
			// 
			// colCategory
			// 
			this.colCategory.DisplayIndex = 3;
			this.colCategory.Text = "Category";
			this.colCategory.Width = 85;
			// 
			// colArticle
			// 
			this.colArticle.DisplayIndex = 2;
			this.colArticle.Text = "Article";
			this.colArticle.Width = 75;
			// 
			// colPage
			// 
			this.colPage.Text = "Page";
			this.colPage.Width = 56;
			// 
			// colKeywords
			// 
			this.colKeywords.Text = "Keywords";
			this.colKeywords.Width = 79;
			// 
			// uxSearch
			// 
			this.uxSearch.Location = new System.Drawing.Point(37, 136);
			this.uxSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.uxSearch.Name = "uxSearch";
			this.uxSearch.Size = new System.Drawing.Size(90, 23);
			this.uxSearch.TabIndex = 40;
			this.uxSearch.Text = "Search";
			this.uxSearch.UseVisualStyleBackColor = true;
			this.uxSearch.Click += new System.EventHandler(this.uxSearch_Click);
			// 
			// Search
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.uxKeywords);
			this.Controls.Add(this.uxCategory);
			this.Controls.Add(this.uxAuthor);
			this.Controls.Add(this.uxArticle);
			this.Controls.Add(this.uxDelete);
			this.Controls.Add(this.uxReset);
			this.Controls.Add(this.uxResults);
			this.Controls.Add(this.uxSearch);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.Name = "Search";
			this.Size = new System.Drawing.Size(663, 224);
			this.Load += new System.EventHandler(this.Search_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox uxKeywords;
		private System.Windows.Forms.ComboBox uxCategory;
		private System.Windows.Forms.ComboBox uxAuthor;
		private System.Windows.Forms.TextBox uxArticle;
		private System.Windows.Forms.Button uxDelete;
		private System.Windows.Forms.Button uxReset;
		private System.Windows.Forms.ListView uxResults;
		private System.Windows.Forms.ColumnHeader colEdition;
		private System.Windows.Forms.ColumnHeader colAuthor;
		private System.Windows.Forms.ColumnHeader colCategory;
		private System.Windows.Forms.ColumnHeader colArticle;
		private System.Windows.Forms.ColumnHeader colPage;
		private System.Windows.Forms.ColumnHeader colKeywords;
		private System.Windows.Forms.Button uxSearch;

	}
}