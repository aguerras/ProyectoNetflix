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
        public Pila watchLater = new Pila();
        public Cola myList = new Cola();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    Movie movie = getMovieActual();
                    lbl_category.Text = movie.Category;
                    lbl_title.Text = movie.Name;
                    lbl_description.Text = movie.Description;
                    img_movie.ImageUrl = "../" + movie.Picture;
                }
                catch (Exception)
                {

                }
            }
        }

        protected Movie getMovieActual()
        {
            String name = Request.QueryString["name"];
            try
            {
                movies = (LinkedListDouble)Session["movies"];
                watchLater = (Pila)Session["watchLater"];
                myList = (Cola)Session["myList"];
            }
            catch (Exception)
            {

            }
            if (name.Length > 0)
            {
                try
                {
                    movies.iniciarPrimero();
                    while (movies.getActual() != null)
                    {
                        Movie movie;
                        movie = (Movie)movies.getActual();

                        String movieName = movie.Name;
                        if (movieName == name)
                        {
                            return movie;
                        }
                        movies.next();
                    }
                }
                catch (Exception)
                {

                }
            }
            
            return null;
        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            Movie movie = getMovieActual();
            if (movie != null)
            {
                myList.push(movies.getActual());
            }
        }
    }
}