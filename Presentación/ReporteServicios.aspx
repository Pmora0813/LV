<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ReporteServicios.aspx.cs" Inherits="Presentación.ReporteServicios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container col-lg-8 mt-5 mb-5" data-aos="fade-up" data-aos-duration="1500">
        <div class="justify-content-center text-center">
            <%-- controladores para la entrada de datos de los vehiculos --%>
            <div class="card Panel ">
                <div class="card-header " >
                    <h4 class="card-title text-center">Reportes Vehiculos-Servicios</h4>
                </div><%--fin del header--%>

                <div class="card-body">
                    <div class="Panel">
                        <h5 class="card-title text-center">Datos principales</h5>
                        

                        <div class="form-group">
                        <div class="row">
                            <div class="col-md-3">
                                <asp:Label ID="lblSer" Text="Servicio:" runat="server" />
                            </div>
                            
                            <div class="col-md-8">
                                <asp:DropDownList  ID="drpServicios" runat="server" OnSelectedIndexChanged="drpServicios_SelectedIndexChanged" AutoPostBack="True" CssClass="form-control"/>
                            </div>
                        </div>
                    </div>

                    </div> <%--fin del panel--%>
                </div>

                <asp:GridView ID="datos" runat="server" AutoGenerateColumns="false" DataKeyNames="ID_Vehiculo_Servicio" CssClass="table table-responsive-lg">
                            <Columns>
                                <asp:BoundField DataField="ID_Vehiculo_Servicio" HeaderText="ID_Vehiculo_Servicio"></asp:BoundField>   
                                <asp:BoundField DataField="ID_Servicio" HeaderText="ID_Servicio"></asp:BoundField>   
                                <asp:BoundField DataField="ID_Vehiculo" HeaderText="ID_Vehiculo"></asp:BoundField>   
                            </Columns>
                        </asp:GridView>

                <div class="card-footer">
                    <h5>Control de Vehiculos-Servicios</h5>
                </div><%--fin del footer--%>
            </div>
        </div>
    </div>

</asp:Content>
