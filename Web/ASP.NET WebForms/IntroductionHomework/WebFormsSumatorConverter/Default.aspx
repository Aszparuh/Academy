<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsSumatorConverter._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h3>Sumator</h3>
        <div class="input-group input-group-lg">
            <asp:TextBox ID="tbFirst" runat="server"></asp:TextBox> 
        </div>  
        <div class="input-group input-group-lg">
            <asp:TextBox ID="tbSecond" runat="server"></asp:TextBox>
        </div>
        <div class="input-group">
            <asp:Button ID="sumButton" runat="server" OnClick="Btn_Sum_Click"/>
        </div>
        <div class="input-group input-group-lg">   
            <asp:Label ID="result" runat="server"></asp:Label>  
        </div>           
    </div>
    <div class="jumbotron">
        <h3>Convertor</h3>
        <div class="nput-group input-group-lg">
            <asp:TextBox ID="tbTextToImg" runat="server"></asp:TextBox>
        </div>
        <div class="nput-group input-group-lg">
            <asp:Button ID="convertorButton" runat="server" OnClick="RenderImageButtonClicked"/>
        </div>
        <div class="nput-group input-group-lg">
            <asp:Image ID="resultImage" runat="server" />
        </div>
    </div>
</asp:Content>
