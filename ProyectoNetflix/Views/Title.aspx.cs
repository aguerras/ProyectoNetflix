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
        public Boolean isInMyList = false;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String boton = Request.QueryString["boton"];
                try
                {
                    Movie movie = getMovieActual();
                    if (isInMyList)
                    {
                        if (boton == "1")
                        {
                            delete_movie_in_myList(movie);
                        }
                    }
                    lbl_category.Text = movie.Category;
                    lbl_title.Text = movie.Name;
                    lbl_description.Text = movie.Description;
                    img_movie.ImageUrl = "../" + movie.Picture;
                    img_movie_play.ImageUrl = "../" + movie.Picture;

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
                //Colocar si existe en Mi Lista
                try
                {
                    Cola myList2 = myList.Clone();
                    while (myList2.getPrimero() != null)
                    {
                        Movie primero = (Movie)myList2.pop();
                        String currentName = primero.Name;
                        if (name == currentName)
                        {
                            isInMyList = true;
                            break;
                        }
                    }
                }
                catch (Exception)
                {

                }
                // Obtener la pelicula Actual
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
            if (movie != null && !isInMyList)
            {
                if (myList == null)
                {
                    myList = new Cola();
                }
                myList.push(movies.getActual());
                isInMyList = true;
                Session["myList"] = myList;
            }
            else
            {
                delete_movie_in_myList(movie);
            }
        }

        protected void delete_movie_in_myList(Movie movie)
        {
            Cola myList2 = new Cola();
            try
            {
                while (myList.getPrimero() != null)
                {
                    Movie primero = (Movie)myList.pop();
                    String currentName = primero.Name;
                    String movieName = movie.Name;
                    if (movieName != currentName)
                    {
                        myList2.push(primero);
                    }
                }
            }
            catch (Exception)
            {

            }
            isInMyList = false;
            Session["myList"] = myList2;
        }
    }
}