using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magazines
{
	public class ComboItem
	{
		public String Text = null;
		public int Value = 0;

		public ComboItem(String text, int value)
		{
			this.Text = text;
			this.Value = value;
		}

		public override String ToString()
		{
			return Text;
		}

	}
}
