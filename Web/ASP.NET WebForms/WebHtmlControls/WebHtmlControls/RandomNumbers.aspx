<%@ Page Title="Random Number" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RandomNumbers.aspx.cs" Inherits="WebHtmlControls.RandomNumber" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>

    <div class="row">
        <div class="col-xs-6">
            <h3>Generate Number HTML Controls</h3>
            <div class="input-group">
                <span class="input-group-addon" id="info1">from</span>
                <input id="from" runat="server" class="form-control" type="number" aria-describedby="info1"/>
            </div>
            <br />
            <div class="input-group">
                <span class="input-group-addon" id="info2">to</span>
                <input id="to" runat="server" class="form-control" type="number" aria-describedby="info2"/>
            </div>
            <br />
            <div class="input-group">
                <button type="button" class="btn btn-default" aria-label="Left Align" id="button" runat="server" onserverclick="button_ServerClick">
                <span aria-hidden="true">Generate</span>
                </button>
            </div>
            <br>
            <div class="input-group">
                <input id="generated" runat="server" class="form-control" type="number" />
            </div>
        </div>
        <div class="col-xs-6">
            <h3>Generate Number Web Controls</h3>
            <div class="input-group">
                <span class="input-group-addon" >from</span>
                <asp:TextBox ID="tbFrom" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div class="input-group">
                <span class="input-group-addon">to</span>
                <asp:TextBox ID="tbTo" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div class="input-group">
                <asp:Button ID="btnGenerate" runat="server" CssClass="btn btn-default" Text="Generate"/>
            </div>
            <br />
            <div class="input-group">
                <asp:TextBox ID="result" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>      
    </div>
</asp:Content>
