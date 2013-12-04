<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="packages">
        <h1>Adventure Packages</h1>
        <ul>
            <li class="package" data-packageID="1">
                <h2 class="package-name">Devil’s Courthouse Adventure Weekend</h2>
                <div class="details">
                    <div class="desription">An action packed three days weekend spent camping, rock climbing, and rappelling at Devil’s Courthouse, North Carolina. This getaway for novices and expert alike. Climbing instructor is available to beginners at an optional low price. Camping equipment rental is also available.</div>
                    <div class="price" data-price="350">Price</div>
                    <button class="btn btn-inline btn-extras">Extras</button>
                    <button class="btn btn-inline btn-book">Book Now!</button>
                    <ul class="extras">
                        <li><span class="price" data-price="30">Climbing Instruction</span></li>
                        <li><span class="price perDay" data-price="40">Equipment Rental</span></li>
                    </ul>
                </div>
            </li>
            <li class="package" data-packageID="2">
                <h2 class="package-name">Scuba Bahama</h2>
                <div class="details">
                    <div class="desription">A week-long cruise to Bahama with three day with three days of scuba diving. Those with prior experience may dive right in, while beginners should choose to take the optional, but very affordable lesson.</div>
                    <div class="price" data-price="600">Price</div>
                    <button class="btn btn-inline btn-extras">Extras</button>
                    <button class="btn btn-inline btn-book">Book Now!</button>
                    <ul class="extras">
                        <li><span class="price" data-price="40">SCUBA Instruction</span></li>
                    </ul>
                </div>
            </li>
            <li class="package" data-packageID="3">
                <h2 class="package-name">Sky Dive Colorado</h2>
                <div class="details">
                    <div class="desription">Four thrilling days with expert sky diving instructors in Colorado Springs. For lodging, you may choose either the Wilderness Lodge or Luxury Inn.</div>
                    <div class="price" data-price="400">Price</div>
                    <button class="btn btn-inline btn-extras">Extras</button>
                    <button class="btn btn-inline btn-book">Book Now!</button>
                    <ul class="extras">
                        <li><span class="price perDay" data-price="65">Wilderness Lodge</span></li>
                        <li><span class="price perDay" data-price="120">Luxury Inn</span></li>
                    </ul>
                </div>
            </li>
            <li class="package" data-packageID="4">
                <h2 class="package-name">Baron Cliff</h2>
                <div class="details">
                    <div class="desription">Eight days spent hiking and exploring caves in the Barron Cliff Wilderness , in Tennessee. Camping equipment rental is available.</div>
                    <div class="price" data-price="700">Price</div>
                    <button class="btn btn-inline btn-extras">Extras</button>
                    <button class="btn btn-inline btn-book">Book Now!</button>
                    <ul class="extras">
                        <li><span class="price" data-price="40">Equipment Rental</span></li>
                    </ul>
                </div>
            </li>
        </ul>
    </div>
    <div class="bookingForms">
        <div class="package" data-packageID="1">
            <div class="bookingForm">
                <h2 class="package-name">Devil's Courthouse Adventure Weekend</h2>
                <div>
                    Number of people: <input class="price price-base" data-price="350" size="5" required />
                </div>
                <div>
                    Climbing Instruction: <input id="numInstruct-1" class="price" data-price="30" size="5" required /> people
                </div>
                <div>
                    <span id="numRent-1">Equipment Rental: <input class="price perDay" data-price="40" size="5" required /> people for <input class="days" size="5" required /></span>
                </div>
                <div>
                    <button class="btn btn-inline btn-confirm">Confirm</button>
                </div>
            </div>
            <div class="confirmation">
                <div>
                    Number of people in party: <span class="result numBase"></span> Charge: $<span class="result priceBase"></span>
                <div>
                <div>
                    Number of people who will need climbing instruction: <span class="result numInstruct"></span> <span class="priceInstruct"></span>
                <div>
                <div>
                    Number of people who will rent climbing equipment: <span class="result numRent"></span> Charge: $<span class="result priceRent"></span>
                <div>
                <div>
                    Charges: $<span class="result subTotal"></span>
                <div>
                <div>
                    Discount: $<span class="result discount"></span>
                <div>
                <div>
                    Total: $<span class="result total"></span>
                <div>
                <div>
                    Required Deposit: $<span class="result deposit"></span>
                <div>
                <div>
                    <button class="btn btn-inline btn-finish>OK</button>
                </div>
            <div>
        </div>
    </div>
</asp:Content>
