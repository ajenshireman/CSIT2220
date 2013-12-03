<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="packages">
        <h1>Adventure Packages</h1>
        <ul>
            <li class="package" data-packageID="">
                <h2 class="package-name">Package Name</h2>
                <div class="details">
                    <div class="desription">Package description</div>
                    <div class="price" data-price="">Price: $000 per person</div>
                    <button class="btn btn-inline btn-extras">Extras</button>
                    <button class="btn btn-inline btn-book">Book Now!</button>
                    <ul class="extras">
                        <li><span class="price" data-price="">Extra 1 Name: $000 per person</span></li>
                        <li><span class="price perDay" data-price="">Extra 2 Name: $000 per person per day</span></li>
                    </ul>
                </div>
            </li>
        </ul>
    </div>
</asp:Content>
