<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                <%-- Sign Up Panel --%>
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <div class="panel-title text-center">Sign Up</div>
                    </div>
                    <div class="panel-body">
                        <%-- Registration User Name --%>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                            <asp:Label Text="User Name" ID="LabelUserName" CssClass="label label-info pull-right" runat="server" />
                            <asp:TextBox runat="server" ID="TextBoxName" placeholder="User Name" CssClass="panel-group form-control" />
                        </div>
                        <%-- Registration Email --%>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                            <asp:Label Text="Password" ID="LabelPassword" CssClass="label label-info pull-right" runat="server" />
                            <asp:TextBox runat="server" ID="TextBoxPassword" placeholder="Password" CssClass="panel-group form-control" />
                        </div>
                        <%-- Registration Password --%>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                            <asp:Label Text="Email ID" ID="LabelEmail" CssClass="label label-info pull-right" runat="server" />
                            <asp:TextBox runat="server" ID="TextBoxEmail" placeholder="Email ID" CssClass="panel-group form-control" />
                        </div>
                    </div>
                    <div class="panel-footer">
                        <asp:Button Text="Submit" ID="ButtonRegister" CssClass="btn btn-block btn-success" runat="server" />
                    </div>
                </div>
            </div>
            <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                <%-- Login Panel --%>
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <div class="panel-title text-center">Login</div>
                    </div>
                    <div class="panel-body">
                        <%-- Login Email --%>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                            <asp:Label Text="Email ID" ID="LabelEmailLogin" CssClass="label label-info pull-right" runat="server" />
                            <asp:TextBox runat="server" ID="TextBoxEmailLogin" placeholder="Email ID" CssClass="panel-group form-control" />
                        </div>
                        <%-- Login Password --%>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                            <asp:Label Text="Password" ID="LabelPasswordLogin" CssClass="label label-info pull-right" runat="server" />
                            <asp:TextBox runat="server" ID="TextBoxPasswordLogin" placeholder="Password" CssClass="panel-group form-control" />
                        </div>
                    </div>
                    <div class="panel-footer">
                        <asp:Button Text="Login" ID="ButtonLogin" CssClass="btn btn-block btn-success" runat="server" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
