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

        <h1 id="home">Continuar Viendo</h1>
        <div class="left-element" style="top: 800px;">
            <a class="prev">❮</a>
        </div>
        <div class="owl-carousel owl-theme">
            <%= strWatchLater %>
        </div>
        <div class="right-element" style="top: 800px;">
            <a class="next">❯</a>
        </div>

        <h1 id="home">Mi Lista</h1>
        <div class="left-element" style="top: 800px;">
            <a class="prev">❮</a>
        </div>
        <div class="owl-carousel owl-theme">
            <%= strMyList %>
        </div>
        <div class="right-element" style="top: 800px;">
            <a class="next">❯</a>
        </div>
    </div>
</asp:Content>
