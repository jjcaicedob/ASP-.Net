using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCalcular_Click(object sender, EventArgs e)
    {
        double b = 0;
        double h = 0;
        double a = 0;

        b = double.Parse(txtBase.Text);
        h = double.Parse(txtAltura.Text);

        a = (b * h) / 2;

        lblArea.Text = a.ToString();
    }

    protected void btnLimpiar_Click(object sender, EventArgs e)
    {
        txtBase.Text = "";
        txtAltura.Text = "";
        lblArea.Text = "";
    }

}