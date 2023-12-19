<%@ Page Language="C#" Title="CD INFO" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CDInfo.aspx.cs" Inherits="cdbook.CDInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Book Information</h2>
    <asp:DetailsView ID="DetailsViewBook" runat="server" AutoGenerateRows="false">
        <Fields>
            <asp:BoundField DataField="Title" HeaderText="Title" />
            <asp:BoundField DataField="Artist" HeaderText="Artist" />
            <asp:BoundField DataField="Year" HeaderText="Year" />
            <asp:BoundField DataField="Duration" HeaderText="Duration:  " />

         
         
           
        </Fields>
    </asp:DetailsView>
</asp:Content>

