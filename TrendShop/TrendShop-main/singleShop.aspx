<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.master" AutoEventWireup="true" CodeFile="singleShop.aspx.cs" Inherits="singleShop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

         
        <section id="single-header">
            <div class="container">
                <div class="row">
                    <div class="col-lg-6 col-sm-6 col-md-6">
                        <div class="single-title">
                            <asp:Label Font-Size="22" Font-Bold="true" ID="ProductName" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                </div>
            </div>  
        </section>

        <section class="white-wrapper clearfix">
            <div class="container">
                <div class="row">
                    <div id="content" class="col-md-9 col-sm-12 col-xs-12">
                        <div class="blog-box row clearfix">
                            <div class="col-md-5 col-sm-5 col-xs-12">
                                 <asp:Image runat="server" ID="ImagePreview" ImageUrl="~/demos/featured_03.jpg" Width="350" Height="500" />
                                
                            </div>

                            <div id="shop-desc" class="col-md-7 col-sm-7 col-xs-12">
                                <div class="blog-title">
                                     <asp:Label ID="ProductName2" Font-Size="15" Font-Bold="true" runat="server" Text=""></asp:Label>
                                </div>
                                <div class="big-price clearfix">
                                 <asp:Label ID="ProductPrice" Font-Size="15" Font-Bold="true" runat="server" Text=""></asp:Label>
                                </div>
            

                                <span class="meta">
                                    <span class="rating">
                                        <span class='glyphicon glyphicon-star'></span>
                                        <span class='glyphicon glyphicon-star'></span>
                                        <span class='glyphicon glyphicon-star'></span>
                                        <span class='glyphicon glyphicon-star-empty'></span>
                                        <span class='glyphicon glyphicon-star-empty'></span>
                                    </span>
                                </span><!-- end meta -->

                                <div class="desc">
                                    <asp:Label ID="ProductDescreption" runat="server" Text=""></asp:Label>
                                </div>

                                <hr>

                                <div class="meta">       
                                    <div class="plus-minus">
                                        <div class="input-group">
                                          <span class="input-group-btn">
                                           
                                              <asp:Button ID="ButtonPlus" OnClick="ButtonPlus_Click" CssClass="btn btn-primary btn-number" runat="server" Text="-" />
                                         
                                          </span>
                                          
                                            <asp:TextBox ID="TextBox" class="form-control input-number" Text="1" runat="server"></asp:TextBox>
                                          <span class="input-group-btn">
                                              <asp:Button ID="Button2" OnClick="ButtonPlus_Click" CssClass="btn btn-primary btn-number" runat="server" Text="+" />
                                              
                                          </span>
                                          <span class="input-group-btn">
                                              <asp:Button ID="AddOrder"  OnClick="AddOrder_Click" CssClass="btn btn-primary btn-number" runat="server" Text="Sepete Ekle" />
                                          </span>

                                      </div>

                                        <div class="shop-informations row clearfix">
                                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                                        
                                          
                                        </div>
                                    </div>
                                </div>

                                    </div>
                                </div>

                                <hr>

                                <div id="myTabContent" class="tab-content">
                                            <div class="tab-pane fade in active" id="home">
                                                <p>15 gün içinde ücretsiz iade.<br/>
                                    detaylı çok kullanışlı bir beden incelten korse etkili tayt<br /> 
                                      Bir ürününden fazla 10 adet sipariş verilebilir.<br /> 
                                                    10 adetin üzerindeki siparişleri TrendShop iptal etme hakkını saklı tutar.<br />
                                    Kampanya fyatından satılmak üzere 5 adetten fazla stok sunulmuştur.<br />
                                    İncelemiş olduğunuz ürünün satış fiyatını satıcı belirlemektedir.
                                            </div>

                            </div>
                        </div>

                        <hr><br>
                    </div>

                </div>
            </div>
        </section>


</asp:Content>

