using EstructuraDeDatos;
using Newtonsoft.Json;
using ProyectoNetflix.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoNetflix
{
    public partial class _Default : Page
    {
        public LinkedListDouble movies = new LinkedListDouble();
        public String tvForChildren;
        public String drama;
        public String actionNAdventure;
        public void LoadMovies()
        {
            movies.insertar(new Movie("Coraje el perro cobarde", "Images/Coraje.jpg", "TV para niños"));
            movies.insertar(new Movie("Bob esponja", "Images/bob_esponja.jpg", "TV para niños"));
            movies.insertar(new Movie("Los padrinos mágicos", "Images/padrinos_magicos.png", "TV para niños"));
            movies.insertar(new Movie("Scooby doo", "Images/scooby_doo.jpg", "TV para niños"));
            movies.insertar(new Movie("Tom y Jerry", "Images/tom_and_jerry.jpg", "TV para niños"));
            movies.insertar(new Movie("Billy y Mandy", "Images/billy_y_mandy.jpg", "TV para niños"));
            movies.insertar(new Movie("Toy Story", "Images/toy_story.jpg", "TV para niños"));
            movies.insertar(new Movie("WALL - E", "Images/walle.jpg", "TV para niños"));

            movies.insertar(new Movie("Titanic", "Images/titanic.jpg", "Drama"));
            movies.insertar(new Movie("El padrino", "Images/el_padrino.png", "Drama"));
            movies.insertar(new Movie("Milagros inesperados", "Images/milagros_inesperados.jpg", "Drama"));

            movies.insertar(new Movie("Star Wars", "Images/star_wars.jpg", "Acción y Aventuras"));
            movies.insertar(new Movie("Jurassic Park", "Images/jurassic_park.jpg", "Acción y Aventura"));
            movies.insertar(new Movie("Inidiana Jones", "Images/indiana_jones.jpg", "Acción y Aventura"));
            movies.insertar(new Movie("Piratas del Caribe:  La maldición del Perla Negra", "Images/piratas_del_caribe.jpg", "Acción y Aventura"));
            movies.insertar(new Movie("La momia", "Images/la_momia.jpg", "Acción y Aventura"));
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadMovies();
            Movie movie;
            movies.iniciarPrimero();
            while (movies.getActual() != null)
            {
                movie = (Movie)movies.getActual();
                if (movie.Category == "TV para niños") {
                    String movieName = movie.Name;
                    if (movieName.Length > 32)
                    {
                        movieName = movieName.Substring(0, 33) + "...";
                    }
                    tvForChildren += "<div class='item'><a href=''><img src='" + movie.Picture + "' width='280' height='150' /></a><span title='"+ movie.Name + "'><center><b>"+ movieName + "</b></center></span></div>";
                } else if (movie.Category == "Drama")
                {
                    String movieName = movie.Name;
                    if (movieName.Length > 32)
                    {
                        movieName = movieName.Substring(0, 33) + "...";
                    }
                    drama += "<div class='item'><a href=''><img src='" + movie.Picture + "' width='280' height='150' /></a><span title='" + movie.Name + "'><center><b>" + movieName + "</b></center></span></div>";
                } else if (movie.Category == "Acción y Aventura")
                {
                    String movieName = movie.Name;
                    if (movieName.Length > 32)
                    {
                        movieName = movieName.Substring(0, 33) + "...";
                    }
                    actionNAdventure += "<div class='item'><a href=''><img src='" + movie.Picture + "' width='280' height='150' /></a><span title='" + movie.Name + "'><center><b>" + movieName + "</b></center></span></div>";
                }
                movies.next();
            }
        }
    }
}