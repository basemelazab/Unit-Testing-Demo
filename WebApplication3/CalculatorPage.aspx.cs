using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class CalculatorPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Divide(object sender, EventArgs e)
        {
            int numerator = Convert.ToInt32(txtNumerator.Text);
            int demonirator = Convert.ToInt32(txtDemonirator.Text);
            int result = Calculator.Library.Calculator.Divide(numerator, demonirator);

            lblResult.Text = result.ToString();
        }
    }
}