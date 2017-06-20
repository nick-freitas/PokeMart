using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeMart
{
	public partial class SalesGraph : Form
	{
		public SalesGraph()
		{
			InitializeComponent();
			generateGraph();
		}

		private void generateGraph()
		{
			using (PokeMartEntities dbContext = new PokeMartEntities())
			{
				var query = from product in dbContext.SaleProducts
							group product by product.Product1.Name into g
							select new { ProductId = g.Key, TotalUnitsSold = g.Count() };

				chart1.DataSource = query.ToList();

				chart1.Series["Series1"].XValueMember = "ProductId";
				chart1.Series["Series1"].YValueMembers = "TotalUnitsSold";
				chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
				chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

				chart1.Series["Series1"].Name = "Products";

				chart1.DataBind();

				chart1.Show();
			}
		}

		private void chart1_Click(object sender, EventArgs e)
		{

		}
	}
}
