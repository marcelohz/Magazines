namespace Magazines
{
	partial class Management
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
			this.uxDeleteAuthor = new System.Windows.Forms.Button();
			this.uxDeleteCategory = new System.Windows.Forms.Button();
			this.uxAuthor = new System.Windows.Forms.ListBox();
			this.uxCategory = new System.Windows.Forms.ListBox();
			this.uxAddAuthor = new System.Windows.Forms.Button();
			this.uxAddCategory = new System.Windows.Forms.Button();
			this.uxNewAuthor = new System.Windows.Forms.TextBox();
			this.uxNewCategory = new System.Windows.Forms.TextBox();
			this.uxNewEdition = new System.Windows.Forms.TextBox();
			this.uxAddEdition = new System.Windows.Forms.Button();
			this.uxEdition = new System.Windows.Forms.ListBox();
			this.uxDeleteEdition = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// uxDeleteAuthor
			// 
			this.uxDeleteAuthor.Location = new System.Drawing.Point(36, 156);
			this.uxDeleteAuthor.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.uxDeleteAuthor.Name = "uxDeleteAuthor";
			this.uxDeleteAuthor.Size = new System.Drawing.Size(87, 23);
			this.uxDeleteAuthor.TabIndex = 4;
			this.uxDeleteAuthor.Text = "Delete";
			this.uxDeleteAuthor.UseVisualStyleBackColor = true;
			this.uxDeleteAuthor.Click += new System.EventHandler(this.uxDeleteAuthor_Click);
			// 
			// uxDeleteCategory
			// 
			this.uxDeleteCategory.Location = new System.Drawing.Point(223, 156);
			this.uxDeleteCategory.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.uxDeleteCategory.Name = "uxDeleteCategory";
			this.uxDeleteCategory.Size = new System.Drawing.Size(87, 23);
			this.uxDeleteCategory.TabIndex = 5;
			this.uxDeleteCategory.Text = "Delete";
			this.uxDeleteCategory.UseVisualStyleBackColor = true;
			this.uxDeleteCategory.Click += new System.EventHandler(this.uxDeleteCategory_Click);
			// 
			// uxAuthor
			// 
			this.uxAuthor.FormattingEnabled = true;
			this.uxAuthor.Location = new System.Drawing.Point(1, 3);
			this.uxAuthor.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.uxAuthor.Name = "uxAuthor";
			this.uxAuthor.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.uxAuthor.Size = new System.Drawing.Size(163, 147);
			this.uxAuthor.TabIndex = 6;
			// 
			// uxCategory
			// 
			this.uxCategory.FormattingEnabled = true;
			this.uxCategory.Location = new System.Drawing.Point(188, 3);
			this.uxCategory.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.uxCategory.Name = "uxCategory";
			this.uxCategory.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.uxCategory.Size = new System.Drawing.Size(163, 147);
			this.uxCategory.TabIndex = 7;
			// 
			// uxAddAuthor
			// 
			this.uxAddAuthor.Location = new System.Drawing.Point(2, 186);
			this.uxAddAuthor.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.uxAddAuthor.Name = "uxAddAuthor";
			this.uxAddAuthor.Size = new System.Drawing.Size(40, 23);
			this.uxAddAuthor.TabIndex = 8;
			this.uxAddAuthor.Text = "Add";
			this.uxAddAuthor.UseVisualStyleBackColor = true;
			this.uxAddAuthor.Click += new System.EventHandler(this.uxAddAuthor_Click);
			// 
			// uxAddCategory
			// 
			this.uxAddCategory.Location = new System.Drawing.Point(189, 186);
			this.uxAddCategory.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.uxAddCategory.Name = "uxAddCategory";
			this.uxAddCategory.Size = new System.Drawing.Size(40, 23);
			this.uxAddCategory.TabIndex = 9;
			this.uxAddCategory.Text = "Add";
			this.uxAddCategory.UseVisualStyleBackColor = true;
			this.uxAddCategory.Click += new System.EventHandler(this.uxAddCategory_Click);
			// 
			// uxNewAuthor
			// 
			this.uxNewAuthor.Location = new System.Drawing.Point(49, 189);
			this.uxNewAuthor.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.uxNewAuthor.Name = "uxNewAuthor";
			this.uxNewAuthor.Size = new System.Drawing.Size(116, 21);
			this.uxNewAuthor.TabIndex = 10;
			// 
			// uxNewCategory
			// 
			this.uxNewCategory.Location = new System.Drawing.Point(235, 189);
			this.uxNewCategory.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.uxNewCategory.Name = "uxNewCategory";
			this.uxNewCategory.Size = new System.Drawing.Size(116, 21);
			this.uxNewCategory.TabIndex = 11;
			// 
			// uxNewEdition
			// 
			this.uxNewEdition.Location = new System.Drawing.Point(428, 189);
			this.uxNewEdition.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.uxNewEdition.Name = "uxNewEdition";
			this.uxNewEdition.Size = new System.Drawing.Size(116, 21);
			this.uxNewEdition.TabIndex = 15;
			// 
			// uxAddEdition
			// 
			this.uxAddEdition.Location = new System.Drawing.Point(381, 186);
			this.uxAddEdition.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.uxAddEdition.Name = "uxAddEdition";
			this.uxAddEdition.Size = new System.Drawing.Size(40, 23);
			this.uxAddEdition.TabIndex = 14;
			this.uxAddEdition.Text = "Add";
			this.uxAddEdition.UseVisualStyleBackColor = true;
			this.uxAddEdition.Click += new System.EventHandler(this.uxAddEdition_Click);
			// 
			// uxEdition
			// 
			this.uxEdition.FormattingEnabled = true;
			this.uxEdition.Location = new System.Drawing.Point(380, 3);
			this.uxEdition.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.uxEdition.Name = "uxEdition";
			this.uxEdition.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.uxEdition.Size = new System.Drawing.Size(163, 147);
			this.uxEdition.TabIndex = 13;
			// 
			// uxDeleteEdition
			// 
			this.uxDeleteEdition.Location = new System.Drawing.Point(413, 156);
			this.uxDeleteEdition.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.uxDeleteEdition.Name = "uxDeleteEdition";
			this.uxDeleteEdition.Size = new System.Drawing.Size(87, 23);
			this.uxDeleteEdition.TabIndex = 12;
			this.uxDeleteEdition.Text = "Delete";
			this.uxDeleteEdition.UseVisualStyleBackColor = true;
			this.uxDeleteEdition.Click += new System.EventHandler(this.uxDeleteEdition_Click);
			// 
			// Management
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.uxNewEdition);
			this.Controls.Add(this.uxAddEdition);
			this.Controls.Add(this.uxEdition);
			this.Controls.Add(this.uxDeleteEdition);
			this.Controls.Add(this.uxNewCategory);
			this.Controls.Add(this.uxNewAuthor);
			this.Controls.Add(this.uxAddCategory);
			this.Controls.Add(this.uxAddAuthor);
			this.Controls.Add(this.uxCategory);
			this.Controls.Add(this.uxAuthor);
			this.Controls.Add(this.uxDeleteCategory);
			this.Controls.Add(this.uxDeleteAuthor);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Management";
			this.Size = new System.Drawing.Size(546, 215);
			this.Load += new System.EventHandler(this.Management_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button uxDeleteAuthor;
		private System.Windows.Forms.Button uxDeleteCategory;
		private System.Windows.Forms.ListBox uxAuthor;
		private System.Windows.Forms.ListBox uxCategory;
		private System.Windows.Forms.Button uxAddAuthor;
		private System.Windows.Forms.Button uxAddCategory;
		private System.Windows.Forms.TextBox uxNewAuthor;
		private System.Windows.Forms.TextBox uxNewCategory;
		private System.Windows.Forms.TextBox uxNewEdition;
		private System.Windows.Forms.Button uxAddEdition;
		private System.Windows.Forms.ListBox uxEdition;
		private System.Windows.Forms.Button uxDeleteEdition;
	}
}