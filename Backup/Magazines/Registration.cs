using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Magazines
{
	public partial class Registration : UserControl
	{
		private DataAccess db = new DataAccess();
		public int articleID = 0;
		/// <summary>
		/// Loads the data corresponding to the article
		/// </summary>
		/// <param name="articleID">ArticleID on the Articles database table</param>
		//public Registration(int articleID)
		//{


		//}

		public void LoadArticle(int articleID)
		{
			this.articleID = articleID;
			InitializeComponent();
			LoadCombosData();
			OleDbDataReader dr = db.CreateDataReader("SELECT * FROM Article WHERE ArticleID = " + articleID.ToString());
			if (!dr.Read()) return;
			uxArticle.Text = dr.GetString(dr.GetOrdinal("Article"));
			uxPage.Text = dr.GetInt32(dr.GetOrdinal("Page")).ToString();
			uxKeywords.Text = dr.GetString(dr.GetOrdinal("Keywords"));
			FindAndSelectItem(uxAuthor, dr.GetInt32(dr.GetOrdinal("AuthorID")));
			FindAndSelectItem(uxCategory, dr.GetInt32(dr.GetOrdinal("CategoryID")));
			FindAndSelectItem(uxEdition, dr.GetInt32(dr.GetOrdinal("MagazineID")));
		}

		public Registration()
		{
			InitializeComponent();
			LoadCombosData();
		}

		/// <summary>
		/// Fills all combos in the form with information retrieved from the database
		/// </summary>
		private void LoadCombosData()
		{
			uxAuthor.Items.Clear();
			uxCategory.Items.Clear();
			uxEdition.Items.Clear();

			OleDbDataReader dr = db.CreateDataReader("SELECT * FROM Author ORDER BY Author");
			while (dr.Read())
				uxAuthor.Items.Add(new ComboItem(dr.GetString(1), dr.GetInt32(0)));

			dr = db.CreateDataReader("SELECT * FROM Category ORDER BY Category");
			while (dr.Read())
				uxCategory.Items.Add(new ComboItem(dr.GetString(1), dr.GetInt32(0)));

			dr = db.CreateDataReader("SELECT * FROM Magazine ORDER BY Year, Month");
			while (dr.Read())
			{
				String MonthYear = dr.GetInt32(dr.GetOrdinal("Year")).ToString() + "/" + dr.GetInt32(dr.GetOrdinal("Month")).ToString("00");
				ComboItem di = new ComboItem(MonthYear, dr.GetInt32(0));
				uxEdition.Items.Add(di);
			}

		}

		private void uxSave_Click(object sender, EventArgs e)
		{
			int authorID, categoryID, magazineID;

			if (!ValidateInput()) return;

			try
			{
				db.BeginTransaction();

				if (!FindAndSelectItem(uxAuthor))
				{
					db.ExecuteNonQuery("INSERT INTO Author (Author) VALUES ('" + uxAuthor.Text.Replace("'", "''") + "')");
					authorID = db.GetIdentity();
				}
				else
					authorID = ((ComboItem)uxAuthor.SelectedItem).Value;

				if (!FindAndSelectItem(uxCategory))
				{
					db.ExecuteNonQuery("INSERT INTO Category (Category) VALUES ('" + uxCategory.Text.Replace("'", "''") + "')");
					categoryID = db.GetIdentity();
				}
				else
					categoryID = ((ComboItem)uxCategory.SelectedItem).Value;

				if (!FindAndSelectItem(uxEdition))
				{
					String Year = uxEdition.Text.Substring(0, uxEdition.Text.IndexOf("/"));
					String Month = uxEdition.Text.Substring(uxEdition.Text.IndexOf("/") + 1, 2);
					db.ExecuteNonQuery("INSERT INTO Magazine ([Month], [Year]) VALUES (" + Month + ", " + Year + ")");
					magazineID = db.GetIdentity();
				}
				else
					magazineID = ((ComboItem)uxEdition.SelectedItem).Value;

				String sql;

				if (articleID == 0)
				{
					sql = "INSERT INTO Article (MagazineID, AuthorID, CategoryID, Article, Page, Keywords) VALUES (";
					sql += magazineID.ToString() + ", ";
					sql += authorID.ToString() + ", ";
					sql += categoryID.ToString() + ", ";
					sql += "'" + uxArticle.Text.Replace("'", "''") + "', ";
					sql += uxPage.Text + ", ";
					sql += "'" + uxKeywords.Text + "'";
					sql += ")";
				}
				else
				{
					sql = "UPDATE Article SET ";
					sql += "Article.MagazineID = " + magazineID.ToString() + ", ";
					sql += "Article.AuthorID = " + authorID.ToString() + ", ";
					sql += "Article.CategoryID = " + categoryID.ToString() + ", ";
					sql += "Article.Article = '" + uxArticle.Text.Replace("'", "''") + "', ";
					sql += "Article.Page = " + uxPage.Text + ", ";
					sql += "Article.Keywords = '" + uxKeywords.Text + "' ";
					sql += "WHERE (((Article.ArticleID)=" + articleID.ToString() + "));";
				}

				db.ExecuteNonQuery(sql);

				db.CommitTransaction();
				
				//add the new ones to the combos
				if (!FindAndSelectItem(uxAuthor))
					uxAuthor.Items.Add(new ComboItem(uxAuthor.Text, authorID));
				if (!FindAndSelectItem(uxCategory))
					uxCategory.Items.Add(new ComboItem(uxCategory.Text, categoryID));
				if (!FindAndSelectItem(uxEdition))
					uxEdition.Items.Add(new ComboItem(uxEdition.Text, magazineID));

				//this.Close();

			}
			catch (Exception ee)
			{
				db.RollbackTransaction();
				MessageBox.Show("Error inserting article: " + ee.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			uxReset_Click(null, null);

		}

		/// <summary>
		/// If there is a match for the typed text in the combo, selects it and returns true.
		/// Otherwise, returns false
		/// </summary>
		/// <param name="combo">ComboBox to search</param>
		/// <returns></returns>
		private bool FindAndSelectItem(ComboBox combo)
		{
			for (int i = 0; i < combo.Items.Count; i++)
				if (combo.Items[i].ToString().ToLower() == combo.Text.ToLower())
				{
					combo.SelectedIndex = i;
					return true;
				}
			return false;
		}

		/// <summary>
		/// If there is a match for itemData in the combo, selects it and returns true.
		/// Otherwise, returns false
		/// </summary>
		/// <param name="combo">ComboBox to search</param>
		/// <param name="itemData">itemData to match</param>
		/// <returns></returns>
		private bool FindAndSelectItem(ComboBox combo, int itemData)
		{
			for (int i = 0; i < combo.Items.Count; i++)
				if (((ComboItem)combo.Items[i]).Value == itemData)
				{
					combo.SelectedIndex = i;
					return true;
				}
			return false;
		}

		private bool ValidateInput()
		{
			if (uxAuthor.Text.Trim() == "")
			{
				MessageBox.Show("Invalid input on 'Author'.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
				uxAuthor.Focus();
				return false;
			}
			if (uxCategory.Text.Trim() == "")
			{
				MessageBox.Show("Invalid input on 'Category'.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
				uxCategory.Focus();
				return false;
			}
			if (uxEdition.Text.Trim() == "" || !Regex.IsMatch(uxEdition.Text, "[1-2][0-9]{3}/[0-9]{2}"))
			{
				MessageBox.Show("Invalid input on 'Edition'.\nInsert a date in format 'yyyy/mm'.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
				uxEdition.Focus();
				return false;
			}

			if (uxArticle.Text.Trim() == "")
			{
				MessageBox.Show("Invalid input on 'Article'.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
				uxArticle.Focus();
				return false;
			}
			int dummy;
			if (uxPage.Text.Trim() == "" || !Int32.TryParse(uxPage.Text, out dummy))
			{
				MessageBox.Show("Invalid input on 'Page'.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
				uxPage.Focus();
				return false;
			}

			return true;
		}

		private void uxReset_Click(object sender, EventArgs e)
		{
			uxAuthor.Text = "";
			uxCategory.Text = "";
			uxAuthor.SelectedIndex = -1;
			uxCategory.SelectedIndex = -1;
			uxArticle.Text = "";
			uxKeywords.Text = "";
			uxPage.Text = "";


		}
	}
}
