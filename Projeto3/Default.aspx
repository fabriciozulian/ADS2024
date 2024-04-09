<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Projeto3.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <!-- REFERENCIA: http://flexslider.woothemes.com/index.html -->
  <div class="flexslider">
    <ul class="slides">
      <li>
        <img src="Images/banner0.png" />
      </li>
      <li>
        <img src="Images/banner1.png" />
      </li>
      <li>
        <img src="Images/banner2.png" />
      </li>
      <li>
        <img src="Images/banner3.png" />
      </li>
    </ul>
  </div>
  <script>
    // Can also be used with $(document).ready()
    $(window).load(function () {
      $('.flexslider').flexslider({
        animation: "slide"
      });
    });
  </script>


  <div class="row min-height-300px margin-top-120 margin-bottom-120">
    <!-- COLUNA 1 -->
    <div class="col-3">
      <div class="box border margin-right-20">
        <img width="100%" src="Images/si1.png" />
        <br />
        <h2>Analise de Sistemas</h2>
        <br />
        <p>
          Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla elementum, sem in vehicula elementum, turpis nunc placerat diam, eget molestie ipsum erat in leo. Suspendisse euismod, tellus id cursus lobortis, mauris mi volutpat lacus, id volutpat nulla lorem at felis. 
        </p>
      </div>
    </div>
    <!-- COLUNA 2 -->
    <div class="col-3">
      <div class="box border margin-right-20">
        CONTEUDO 
      </div>
    </div>
    <!-- COLUNA 3 -->
    <div class="col-3">
      <div class="box border margin-right-20">
        CONTEUDO 
      </div>
    </div>
    <!-- COLUNA 4 -->
    <div class="col-3">
      <div class="box border">
        CONTEUDO 
      </div>
    </div>
  </div>
</asp:Content>
