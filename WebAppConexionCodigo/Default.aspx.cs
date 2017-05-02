using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection objCnn = CrearConexion();

        ConsultarDatos(objCnn);
    }

    private SqlConnection CrearConexion()
    {
        SqlConnection objCnn = new SqlConnection();

        try
        {
            string cs = ConfigurationManager.ConnectionStrings["bdNorthwindSQlServer"].ToString();
            objCnn = new SqlConnection(cs);

            objCnn.Open();


            lblMensaje.Text = "Conexión realizada con éxito!";
        }
        catch (Exception error)
        {
            lblMensaje.Text = "Error: " + error.Message;
        }

        return objCnn;
    }

    private void ConsultarDatos(SqlConnection objcnn)
    {
        try
        {
            SqlCommand objCmd = new SqlCommand("Select * from Region", objcnn);
            GridView1.DataSource = objCmd.ExecuteReader();
            GridView1.DataBind();

            lblMensaje.Text = "Consulta realizada con éxito!";
        }
        catch (Exception error)
        {
            lblMensaje.Text = "Error: " + error.Message;
        }
    }
}