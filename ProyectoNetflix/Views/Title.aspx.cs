using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EstructuraDeDatos;
using ProyectoNetflix.Model;

namespace ProyectoNetflix.Views
{
    public partial class Title : System.Web.UI.Page
    {
        public LinkedListDouble movies = new LinkedListDouble();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    String name = Request.QueryString["name"];

                    if (name.Length > 0)
                    {
                        movies = (LinkedListDouble)Session["movies"];
                        movies.iniciarPrimero();
                        while (movies.getActual() != null)
                        {
                            Movie movie;
                            movie = (Movie)movies.getActual();
                            lbl_category.Text = movie.Category;
                            lbl_title.Text = movie.Name;
                            lbl_description.Text = movie.Description;
                            img_movie.ImageUrl = "../" + movie.Picture;
                            String movieName = movie.Name;
                            if (movieName == name)
                            {
                                return;
                            }
                            movies.next();
                        }
                    }
                }
                catch (Exception)
                {

                    //throw;
                }
            }
        }
    }
}