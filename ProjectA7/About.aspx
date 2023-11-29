<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="ProjectA7.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<main>

    <!-- REQUIRES CAPTCHA IMPLEMENTATION -->
    <section class="row" aria-labelledby="aspnetTitle">
        <h1 id="aspnetTitle">Member Login</h1>
    </section>
    <div class="row">
        <section class="col-md-4" aria-labelledby="librariesTitle">
            <h2 id="librariesTitle"></h2>
            <p>Username: </p>
                <asp:TextBox runat="server" ID="uname"></asp:TextBox>
            <p>Password: </p>
                <asp:TextBox runat="server" ID="pass"></asp:TextBox>
            <p></p>
            
            <asp:Button runat="server" Text="Login" OnClick="LoginClick"></asp:Button>
            <br />
            <asp:Label runat="server" ID="confirmationText"></asp:Label>
           

        </section>
    </div>


</main>
</asp:Content>
