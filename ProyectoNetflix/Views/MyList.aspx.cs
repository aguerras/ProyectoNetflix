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
                    peliculas += "<div class='item'><a href='Title.aspx?name=" + movieName + "&category=" + movie.Category + "&boton=0'><img src='../" + movie.Picture + "' width='280' height='150' /></a><span title='" + movie.Name + "'><center><b>" + movieName + "</b></center></span></div>";
                    myListMovies.pop();
                }
            }
            catch (Exception)
            {

                
            }
        }
    }
}