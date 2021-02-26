using ASPNETDatabinding2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETDatabinding2
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                BindGrid();
        }

        private List<Product> GetProducts(string criteria)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            if (string.IsNullOrEmpty(criteria))
                return db.Products.ToList();
            else
            {
                return db.Products
                    .Where(p => p.Name.StartsWith(criteria)).ToList();
            }
        }

        private void BindGrid()
        {
            grvProducts.DataSource = GetProducts(txtCriteria.Text);
            grvProducts.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}