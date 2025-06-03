using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NortWind_11
{
    public partial class WebNort : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        // Declare Objeto 
        private  NorthwindEntities Data = new NorthwindEntities();

        protected void btnConsulta1_Click(object sender, EventArgs e)
        {
            var productosCaros = from p in Data.Products
                                 where p.UnitPrice > 50
                                 select p;

            gvConsulta.DataSource = productosCaros.ToList();
            gvConsulta.DataBind();
        }

        protected void btnConsulta2_Click(object sender, EventArgs e)
        {
            var pedidos1997 = from o in Data.Orders
                              where o.OrderDate.Value.Year == 1997
                              select o;

            gvConsulta.DataSource = pedidos1997.ToList();
            gvConsulta.DataBind();
        }

        protected void btnConsulta3_Click(object sender, EventArgs e)
        {
            var representantesVentas = from E in Data.Employees
                                       where E.Title == "Sales Representative"
                                       select E;

            gvConsulta.DataSource = representantesVentas.ToList();
            gvConsulta.DataBind();
        }

        protected void btnConsulta4_Click(object sender, EventArgs e)
        {
            var nombresPrecios = from p in Data.Products
                                 select new
                                 {
                                     NombreProducto = p.ProductName,
                                     Precio = p.UnitPrice
                                 };

            gvConsulta.DataSource = nombresPrecios.ToList();
            gvConsulta.DataBind();
        }

        protected void btnConsulta5_Click(object sender, EventArgs e)
        {
            var clientesPaises = from c in Data.Customers
                                 select new
                                 {
                                     Cliente = c.ContactName,
                                     País = c.Country
                                 };

            gvConsulta.DataSource = clientesPaises.ToList();
            gvConsulta.DataBind();
        }

        protected void btnConsulta6_Click(object sender, EventArgs e)
        {
            var categorias = from c in Data.Categories
                             select new
                             {
                                 ID = c.CategoryID,
                                 Nombre = c.CategoryName
                             };

            gvConsulta.DataSource = categorias.ToList();
            gvConsulta.DataBind();
        }

        protected void btnConsulta7_Click(object sender, EventArgs e)
        {
            var productosRenombrados = from p in Data.Products
                                       select new
                                       {
                                           Código = p.ProductID,
                                           Nombre = p.ProductName,
                                           PrecioUnitario = p.UnitPrice,
                                           EnStock = p.UnitsInStock
                                       };

            gvConsulta.DataSource = productosRenombrados.ToList();
            gvConsulta.DataBind();
        }

        protected void btnConsulta8_Click(object sender, EventArgs e)
        {
            var empleadosRenombrados = from E in Data.Employees
                                       select new
                                       {
                                           ID = E.EmployeeID,
                                           NombreCompleto = E.FirstName + " " + E.LastName,
                                           Cargo = E.Title,
                                           FechaContratación = E.HireDate
                                       };

            gvConsulta.DataSource = empleadosRenombrados.ToList();
            gvConsulta.DataBind();
        }

        protected void btnConsulta9_Click(object sender, EventArgs e)
        {
            var pedidosRenombrados = from o in Data.Orders
                                     join c in Data.Customers on o.CustomerID equals c.CustomerID
                                     select new
                                     {
                                         NúmeroPedido = o.OrderID,
                                         Cliente = c.ContactName,
                                         FechaPedido = o.OrderDate,
                                         CiudadDestino = o.ShipCity
                                     };

            gvConsulta.DataSource = pedidosRenombrados.ToList();
            gvConsulta.DataBind();
        }
    }
}