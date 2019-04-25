<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Title.aspx.cs" Inherits="ProyectoNetflix.Views.Title" %>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="video-page">
        <div class="video-page-header">
            <div class="video-description">
                <div class="header-left">
                    <asp:Image id="img_movie" runat="server" ImageUrl="Images/default.jpg"/>
                    <div class="my-list">
                        <asp:Button id="btn_add" Text="Mi lista" runat="server" OnClick="btn_add_Click" />
                    </div>
                </div>
                <div class="header-right">
                    <h1><asp:Label id="lbl_title" Text="" runat="server" /></h1>
                    <asp:Label id="lbl_description" Text="" runat="server" />
                    <div class='info'>
                        <h4>Categoria:</h4>
                        <h5>
                            <asp:Label id="lbl_category" Text="" runat="server" />
                        </h5>
                    </div>
                </div>
            </div>
        </div>
        <div class="streaming-container">
            <img src="http://4.bp.blogspot.com/-Xx_xBL54Pas/TtkId59pLuI/AAAAAAAAIUc/T7v0-EqgEd0/s1600/bigfish5.jpg"/>
            <div class="streaming-play">
                <i class="fas fa-play"></i>
            </div>
        </div>
    </div>
</asp:Content>
