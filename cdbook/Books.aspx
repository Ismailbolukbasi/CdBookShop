<%@ Page Title="BOOKS" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Books.aspx.cs" Inherits="cdbook.Books" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>List of All Books</h2>

    <asp:GridView ID="GridViewBooks" runat="server" AutoGenerateColumns="false">
        <Columns>
            
            
            <asp:TemplateField HeaderText="Cover Image">
                <ItemTemplate>
                    <asp:Image ID="ImageCover" runat="server" ImageUrl='<%# Eval("CoverImage") %>' Width="100" Height="150" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:HyperLinkField DataTextField="Title" DataNavigateUrlFields="BookID" DataNavigateUrlFormatString="BookInfo.aspx?id={0}" HeaderText="Title" />
        </Columns>
    </asp:GridView>
</asp:Content>
