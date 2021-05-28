<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.master" AutoEventWireup="true" CodeFile="cart.aspx.cs" Inherits="cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
   
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:LoginConnectionString %>" SelectCommand="SELECT [name], [price], [path], [quantity] FROM [DB_A6D1AD_YahyaElrahim].[dbo].[orders]"></asp:SqlDataSource>
<asp:GridView  ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Height="200px" Width="1331px" CellPadding="4" ForeColor="#333333" GridLines="None">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:ImageField ItemStyle-HorizontalAlign="Center"  DataImageUrlField="path" ControlStyle-Width="100" ControlStyle-Height="100" >
        <ControlStyle Height="100px" Width="100px"></ControlStyle>

<ItemStyle HorizontalAlign="Center"></ItemStyle>
        </asp:ImageField>
        <asp:BoundField DataField="name" HeaderText="Ürün Adı" SortExpression="name" />
        <asp:BoundField DataField="price" HeaderText="Ürün Fiyatı" ItemStyle-HorizontalAlign="Center" SortExpression="price" >
<ItemStyle HorizontalAlign="Center"></ItemStyle>
        </asp:BoundField>
        <asp:BoundField DataField="quantity" HeaderText="Adet" />
    </Columns>


    <HeaderStyle Font-Bold="True" ForeColor="#507CD1" />
    

</asp:GridView>

     <section class="white-wrapper clearfix">
            <div class="container">
                <div class="row">
                    <div id="content" class="col-md-12 col-sm-12 col-xs-12">
                        <div class="single-page">
                            <div class="order-form">
                                 
                            
                                <div class="row calculate">
                                    <div class="col-md-6">
                                        <div class="widget-title">
                                            <h3></h3>
                                        </div>
                                   
                                    </div>

                                    <div class="col-md-6">
                                        <div class="widget-title">
                                            <h3>Sipariş Özeti</h3>
                                        </div>
                                        <div class="box2">
                                            <span class="pull-left">Kargo Ücreti</span>
                                            <span class="pull-right">10TL</span>
                                            <br><br>
                                            <span class="pull-left">Toplam</span>
                                            <span><asp:Label CssClass="pull-right" ID="Total" runat="server"></asp:Label></span>
                                            <br><br>
                                            <span class="margin-top">
                                            <asp:Button CssClass="btn btn-primary" OnClick="Button1_Click" ID="Button1" runat="server" Text="Ödemeye geç" />
                      
                                            </span>
                                            <div class="clearfix"></div>
                                        </div><!-- end box -->
                                    </div>
                                </div><!-- end row -->
                            </div>
                        </div><br><br>
                    </div><!-- end content -->
                </div><!-- end row -->
            </div><!-- end container -->
        </section>
   
</asp:Content>


