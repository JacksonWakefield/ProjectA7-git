<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProjectA6._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Login Page</h1>
            <p class="lead">This is the login page. <br /> This page is not yet build for account creation. 
                <br /> FOR TESTING - <br /> We have three sample usernames/passwords registered to our site. 
                <br /> The usernames are: 
                    <br /> jackson, martha, billy 
                <br /> And our passwords are: 
                    <br /> myPassword, myPassword2, myPassword3 
                <br /> There is only one working combination for each of the usernames/passwords (they are hashed, so you cannot see them raw in our file storage)
                <br /> To test, try the combinations of these usernames/passwords until one works.
      
            </p>
        </section>

        <div class="row">
            <section class="col-md-3" aria-labelledby="gettingStartedTitle">
                <h2 id="gettingStartedTitle">Login: </h2>
            </section>
            <section class="col-md-4" aria-labelledby="librariesTitle">
                <h2 id="librariesTitle"></h2>
                <p>Username: </p>
                    <asp:TextBox runat="server" ID="uname"></asp:TextBox>
                <p>Password: </p>
                    <asp:TextBox runat="server" ID="pass"></asp:TextBox>
                <p></p>
                
                <asp:Button runat="server" Text="Login" OnClick="Unnamed4_Click"></asp:Button>

                <p><asp:Label runat="server" Text="Login Verification Will Display Here" ID="loginVerifier"></asp:Label><br /></p>
                <p>I will additionally place whatever is entered into the "password" field here hashed WITHOUT salt (so will not match to our internal file's password) as proof that the hashing is taking place: </p>
                <p><asp:Label runat="server" Text="Hashed Password Will Display Here" ID="HashedPassDisplay"></asp:Label></p>

            </section>
        </div>
    </main>

</asp:Content>
