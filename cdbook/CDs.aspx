<%@ Page Title="CDS" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CDs.aspx.cs" Inherits="cdbook.CDs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>List of All cds</h2>

    <asp:GridView ID="GridViewCD" runat="server" AutoGenerateColumns="false">
        <Columns>
            
            
            
            <asp:HyperLinkField DataTextField="Title" DataNavigateUrlFields="CDID" DataNavigateUrlFormatString="CDInfo.aspx?id={0}" HeaderText="Title" />
        </Columns>
    </asp:GridView>
</asp:Content>
