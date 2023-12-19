<%@ Page Language="C#" Title="BOOK INFO" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookInfo.aspx.cs" Inherits="cdbook.BookInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Book Information</h2>
    <asp:DetailsView ID="DetailsViewBook" runat="server" AutoGenerateRows="false">
        <Fields>
            <asp:BoundField DataField="Title" HeaderText="Title" />
            <asp:BoundField DataField="Author" HeaderText="Author" />
            <asp:BoundField DataField="Publisher" HeaderText="Publisher" />
            <asp:BoundField DataField="PageNumber" HeaderText="Page Number" />

               <asp:TemplateField HeaderText="Cover Image">
                <ItemTemplate>
                    <asp:Image ID="ImageCover" runat="server" ImageUrl='<%# Eval("CoverImage") %>' Width="100" Height="150" />
                </ItemTemplate>
            </asp:TemplateField>
         
           
        </Fields>
    </asp:DetailsView>
</asp:Content>
