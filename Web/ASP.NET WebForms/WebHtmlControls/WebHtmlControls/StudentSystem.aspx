<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentSystem.aspx.cs"  MasterPageFile="~/Site.Master" Inherits="WebHtmlControls.StudentSystem" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Student</h3>
    <div class="input-group">
        <span class="input-group-addon">First name</span>
        <asp:TextBox ID="tbFirstName" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <br />
    <div class="input-group">
        <span class="input-group-addon">Last name</span>
        <asp:TextBox ID="tbLastName" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <br />
    <div class="input-group">
        <span class="input-group-addon">Student number</span>
        <asp:TextBox ID="tbStudentNumber" runat="server" CssClass="form-control" ></asp:TextBox>
    </div>
    <br />
    <div class="input-group">   
        <asp:DropDownList ID="ddlUniversity" runat="server" >
            <asp:ListItem>Sofia University</asp:ListItem>
            <asp:ListItem>Plovdiv University</asp:ListItem>
            <asp:ListItem>Burgas University</asp:ListItem>
        </asp:DropDownList>
    </div>
    <br />
    <div class="input-group">   
        <asp:DropDownList ID="ddlSpecialty" runat="server" >
            <asp:ListItem>Math</asp:ListItem>
            <asp:ListItem>Physics</asp:ListItem>
            <asp:ListItem>Literature</asp:ListItem>
        </asp:DropDownList>
    </div>
    <br />
    <div class="input-group">   
        <asp:ListBox ID="ddlCourses" runat="server" SelectionMode="Multiple">
            <asp:ListItem>Course 1</asp:ListItem>
            <asp:ListItem>Course 2</asp:ListItem>
            <asp:ListItem>Course 3</asp:ListItem>
        </asp:ListBox>
    </div>
    <br />
    <div class="input-group">
        <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-default" Text="Submit" OnCommand="btnSubmit_Command"/>
    </div>
    <br />
    <asp:Label ID="result" runat="server"></asp:Label>
</asp:Content>