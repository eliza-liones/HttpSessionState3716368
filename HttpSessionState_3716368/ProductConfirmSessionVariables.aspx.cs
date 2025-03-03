using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HttpSessionState_3716368
{
	public partial class ProductConfirmSessionVariables : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            // Recupera las variables de sesión.
            ddlCategory.SelectedValue = Session["ddlCategory"].ToString();
            ddlSupplier.SelectedValue = Session["ddlSupplier"].ToString();
            lblProduct.Text = Session["strProduct"].ToString();
            txtDescription.Text = Session["strDescription"].ToString();
            lblImage.Text = Session["strImage"].ToString();

            // Convierte el precio a decimal y lo muestra con formato de moneda.
            decimal decPrice = Convert.ToDecimal(Session["decPrice"]);
            lblPrice.Text = decPrice.ToString("c");

            // Muestra los valores numéricos.
            lblNumberInStock.Text = Session["bytNumberInStock"].ToString();
            lblNumberOnOrder.Text = Session["bytNumberOnOrder"].ToString();
            lblReorderLevel.Text = Session["bytReorderLevel"].ToString();

            // Calcula y muestra el valor en stock y el valor en orden.
            byte bytNumberInStock = Convert.ToByte(Session["bytNumberInStock"]);
            byte bytNumberOnOrder = Convert.ToByte(Session["bytNumberOnOrder"]);
            decimal decValueInStock = decPrice * bytNumberInStock;
            decimal decValueOnOrder = decPrice * bytNumberOnOrder;
            lblValueInStock.Text = decValueInStock.ToString("c");
            lblValueOnOrder.Text = decValueOnOrder.ToString("c");
        }
	}
}