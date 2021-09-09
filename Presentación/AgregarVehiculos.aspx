<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AgregarVehiculos.aspx.cs" Inherits="Presentación.AgregarVehiculos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container col-lg-8 mt-5 mb-5" data-aos="fade-up" data-aos-duration="1500">
        <div class="justify-content-center text-center">
            <%-- controladores para la entrada de datos de los vehiculos --%>
            <div class="card Panel ">
                <div class="card-header " >
                    <h4 class="card-title text-center"> Formulario de vehiculos</h4>
                </div><%--fin del header--%>

                <div class="card-body">
                    <div class="Panel">
                        <h5 class="card-title text-center">Datos principales del vehiculo</h5>
                        
                    <%-- placa --%>
                    <div class="form-group">
                        <div class="row">
                            <div class="col-md-3">
                                <asp:Label Text="Placa:" runat="server" />
                            </div>
                            
                            <div class="col-md-8">
                                <asp:TextBox ID="txtPlaca"  MaxLength="30" runat="server" CssClass="form-control" />
                            </div>

                            <div class="col-md-1">
                                <asp:RequiredFieldValidator ErrorMessage="Por favor la placa es requerida" ValidationGroup="0" ControlToValidate="txtPlaca" runat="server" ForeColor="Red">*</asp:RequiredFieldValidator>   
                            </div>
                        </div>
                    </div> <%--fin del form-group--%>

                    <%-- dueño--%>
                    <div class="form-group">
                        <div class="row">
                            <div class="col-md-3">
                                <asp:Label Text="Dueño:" runat="server" />
                            </div>
                            
                            <div class="col-md-8">
                                <asp:TextBox ID="txtDueño" runat="server" CssClass="form-control" />
                            </div>

                            <div class="col-md-1">
                                <asp:RequiredFieldValidator ErrorMessage="Por favor el dueño es requerido" ValidationGroup="0" ControlToValidate="txtDueño" runat="server" ForeColor="Red">*</asp:RequiredFieldValidator>   
                            </div>
                        </div>
                    </div> <%--fin del form-group--%>
                        
                        <%-- Marca --%>
                    <div class="form-group">
                        <div class="row">
                            <div class="col-md-3">
                                <asp:Label Text="Marca:" runat="server" />
                            </div>
                            
                            <div class="col-md-8">
                                <asp:TextBox ID="txtMarca" MaxLength="50" runat="server" CssClass="form-control" />
                            </div>

                            <div class="col-md-1">
                                <asp:RequiredFieldValidator ErrorMessage="Por favor la marca es requerida" ValidationGroup="0" ControlToValidate="txtMarca" runat="server" ForeColor="Red">*</asp:RequiredFieldValidator>   
                            </div>
                        </div>
                    </div> <%--fin del form-group--%>                        
                        
                    <%-- resumen para las validaciones  --%>
                    <div class="form-group">
                        <div class="row">
                            <div class="col-md-12 text-left">
                                <asp:ValidationSummary ForeColor="Red" ID="validaciones" ValidationGroup="0" DisplayMode="BulletList" runat="server" HeaderText="Datos requeridos" Font-Names="verdana" Font-Size="12" />
                            </div>
                        </div>
                    </div><%--fin de las validaciones--%>


                    <%-- boton de registrar --%>
                    <div class="form-group">
                        <div class="row">
                            <div class="col-md-12">
                                <asp:Button ID="btnRegistrar" Text="Registrar" ValidationGroup="0" CssClass="btn btn-primary" runat="server" OnClick="btnRegistrar_Click"/>
                                <asp:Button ID="btnConsultar" Text="Consultar" CssClass="btn btn-primary" runat="server" OnClick="btnConsultar_Click"/>
                                <asp:Button ID="btnModificar" Text="Modificar" CssClass="btn btn-success" runat="server" OnClick="btnModificar_Click"/>
                                <asp:Button ID="btnEliminar" Text="Eliminar" CssClass="btn btn-danger" runat="server" OnClick="btnEliminar_Click"/>
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
