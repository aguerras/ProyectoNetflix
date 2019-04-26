<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyList.aspx.cs" Inherits="ProyectoNetflix.Views.MyList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="contain">
        <h1>MI LISTA</h1>
        <p>Todas las peliculas de mi Lista.</p>
        <div class="row">
            <div class="row__inner">

                <%= peliculas %>
                <div class="tile">
                    <div class="tile__media">
                        <img class="tile__img" src="https://s3-us-west-2.amazonaws.com/s.cdpn.io/70390/show-1.jpg" alt=""  />
                    </div>
                    <div class="tile__details">
                        <div class="tile__title">
                            Top Gear
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
