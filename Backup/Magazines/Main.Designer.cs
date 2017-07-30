namespace Magazines
{
	partial class Main
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
			this.uxTabs = new System.Windows.Forms.TabControl();
			this.uxTabSearch = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.uxTabRegistration = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.uxTabManagement = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.uxSearch = new Magazines.Search();
			this.uxRegistration = new Magazines.Registration();
			this.uxManagement = new Magazines.Management();
			this.uxTabs.SuspendLayout();
			this.uxTabSearch.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.uxTabRegistration.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.uxTabManagement.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// uxTabs
			// 
			this.uxTabs.Controls.Add(this.uxTabSearch);
			this.uxTabs.Controls.Add(this.uxTabRegistration);
			this.uxTabs.Controls.Add(this.uxTabManagement);
			this.uxTabs.Location = new System.Drawing.Point(-2, 1);
			this.uxTabs.Name = "uxTabs";
			this.uxTabs.SelectedIndex = 0;
			this.uxTabs.Size = new System.Drawing.Size(688, 267);
			this.uxTabs.TabIndex = 0;
			// 
			// uxTabSearch
			// 
			this.uxTabSearch.Controls.Add(this.groupBox1);
			this.uxTabSearch.Location = new System.Drawing.Point(4, 22);
			this.uxTabSearch.Name = "uxTabSearch";
			this.uxTabSearch.Padding = new System.Windows.Forms.Padding(3);
			this.uxTabSearch.Size = new System.Drawing.Size(680, 241);
			this.uxTabSearch.TabIndex = 0;
			this.uxTabSearch.Text = "Search";
			this.uxTabSearch.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.uxSearch);
			this.groupBox1.Location = new System.Drawing.Point(3, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(674, 237);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// uxTabRegistration
			// 
			this.uxTabRegistration.Controls.Add(this.groupBox2);
			this.uxTabRegistration.Location = new System.Drawing.Point(4, 22);
			this.uxTabRegistration.Name = "uxTabRegistration";
			this.uxTabRegistration.Padding = new System.Windows.Forms.Padding(3);
			this.uxTabRegistration.Size = new System.Drawing.Size(680, 241);
			this.uxTabRegistration.TabIndex = 1;
			this.uxTabRegistration.Text = "Registration";
			this.uxTabRegistration.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.uxRegistration);
			this.groupBox2.Location = new System.Drawing.Point(3, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(417, 191);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			// 
			// uxTabManagement
			// 
			this.uxTabManagement.Controls.Add(this.groupBox3);
			this.uxTabManagement.Location = new System.Drawing.Point(4, 22);
			this.uxTabManagement.Name = "uxTabManagement";
			this.uxTabManagement.Size = new System.Drawing.Size(680, 241);
			this.uxTabManagement.TabIndex = 2;
			this.uxTabManagement.Text = "Management";
			this.uxTabManagement.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.uxManagement);
			this.groupBox3.Location = new System.Drawing.Point(3, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(560, 231);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			// 
			// uxSearch
			// 
			this.uxSearch.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.uxSearch.Location = new System.Drawing.Point(5, 14);
			this.uxSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.uxSearch.Name = "uxSearch";
			this.uxSearch.Size = new System.Drawing.Size(664, 218);
			this.uxSearch.TabIndex = 1;
			// 
			// uxRegistration
			// 
			this.uxRegistration.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.uxRegistration.Location = new System.Drawing.Point(17, 20);
			this.uxRegistration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.uxRegistration.Name = "uxRegistration";
			this.uxRegistration.Size = new System.Drawing.Size(388, 167);
			this.uxRegistration.TabIndex = 1;
			// 
			// uxManagement
			// 
			this.uxManagement.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.uxManagement.Location = new System.Drawing.Point(6, 13);
			this.uxManagement.Name = "uxManagement";
			this.uxManagement.Size = new System.Drawing.Size(546, 215);
			this.uxManagement.TabIndex = 1;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(679, 263);
			this.Controls.Add(this.uxTabs);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "Main";
			this.Text = "Magazines";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
			this.uxTabs.ResumeLayout(false);
			this.uxTabSearch.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.uxTabRegistration.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.uxTabManagement.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl uxTabs;
		private System.Windows.Forms.TabPage uxTabRegistration;
		private System.Windows.Forms.TabPage uxTabManagement;
		private System.Windows.Forms.TabPage uxTabSearch;
		private System.Windows.Forms.GroupBox groupBox1;
		private Search uxSearch;
		private System.Windows.Forms.GroupBox groupBox2;
		private Registration uxRegistration;
		private System.Windows.Forms.GroupBox groupBox3;
		private Management uxManagement;

	}
}