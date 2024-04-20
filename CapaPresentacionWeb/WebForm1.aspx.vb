Imports CapaEntidad


Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    ' Declaramos el objeto persona
    Dim persona1 As New Persona()



    Protected Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        persona1.Apellidos = txtApellidos.Text
        persona1.Nombres = txtNombres.Text
        persona1.Edad = txtEdad.Text
        lblResultado.Text = "Persona registrada correctamente"
    End Sub

    Protected Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        lblResultado.Text = persona1.DevolverDatos()
    End Sub
End Class