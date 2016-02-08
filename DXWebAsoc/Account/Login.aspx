<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Light.master" CodeBehind="Login.aspx.cs" Inherits="DXWebAsoc.Login" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="accountHeader">
        <h2>Ingreso al Sistema</h2>
        <p>
        <!--Por favor ingrese sus Usuario y Contrase�a. Vaya a <a href="Register.aspx">Registro</a> si desea manipular cuentas de usuario (Necesitar� permisos de Administrador)</p>-->
    </div>
    <dx:ASPxLabel ID="lblUserName" runat="server" AssociatedControlID="tbUserName" Text="Usuario:" />
    <div class="form-field">
        <dx:ASPxTextBox ID="tbUserName" runat="server" Width="200px">
            <ValidationSettings ValidationGroup="LoginUserValidationGroup">
                <RequiredField ErrorText="Usuario es requerido." IsRequired="true" />
            </ValidationSettings>
        </dx:ASPxTextBox>
    </div>
    <dx:ASPxLabel ID="lblPassword" runat="server" AssociatedControlID="tbPassword" Text="Contrase�a:" />
    <div class="form-field">
        <dx:ASPxTextBox ID="tbPassword" runat="server" Password="true" Width="200px">
            <ValidationSettings ValidationGroup="LoginUserValidationGroup">
                <RequiredField ErrorText="Contrase�a es requerida." IsRequired="true" />
            </ValidationSettings>
        </dx:ASPxTextBox>
    </div>
    <dx:ASPxButton ID="btnLogin" runat="server" Text="Ingresar" ValidationGroup="LoginUserValidationGroup"
    OnClick="btnLogin_Click">
    </dx:ASPxButton>
</asp:Content>