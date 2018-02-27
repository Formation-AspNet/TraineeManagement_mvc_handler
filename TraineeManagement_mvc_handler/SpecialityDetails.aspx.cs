using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TraineeManagement_mvc_handler
{
    public partial class SpecialityDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Read from routage 
            var speciality = Page.RouteData.Values["speciality"];

            if(speciality != null)
            {
                this.speciality.Text = speciality.ToString();
            }

        }
    }
}