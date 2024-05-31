<%@ Page Title="Product Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="NorthwindDbTest_CSharp.Details" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <nav aria-label="breadcrumb">
            <ol class="breadcrumb">
                <li class="breadcrumb-item"><a href="/">Home</a></li>
                <li class="breadcrumb-item"><a href="/Products">Products</a></li>
                <li class="breadcrumb-item active" aria-current="page">Product Details</li>
            </ol>
        </nav>
        <div class="row mt-3">
            <h2 id="title"><%: Title %> - <asp:Label id="paramVal" runat="server" /></h2>
            <asp:UpdatePanel ID="upResults" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <div class="col-12 mt-2">
                        <div class="d-flex">
                            <div class="me-sm-auto py-2">
                                <span class="small"><asp:Literal ID="lblRecordCount" runat="server"></asp:Literal></span>
                            </div>
                            
                        </div>
                    </div>
                    <div class="col-12 mt-2">
                        <div class="table-responsive">
                            <asp:GridView ID="gvProductInfo" runat="server" 
                                AutoGenerateColumns="false" 
                                Width="100%" 
                                CellPadding="3"
                                CssClass="table table-sm table-striped table-light"
                                EmptyDataText = "No info available.">
                                <Columns>
                                    <asp:BoundField DataField="Id" HeaderText="Product Id" />
                                    <asp:BoundField DataField="Name" HeaderText="Name" />
                                    <asp:BoundField DataField="SupplierId" HeaderText="Supplier Id" />
                                    <asp:BoundField DataField="CategoryId" HeaderText="Category Id" />
                                    <asp:BoundField DataField="QuantityPerUnit" HeaderText="Qty Per Unit" />
                                    <asp:TemplateField HeaderText="Unit Price">
                                        <ItemTemplate>
                                            <%# $"${Eval("UnitPrice")}" %>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="UnitsInStock" HeaderText="Units In Stock" />
                                    <asp:BoundField DataField="UnitsOnOrder" HeaderText="Units On Order" />
                                    <asp:BoundField DataField="ReorderLevel" HeaderText="Reorder Level" />
                                    <asp:TemplateField HeaderText="Available">
                                        <ItemTemplate>
                                            <i class='bi bi-circle-fill <%# Convert.ToBoolean(Eval("discontinued")) ? "text-danger" : "text-success"%>'></i>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                    <h4 id="supplierHeader"><asp:Label id="supplierLabel" runat="server" /></h4>
                    <div class="col-12 mt-2">
                        <div class="table-responsive">
                            <asp:GridView ID="gvSupplier" runat="server" 
                                AutoGenerateColumns="false" 
                                Width="100%" 
                                CellPadding="3"
                                CssClass="table table-sm table-striped table-light"
                                EmptyDataText = "No info available.">
                                <Columns>
                                    <asp:BoundField DataField="Id" HeaderText="Supplier Id" />
                                    <asp:BoundField DataField="CompanyName" HeaderText="Company Name" />
                                    <asp:BoundField DataField="ContactName" HeaderText="Contact Name" />
                                    <asp:BoundField DataField="ContactTitle" HeaderText="Contact Title" />
                                    <asp:BoundField DataField="Address" HeaderText="Address" />
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                    <h4 id="categoryHeader"><asp:Label id="categoryLabel" runat="server" /></h4>
                    <div class="col-12 mt-2">
                        <div class="table-responsive">
                            <asp:GridView ID="gvCategory" runat="server" 
                                AutoGenerateColumns="false" 
                                Width="100%" 
                                CellPadding="3"
                                CssClass="table table-sm table-striped table-light"
                                EmptyDataText = "No info available.">
                                <Columns>
                                    <asp:BoundField DataField="Id" HeaderText="Category Id" />
                                    <asp:BoundField DataField="Name" HeaderText="Name" />
                                    <asp:BoundField DataField="Description" HeaderText="Description" />
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                    <h4 id="title"><%: Title %> - Orders Containing This Product</h4>
                    <div class="col-12 mt-2">
                        <div class="table-responsive">
                            <asp:GridView ID="gvProductOrders" runat="server" 
                                AutoGenerateColumns="false" 
                                Width="100%" 
                                CellPadding="3"
                                CssClass="table table-sm table-striped table-light"
                                EmptyDataText = "No orders available.">
                                <Columns>
                                    <asp:TemplateField HeaderText="Order Id" >
                                        <ItemTemplate>
                                            <%# $"{Eval("Id")}" %>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="customerId" HeaderText="Customer Id" />
                                    <asp:BoundField DataField="orderDate" HeaderText="Order Date" />
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>
