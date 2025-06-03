<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebNort.aspx.cs" Inherits="NortWind_11.WebNort" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Selección (σ) – Filtrar registros por condiciones</p>
            <p>
                <asp:Button Text ="Consulta 1" runat ="server" ID="btnConsulta1" OnClick="btnConsulta1_Click" />
                <asp:Button Text ="Consulta 2" runat ="server" ID="btnConsulta2" OnClick="btnConsulta2_Click" />
                <asp:Button Text ="Consulta 3" runat ="server" ID="btnConsulta3" OnClick="btnConsulta3_Click" />
            </p>
            <p>Proyección (π) – Seleccionar columnas específicas</p>
            <p>
                <asp:Button Text ="Consulta 1" runat ="server" ID="btnConsulta4" OnClick="btnConsulta4_Click" />
                <asp:Button Text ="Consulta 2" runat ="server" ID="btnConsulta5" OnClick="btnConsulta5_Click" />
                <asp:Button Text ="Consulta 3" runat ="server" ID="btnConsulta6" OnClick="btnConsulta6_Click" style="height: 26px" />
            </p>
            <p>Renombramiento (ρ) – Cambiar nombre de columnas en el resultado</p>
            <p>
                 <asp:Button Text ="Consulta 1" runat ="server" ID="btnConsulta7" OnClick="btnConsulta7_Click" />
                 <asp:Button Text ="Consulta 2" runat ="server" ID="btnConsulta8" OnClick="btnConsulta8_Click" />
                 <asp:Button Text ="Consulta 3" runat ="server" ID="btnConsulta9" OnClick="btnConsulta9_Click" />
            </p>
            <p>
              <asp:GridView runat="server" ID ="gvConsulta"></asp:GridView>
           </p>
        </div>
    </form>
</body>
</html>
