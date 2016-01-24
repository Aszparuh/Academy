<%@ Page Title="Escaping example" Language="C#" validateRequest="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Escaping.aspx.cs" Inherits="WebHtmlControls.Escaping" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>


    <div class="input-group">
        <span class="input-group-addon" id="tbForm">Enter Text</span>
        <asp:TextBox ID="tbUserInput" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <br />
    <div class="input-group">
        <asp:Button ID="btnGenerate" runat="server" CssClass="btn btn-default" Text="Submit" OnCommand="Display"/>
    </div>
    <br />
    <div class="input-group">
        <asp:TextBox ID="tbOutput" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label ID="lbOutput" runat="server"></asp:Label>
    </div>
</asp:Content>
