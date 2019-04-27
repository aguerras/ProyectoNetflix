<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyList.aspx.cs" Inherits="ProyectoNetflix.Views.MyList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="location" id="home">
        <h1 id="home">Mi Lista</h1>
        <p>Todas las peliculas de mi Lista.</p>

        <div class="left-element" style="top: 240px;">
            <a class="prev">❮</a>
        </div>
        <div class="owl-carousel owl-theme">
            <%= peliculas %>
        </div>
        <div class="right-element" style="top: 240px;">
            <a class="next">❯</a>
        </div>
    </div>
</asp:Content>
