<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Members.aspx.cs" Inherits="ProjectA7.WebForm1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<main>
    <section class="row" aria-labelledby="aspnetTitle">
        <h1 id="aspnetTitle">Member Page</h1>
    </section>
    <div class="row">
        <section class="col-md-4" aria-labelledby="librariesTitle">
            <h3>Friend Retrieval</h3>
            <asp:Label runat="server" Text="Friend Retrieval - Retrieve Friend Data From CSV File - (reads in data about friend, generates dictionary array for later use, and outputs JSON with detailed friend information)" ID="ctl04"></asp:Label>
            <asp:Button runat="server" Text="Generate Friend Data (JSON)" ID="gfbutton" OnClick="friendClick"></asp:Button><br />
            <asp:Label runat="server" ID="friendLabel"></asp:Label><hr />
        </section>
        <section class="col-md-4" aria-labelledby="librariesTitle">

            <h3>Encryption</h3>
            <asp:Label runat="server">Enter item to be encrypted: </asp:Label><hr />
            <asp:TextBox runat="server" ID ="encryptionText"></asp:TextBox>
            <asp:Button runat="server" Text="Encrypt Payload" OnClick="encryptionClick"></asp:Button>
            <asp:Label runat="server" ID="encryptionLabel"></asp:Label>
        </section>
    </div>
</main>
</asp:Content>