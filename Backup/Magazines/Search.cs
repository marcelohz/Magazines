using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Magazines
{
	public partial class Search : UserControl
	{

		private DataAccess db = new DataAccess();
		public Main Mother;

		public Search()
		{
			InitializeComponent();
		}

		private void uxSearch_Click(object sender, EventArgs e)
		{
			OleDbDataReader dr = db.CreateDataReader(BuildQuery());
			ListViewItem lvi;
			uxResults.Items.Clear();
			while (dr.Read())
			{
				string keywords;
				lvi = uxResults.Items.Add(dr.GetInt32(dr.GetOrdinal("Year")).ToString() + "/" + dr.GetInt32(dr.GetOrdinal("Month")).ToString("00"));
				lvi.SubItems.Add(dr.GetString(dr.GetOrdinal("Author")));
				lvi.SubItems.Add(dr.GetString(dr.GetOrdinal("Category")));
				lvi.SubItems.Add(dr.GetString(dr.GetOrdinal("Article")));
				lvi.SubItems.Add(dr.GetInt32(dr.GetOrdinal("Page")).ToString());
				keywords = dr.GetString(dr.GetOrdinal("Keywords"));
				keywords = keywords.Replace(" ", "");
				keywords = keywords.Replace(" ", ",");
				keywords = keywords.Replace(";", ",");
				keywords = keywords.Replace(",", ", ");

				lvi.SubItems.Add(keywords);
				lvi.Tag = dr.GetInt32(dr.GetOrdinal("ArticleID"));
			}
			foreach (ColumnHeader header in uxResults.Columns)
				uxResults.Columns[header.Index].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
		}

		private void LoadCombosData()
		{
			uxAuthor.Items.Clear();
			uxCategory.Items.Clear();
			OleDbDataReader dr = db.CreateDataReader("SELECT * FROM Author ORDER BY Author");
			while (dr.Read())
				uxAuthor.Items.Add(new ComboItem(dr.GetString(1), dr.GetInt32(0)));
			dr = db.CreateDataReader("SELECT * FROM Category ORDER BY Category");
			while (dr.Read())
				uxCategory.Items.Add(new ComboItem(dr.GetString(1), dr.GetInt32(0)));
		}

		private String BuildQuery()
		{
			String sql;
			String where = null;
			Char[] separators = { ',', ' ', ';' };

			sql = "SELECT Magazine.Month, Magazine.Year, Author.Author, Category.Category, Article.Article, Article.Page, Article.Keywords, Article.ArticleID " +
			"FROM Magazine INNER JOIN (Category INNER JOIN (Author INNER JOIN Article ON Author.AuthorID = Article.AuthorID) ON Category.CategoryID = Article.CategoryID) ON Magazine.MagazineID = Article.MagazineID ";

			if (uxAuthor.SelectedIndex > -1)
				where += "((Author.Author)=\"" + uxAuthor.Text + "\") ";

			if (uxCategory.SelectedIndex > -1)
			{
				if (where != null) where += "AND ";
				where += "((Category.Category)=\"" + uxCategory.Text + "\") ";
			}
			if (uxArticle.Text.Trim() != "")
			{
				if (where != null) where += "AND ";
				where += "(Article.Article LIKE\"%" + uxArticle.Text + "%\") ";
			}

			if (uxKeywords.Text.Trim() != "")
			{
				String keywords = null;
				foreach (String keyword in uxKeywords.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries))
				{
					if (keywords != null) keywords += "OR ";
					keywords += "(Article.Keywords) LIKE \"%" + keyword + "%\" ";
				}
				if (where != null) where += "AND ";
				where += "(" + keywords + ")";
			}

			if (where != null)
				sql += "WHERE " + where;

			return (sql);
		}

		private void Search_Load(object sender, EventArgs e)
		{
			LoadCombosData();
		}


		private void uxReset_Click(object sender, EventArgs e)
		{
			uxResults.Items.Clear();
			uxArticle.Text = "";
			uxAuthor.Text = "";
			uxCategory.Text = "";
			uxAuthor.SelectedIndex = -1;
			uxCategory.SelectedIndex = -1;
			uxKeywords.Text = "";
			LoadCombosData();
		}

		private void uxResults_DoubleClick(object sender, EventArgs e)
		{
			//TODO: REGISTRATION
			//Registration reg = new Registration((Int32)uxResults.SelectedItems[0].Tag);
			//reg.ShowDialog();
			//uxSearch_Click(null, null);
		}

		private void Search_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Alt && e.Control && (e.KeyCode == Keys.F12))
			{
				if (MessageBox.Show(
						"Are you sure you want to erase all data?" + Environment.NewLine +
						"This operation can NOT be undone.",
						"You pressed the secret combination!",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question,
						MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				db.ExecuteNonQuery("DELETE FROM Article");
				db.ExecuteNonQuery("DELETE FROM Author");
				db.ExecuteNonQuery("DELETE FROM Magazine");
				db.ExecuteNonQuery("DELETE FROM Category");

				MessageBox.Show("Your database has been wiped.",
						Application.ProductName,
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);
			}
		}

		private void uxDelete_Click(object sender, EventArgs e)
		{
			if (uxResults.SelectedItems.Count == 0) return;

			if (MessageBox.Show(
					"Are you sure you want to delete " + uxResults.SelectedItems.Count + " article(s)?",
					"Confirm article delete",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				return;
			for (int i = 0; i < uxResults.SelectedItems.Count; i++)
				db.ExecuteNonQuery("DELETE FROM Article WHERE ArticleID = " + ((Int32)uxResults.SelectedItems[i].Tag).ToString());
			uxSearch_Click(null, null);
		}

		private void uxResults_DoubleClick_1(object sender, EventArgs e)
		{
			EditReg edit = new EditReg((Int32)uxResults.SelectedItems[0].Tag);
			edit.ShowDialog();
			uxSearch_Click(null, null);
		}

	}

}
