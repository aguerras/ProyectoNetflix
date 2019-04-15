<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProyectoNetflix._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="location" id="home">
        <h1 id="home">TV para niños</h1>
        <div class="left-element" style="top: 240px;">
            <a class="prev">❮</a>
        </div>
        <div class="owl-carousel owl-theme">
            <%= tvForChildren %>
        </div>
        <div class="right-element" style="top: 240px;">
            <a class="next">❯</a>
        </div>

        <h1 id="home">Drama</h1>
        <div class="left-element" style="top: 520px;">
            <a class="prev">❮</a>
        </div>
        <div class="owl-carousel owl-theme">
            <%= drama %>
        </div>
        <div class="right-element" style="top: 520px;">
            <a class="next">❯</a>
        </div>

        <h1 id="home">Acción y Aventuras</h1>
        <div class="left-element" style="top: 800px;">
            <a class="prev">❮</a>
        </div>
        <div class="owl-carousel owl-theme">
            <%= actionNAdventure %>
        </div>
        <div class="right-element" style="top: 800px;">
            <a class="next">❯</a>
        </div>
    </div>

    <style>
        .prev, .next {
            cursor: pointer;
            position: absolute;
            top: 50%;
            width: auto;
            padding: 16px;
            margin-top: -22px;
            color: white;
            font-weight: bold;
            font-size: 28px;
            transition: 0.6s ease;
            border-radius: 0 3px 3px 0;
        }
        .next {
            right: 0;
            border-radius: 3px 0 0 3px;
        }
        .prev:hover, .next:hover {
            background-color: rgba(0,0,0,0.8);
        }
        .left-element {
            display: inline-block;
            position: absolute;
            left: 0;
	        z-index:100;
        }
        .right-element {
            display: inline-block;
            position: absolute;
            right: 0px;
	        z-index:100;
        }

        .owl-item img {
            width: 280px !important;
            margin: 0 auto;
        }
    </style>

    <script>
/*
Cola
Mi lista
*Ver pelicula hacer que elimina dicha pelicula de la cola

Pila
Continuar viendo contenido de "Usuario"

Ver película
*Cuando termine de ver una, se debe salir automáticamente y entrar al index.


-Agregar
-Eliminar
-Búsqueda*/

        $(document).ready(function () {
            var owl = $(".owl-carousel");
            owl.owlCarousel({
                loop: false,
                margin: 10,
                nav: false,
                dots: false,
                autoWidth: true,
                autoHeight: true
            });

            function next_slide() {
                owl.trigger('next.owl');
                owl.trigger('next.owl');
            }
		    function prev_slide(){
		        owl.trigger('prev.owl'); 
		        owl.trigger('prev.owl'); 
            }

            document.getElementsByClassName("next")[0].addEventListener("click", next_slide, false);
		    document.getElementsByClassName("prev")[0].addEventListener("click", prev_slide, false);
        });
    </script>
</asp:Content>
