<%@ Page Language="C#" AutoEventWireup="true" CodeFile="vinci.aspx.cs" Inherits="vinci" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

    <div>
    <h2>
        Importazione file vinci
    </h2>
    <asp:FileUpload ID="FileUpload1" runat="server" />
   &nbsp;Carica File<br/>
   <br/>
      <asp:Button ID="Button1" runat="server" Text="Crea file comune vinci" onclick="Button1_Click" /> 
      <asp:Label ID="label" runat="server" Text=""></asp:Label>
      <asp:Label ID="mandati" runat="server" Text=""></asp:Label>
      <asp:Label ID="reversali" runat="server" Text=""></asp:Label>
      <br />
      <br />
      <br />
      <a ID="LabelAllegato1" runat="server" style="display:none;" download> Scaricare QUI il File risultato... </a>
    </div>
    <asp:Label ID="LabelMessaggi" runat="server" Text="Selezionare prima il file da caricare." style="display:none;" ></asp:Label>    </form>
</body>
</html>
