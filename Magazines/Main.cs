using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Magazines
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
			uxSearch.Mother = this;
		}

		public void LoadArticle(int articleID)
		{
			uxRegistration.LoadArticle(articleID);
			uxRegistration.articleID = articleID;
			uxTabs.SelectedTab = uxTabs.TabPages[1];
		}

		private void Main_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Alt == true && e.Control == true && e.KeyCode == Keys.F12)
			{
				DataAccess da = new DataAccess();
				if (MessageBox.Show("Wish to erase all the data?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
				da.ExecuteNonQuery("delete * from Article");
				da.ExecuteNonQuery("delete * from Author");
				da.ExecuteNonQuery("delete * from Category");
				da.ExecuteNonQuery("delete * from Magazine");

				MessageBox.Show("Database has been wiped.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

		}

	}
}
