<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <asp:Label ID="LabelState" runat="server" Text=""></asp:Label>
     <section class="white-wrapper clearfix">
            <div class="container">
                <div class="row">
                    <div id="content" class="col-md-12 col-sm-12 col-xs-12">
                        <div class="single-page">

                            <div class="row">                             
                                <div class="col-sm-6 col-xs-12">
                                    <div class="widget-title">
                                        <h3>Kullancı Girişi</h3>
                                    </div><!-- end title -->
                                    <fieldset id="registerform" method="post" name="registerform" runat="server">
                                        
                                        <div class="form-group">
                                             <asp:TextBox ID="TextEmail" TextMode="Email" class="form-control" placeholder="E-posta adresinizi giriniz" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                             <asp:TextBox ID="TextPassword" TextMode="Password" class="form-control" placeholder="Şifrenizi giriniz" runat="server"></asp:TextBox>
                                        </div>
                                       
                                        <div class="form-group">
                                            <asp:Button ID="Button1" Width="150" OnClick="Button1_Click" class="btn btn-primary" runat="server" Text="Giriş yap" />
                                             <asp:Button ID="Button2" Width="150" OnClick="Button2_Click" class="btn btn-primary" runat="server" Text="Üye ol" />
                                        </div>
                                    </fieldset>
                                </div>
                            </div>
         
                        </div>
         
                    </div>
                </div>
            </div>
        </section>

</asp:Content>

