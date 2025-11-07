<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio_17._1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>


        <div class="row">

            <div>
                <asp:GridView ID="MyGridView" DataSourceID="MyDataSource1"
                    AllowSorting="true" AllowPaging="true"
                    DataKeyNames="ProductID"
                    AutoGenerateEditButton="true"
                    runat="server" />

                <asp:SqlDataSource ID="MyDataSource1" runat="server"
                    ConnectionString="data source=.\SQLEXPRESS;initial catalog=northwind;persist security info=true;Integrated Security=SSPI;"
                    ProviderName="System.Data.SqlClient"
                    SelectCommand="SELECT ProductId, ProductName, UnitPrice From Products"
                    UpdateCommand="Update Products set [ProductName]=@ProductName, [UnitPrice]=@UnitPrice Where [ProductId]=@ProductId"></asp:SqlDataSource>
            </div>

        </div>
    </main>

</asp:Content>
