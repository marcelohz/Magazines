using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace Magazines
{
	public partial class Management : UserControl
	{

		private DataAccess db = new DataAccess();

		public Management()
		{
			InitializeComponent();
		}


		private void LoadData()
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
				String MonthYear = dr.GetInt32(dr.GetOrdinal("Month")).ToString("00") + "/" + dr.GetInt32(dr.GetOrdinal("Year")).ToString();
				ComboItem di = new ComboItem(MonthYear, dr.GetInt32(0));
				uxEdition.Items.Add(di);
			}

		}

		private void Management_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void uxDeleteAuthor_Click(object sender, EventArgs e)
		{
			foreach (ComboItem item in uxAuthor.SelectedItems)
			{
				try
				{
					db.ExecuteNonQuery("DELETE FROM Author WHERE AuthorID = " + item.Value);
				}
				catch (Exception ex)
				{
					MessageBox.Show("'" + item.Text + "' wasn't deleted due to the following error: " + Environment.NewLine +
							ex.Message, "Error deleting",
							MessageBoxButtons.OK,
							MessageBoxIcon.Exclamation);
				}
			}
			LoadData();
		}

		private void uxDeleteCategory_Click(object sender, EventArgs e)
		{
			foreach (ComboItem item in uxCategory.SelectedItems)
			{
				try
				{
					db.ExecuteNonQuery("DELETE FROM Category WHERE CategoryID = " + item.Value);
				}
				catch (Exception ex)
				{
					MessageBox.Show("'" + item.Text + "' wasn't deleted due to the following error: " + Environment.NewLine +
							ex.Message, "Error deleting",
							MessageBoxButtons.OK,
							MessageBoxIcon.Exclamation);
				}
			}
			LoadData();
		}

		private void uxDeleteEdition_Click(object sender, EventArgs e)
		{
			foreach (ComboItem item in uxEdition.SelectedItems)
			{
				try
				{
					db.ExecuteNonQuery("DELETE FROM magazine WHERE MagazineID = " + item.Value);
				}
				catch (Exception ex)
				{
					MessageBox.Show("'" + item.Text + "' wasn't deleted due to the following error: " + Environment.NewLine +
							ex.Message, "Error deleting",
							MessageBoxButtons.OK,
							MessageBoxIcon.Exclamation);
				}
			}

			LoadData();
		}

		private void uxAddAuthor_Click(object sender, EventArgs e)
		{
			if (uxNewAuthor.Text.Trim() == "") return;
			db.ExecuteNonQuery("INSERT INTO Author (Author) VALUES ('" + uxNewAuthor.Text + "')");
			uxNewAuthor.Text = "";
			LoadData();
		}

		private void uxAddCategory_Click(object sender, EventArgs e)
		{
			if (uxNewCategory.Text.Trim() == "") return;
			db.ExecuteNonQuery("INSERT INTO Category (Category) VALUES ('" + uxNewCategory.Text + "')");
			uxNewCategory.Text = "";
			LoadData();
		}

		private void uxAddEdition_Click(object sender, EventArgs e)
		{
			if (uxNewEdition.Text.Trim() == "") return;
			if (uxNewEdition.Text.Trim() == "" || !Regex.IsMatch(uxNewEdition.Text, "[0-9]{2}/[1-2][0-9]{3}"))
			{
				MessageBox.Show("Invalid input.\nInsert a date in format 'mm/yyyy'.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
				uxNewEdition.Focus();
				return;
			}

			String Month = uxNewEdition.Text.Substring(0, uxNewEdition.Text.IndexOf("/"));
			String Year = uxNewEdition.Text.Substring(uxNewEdition.Text.IndexOf("/") + 1, 4);
			db.ExecuteNonQuery("INSERT INTO Magazine ([Month], [Year]) VALUES (" + Month + ", " + Year + ")");
			uxNewEdition.Text = "";
			LoadData();
		}

	}
}
