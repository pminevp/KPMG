<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ComputerFactory.aspx.cs" Inherits="CF.Factory.ComputerFactory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <asp:Label ID="lblPartName" Text="Наименование на частта" runat="server"></asp:Label>
        <asp:TextBox ID="txtPartName" runat="server"></asp:TextBox>
        <asp:Label ID="lblPartType" Text="Вид на частта" runat="server"></asp:Label>
        <asp:TextBox ID="txtPartType" runat="server" Text="1"></asp:TextBox>
        <asp:Label ID="lblPrice" Text="цена" runat="server"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <br />
    </asp:Panel>
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="PartName" HeaderText="PartName" SortExpression="PartName" />
            <asp:BoundField DataField="PartType" HeaderText="PartType" SortExpression="PartType" />
            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
</asp:Content>
