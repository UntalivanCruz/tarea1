Public Class Form1
    Private Function getSuma(primerValor As Integer, segundoValor As Integer) As Integer
        Dim resultado As Integer = primerValor + segundoValor
        Return resultado
    End Function

    Private Function getResta(primerValor As Integer, segundoValor As Integer) As Integer
        Dim resultado As Integer = primerValor - segundoValor
        Return resultado
    End Function

    Private Function getMultiplicacion(primerValor As Integer, segundoValor As Integer) As Integer
        Dim resultado As Integer = primerValor * segundoValor
        Return resultado
    End Function
    Private Function getDivision(primerValor As Integer, segundoValor As Integer) As Integer
        Dim resultado As Integer = primerValor / segundoValor
        Return resultado
    End Function
    Private Function getRaiz(primerValor As Integer, segundoValor As Integer) As Integer
        Dim resultado As Integer = Math.Sqrt(primerValor) + Math.Sqrt(segundoValor)
        Return resultado
    End Function
    Private Function getExponente(primerValor As Integer, segundoValor As Integer) As Integer
        Dim resultado As Integer = primerValor ^ segundoValor
        Return resultado
    End Function

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim resultado As Integer
        Select Case cmbOperacion.SelectedIndex
            Case 0
                resultado = getSuma(txtPrimerValor.Text, txtSegundoValor.Text)
            Case 1
                resultado = getResta(txtPrimerValor.Text, txtSegundoValor.Text)
            Case 2
                resultado = getMultiplicacion(txtPrimerValor.Text, txtSegundoValor.Text)
            Case 3
                resultado = getDivision(txtPrimerValor.Text, txtSegundoValor.Text)
            Case 4
                resultado = getRaiz(txtPrimerValor.Text, txtSegundoValor.Text)
            Case 5
                resultado = getExponente(txtPrimerValor.Text, txtSegundoValor.Text)
        End Select
        txtResultado.Text = resultado
    End Sub

    Private Sub txtPrimerValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrimerValor.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSegundoValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSegundoValor.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
