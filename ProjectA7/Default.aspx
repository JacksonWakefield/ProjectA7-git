﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProjectA7._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Team 86 - FINAL PROJECT A6/A7</h1>
            <p class="lead">Group Members: Jackson Wakefield, Siddhartha Yalamanchili</p>
        </section>

        <div class="row">
            <section class="col-md-6" aria-labelledby="gettingStartedTitle">
                <h2 id="gettingStartedTitle">Members</h2>
                <p>
                    Click below to access login page. If already logged in, this button will redirect you to the Try-It page directory.
                </p>
                <p>
                    <a class="btn btn-default" href="http://webstrar86.fulton.asu.edu/page1/about"><u>Login</u> &raquo;</a>
                </p>
            </section>
            <section class="col-md-6" aria-labelledby="librariesTitle">
                <h2 id="librariesTitle">Staff</h2>
                <p>
                    Click below to access the Staff login page. If already logged in, this button will redirect you to the Staff homepage.
                </p>
                <p>
                    <a class="btn btn-default" href="http://webstrar86.fulton.asu.edu/page1/contact"><u>Staff Login</u> &raquo;</a>
                </p>
            </section>
        </div>
    </main>

</asp:Content>
