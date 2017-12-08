using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MENSAGEM_ALERTS
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void modalCliente()
        {
            //lblModalTitle.Text = "Cadastro de Cliente";
            //lblModalBody.Text = "This is modal body";
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
        }

        protected void btnMensagem_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "mensagem", "myFunction()", true);
        }

        protected void btnMensagem_Click1(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "mensagem", "myFunction().myFunction()", true);
        }
    }
}
