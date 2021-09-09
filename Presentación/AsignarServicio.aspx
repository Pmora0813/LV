<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AsignarServicio.aspx.cs" Inherits="Presentación.AsignarServicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container col-lg-8 mt-5 mb-5" data-aos="fade-up" data-aos-duration="1500">
        <div class="justify-content-center text-center">
            <%-- controladores para la entrada de datos de los vehiculos --%>
            <div class="card Panel ">
                <div class="card-header " >
                    <h4 class="card-title text-center">Asignar Servicios</h4>
                </div><%--fin del header--%>

                <div class="card-body">
                    <div class="Panel">
                        <h5 class="card-title text-center">Datos principales</h5>
                                                
                    <div class="form-group">
                        <div class="row">
                            <div class="col-md-3">
                                <asp:Label ID="Label1" Text="Placa del Vehiculo:" runat="server" />
                            </div>
                            
                            <div class="col-md-8">
                                <asp:DropDownList  ID="drpPlaca" runat="server" CssClass="form-control"/>
                            </div>
                        </div>
                    </div>                    

                    <div class="form-group">
                        <div class="row">
                            <div class="col-md-3">
                                <asp:Label ID="lblServicio" Text="Servicio:" runat="server" />
                            </div>
                            
                            <div class="col-md-8">
                                <asp:DropDownList  ID="drpServicio" runat="server" CssClass="form-control"/>
                            </div>
                        </div>
                    </div>

                    <%-- resumen para las validaciones  --%>
                    <div class="form-group">
                        <div class="row">
                            <div class="col-md-12 text-left">
                                <asp:ValidationSummary ForeColor="Red" ID="validaciones" DisplayMode="BulletList" runat="server" HeaderText="Datos requeridos" Font-Names="verdana" Font-Size="12" />
                            </div>
                        </div>
                    </div><%--fin de las validaciones--%>


                    <%-- boton de registrar --%>
                    <div class="form-group">
                        <div class="row">
                            <div class="col-md-12">
                                <asp:Button ID="btnAsignar" Text="Asignar Servicio" CssClass="btn btn-primary" runat="server" OnClick="btnAsignar_Click" />
                            </div>
                        </div>
                    </div>

                        
                    
                    </div> <%--fin del panel--%>
                </div>

                <div class="card-footer">
                    <h5>Control de Vehiculos</h5>
                </div><%--fin del footer--%>
            </div>
        </div>
    </div>

</asp:Content>
