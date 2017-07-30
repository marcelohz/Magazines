namespace Magazines
{
    partial class Registration
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
			this.uxAuthor = new System.Windows.Forms.ComboBox();
			this.uxCategory = new System.Windows.Forms.ComboBox();
			this.uxEdition = new System.Windows.Forms.ComboBox();
			this.uxSave = new System.Windows.Forms.Button();
			this.uxReset = new System.Windows.Forms.Button();
			this.uxKeywords = new System.Windows.Forms.TextBox();
			this.uxArticle = new System.Windows.Forms.TextBox();
			this.uxPage = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// uxAuthor
			// 
			this.uxAuthor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.uxAuthor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.uxAuthor.FormattingEnabled = true;
			this.uxAuthor.Location = new System.Drawing.Point(90, 81);
			this.uxAuthor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.uxAuthor.Name = "uxAuthor";
			this.uxAuthor.Size = new System.Drawing.Size(294, 21);
			this.uxAuthor.TabIndex = 4;
			this.uxAuthor.Tag = "";
			// 
			// uxCategory
			// 
			this.uxCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.uxCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.uxCategory.FormattingEnabled = true;
			this.uxCategory.Location = new System.Drawing.Point(90, 54);
			this.uxCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.uxCategory.Name = "uxCategory";
			this.uxCategory.Size = new System.Drawing.Size(294, 21);
			this.uxCategory.TabIndex = 3;
			this.uxCategory.Tag = "";
			// 
			// uxEdition
			// 
			this.uxEdition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.uxEdition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.uxEdition.FormattingEnabled = true;
			this.uxEdition.Location = new System.Drawing.Point(90, 1);
			this.uxEdition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.uxEdition.Name = "uxEdition";
			this.uxEdition.Size = new System.Drawing.Size(182, 21);
			this.uxEdition.TabIndex = 0;
			this.uxEdition.Tag = "";
			// 
			// uxSave
			// 
			this.uxSave.Location = new System.Drawing.Point(191, 138);
			this.uxSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.uxSave.Name = "uxSave";
			this.uxSave.Size = new System.Drawing.Size(92, 25);
			this.uxSave.TabIndex = 6;
			this.uxSave.Text = "Save";
			this.uxSave.UseVisualStyleBackColor = true;
			this.uxSave.Click += new System.EventHandler(this.uxSave_Click);
			// 
			// uxReset
			// 
			this.uxReset.Location = new System.Drawing.Point(292, 138);
			this.uxReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.uxReset.Name = "uxReset";
			this.uxReset.Size = new System.Drawing.Size(92, 25);
			this.uxReset.TabIndex = 7;
			this.uxReset.Text = "Reset";
			this.uxReset.UseVisualStyleBackColor = true;
			this.uxReset.Click += new System.EventHandler(this.uxReset_Click);
			// 
			// uxKeywords
			// 
			this.uxKeywords.Location = new System.Drawing.Point(90, 108);
			this.uxKeywords.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.uxKeywords.Name = "uxKeywords";
			this.uxKeywords.Size = new System.Drawing.Size(294, 21);
			this.uxKeywords.TabIndex = 5;
			this.uxKeywords.Tag = "";
			// 
			// uxArticle
			// 
			this.uxArticle.Location = new System.Drawing.Point(90, 28);
			this.uxArticle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.uxArticle.Name = "uxArticle";
			this.uxArticle.Size = new System.Drawing.Size(294, 21);
			this.uxArticle.TabIndex = 2;
			this.uxArticle.Tag = "";
			// 
			// uxPage
			// 
			this.uxPage.Location = new System.Drawing.Point(345, 1);
			this.uxPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.uxPage.Name = "uxPage";
			this.uxPage.Size = new System.Drawing.Size(40, 21);
			this.uxPage.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 5);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Edition:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(4, 31);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Article Name:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(4, 57);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Category:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(4, 83);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Author:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(4, 109);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Keywords:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(289, 4);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "Page:";
			// 
			// Registration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.uxPage);
			this.Controls.Add(this.uxArticle);
			this.Controls.Add(this.uxKeywords);
			this.Controls.Add(this.uxReset);
			this.Controls.Add(this.uxSave);
			this.Controls.Add(this.uxEdition);
			this.Controls.Add(this.uxCategory);
			this.Controls.Add(this.uxAuthor);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "Registration";
			this.Size = new System.Drawing.Size(388, 166);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.ComboBox uxAuthor;
		private System.Windows.Forms.ComboBox uxCategory;
		private System.Windows.Forms.ComboBox uxEdition;
		private System.Windows.Forms.Button uxSave;
		private System.Windows.Forms.Button uxReset;
		private System.Windows.Forms.TextBox uxKeywords;
		private System.Windows.Forms.TextBox uxArticle;
		private System.Windows.Forms.TextBox uxPage;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;

	}
}

