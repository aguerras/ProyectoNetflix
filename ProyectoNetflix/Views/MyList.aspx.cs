using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EstructuraDeDatos;
using Newtonsoft.Json;
using ProyectoNetflix.Model;

namespace ProyectoNetflix.Views
{
    public partial class MyList : System.Web.UI.Page
    {
        public String peliculas;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Movie movie;
                Cola myList = (Cola)Session["myList"];
                Cola myListMovies = myList.Clone();
                while (myListMovies.getPrimero() != null)
                {
                    movie = (Movie)myListMovies.getPrimero();
                    String movieName = movie.Name;
                    if (movieName.Length > 32)
                    {
                        movieName = movieName.Substring(0, 33) + "...";
                    }
                    peliculas += "<div class='tile'><a href='Title.aspx?name=" + movieName + "&category=" + movie.Category + "&boton=1'><div class='tile__media'><img class='tile__img' src='../" + movie.Picture + "' alt=''  /></div><div class='tile__details'><div class='tile__title'>" + movieName + "</div></div></a></div>";
                    myListMovies.pop();
                }
            }
            catch (Exception)
            {

                
            }
        }
    }
}