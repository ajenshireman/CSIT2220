<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div id="packages">
        <h1>Adventure Packages</h1>
        <ul>
            <li class="package">
                <h2>Package Name</h2>
                <div class="desription">Package description</div>
                <div class="price">Price: $000 per person</div>
                <button class="btn btn-extras">Extras</button>
                <ul class="extras">
                    <li><span class="price">Extra 1 Name: $000 per person</span></li>
                    <li><span class="price"><span class="perDay">Extra 2 Name: $000 per person per day</span></span></li>
                </ul>
            </li>
            <li class="package">
                <h2>Package Name</h2>
                <div class="desription">Package description</div>
                <div class="price">Price: $000 per person</div>
                <button class="btn btn-extras">Extras</button>
                <ul class="extras">
                    <li><span class="price">Extra 1 Name: $000 per person</span></li>
                    <li><span class="price"><span class="perDay">Extra 2 Name: $000 per person per day</span></span></li>
                </ul>
            </li>
            <li class="package">
                <h2>Package Name</h2>
                <div class="desription">Package description</div>
                <div class="price">Price: $000 per person</div>
                <button class="btn btn-extras">Extras</button>
                <ul class="extras">
                    <li><span class="price">Extra 1 Name: $000 per person</span></li>
                    <li><span class="price"><span class="perDay">Extra 2 Name: $000 per person per day</span></span></li>
                </ul>
            </li>
            <li class="package">
                <h2>Package Name</h2>
                <div class="desription">Package description</div>
                <div class="price">Price: $000 per person</div>
                <button class="btn btn-extras">Extras</button>
                <ul class="extras">
                    <li><span class="price">Extra 1 Name: $000 per person</span></li>
                    <li><span class="price"><span class="perDay">Extra 2 Name: $000 per person per day</span></span></li>
                </ul>
            </li>
        </ul>
    </div>
</asp:Content>
