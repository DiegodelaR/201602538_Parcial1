Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If (MsgBox("¿Está seguro que quiere salir?", vbCritical + vbYesNo)) = vbYes Then
            End
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If rbAvioneta.Checked = False And rbHelicóptero.Checked = False And rbJet.Checked = False Then
            MsgBox("No se han selecionado tipo de aeronave")
        End If
        If cbCostaSur.Checked = False And cbPetén.Checked = False And cbIzabal.Checked = False Then
            MsgBox("No se ha seleccionado destino")
        End If
        If txt1.Text = "" Then
            MsgBox("No se ha escrito el número de pasajeros")
        End If
        If rbAvioneta.Checked = True Then
    End Sub
End Class
