Public Class FrmDatos

    Friend anio As Integer
    Friend mes As Integer
    Friend blEstado As Boolean



    Public Sub cargarComboMes()
        Dim dtMes As New DataTable
        dtMes.Columns.Add("mes")
        Dim drmes As DataRow
        drmes = dtMes.NewRow()
        For i As Integer = 1 To 12
            drmes = dtMes.NewRow()
            drmes("mes") = i
            dtMes.Rows.Add(drmes)
        Next
        cbxMes.DataSource = dtMes
        cbxMes.ValueMember = "mes"
        cbxMes.DisplayMember = "mes"
        cbxMes.Value = Month(Now) - 1
    End Sub

    Public Sub cargarComboAnio()
        Dim dtAnio As New DataTable
        dtAnio.Columns.Add("anio")
        Dim dranio As DataRow
        dranio = dtAnio.NewRow()
        'Dim anio As Integer = Year(Now)
        For i As Integer = 0 To 20
            Dim anio As Integer = Year(Now)
            anio = anio - i
            dranio = dtAnio.NewRow()
            dranio("anio") = anio
            dtAnio.Rows.Add(dranio)
        Next
        cbxAnio.DataSource = dtAnio
        cbxAnio.ValueMember = "anio"
        cbxAnio.DisplayMember = "anio"
        cbxAnio.Value = Year(Now)
    End Sub

    Private Sub FrmDatos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargarComboAnio()
        cargarComboMes()

    End Sub


    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        mes = cbxMes.Value
        anio = cbxAnio.Value
        blEstado = False

        Me.Close()

    End Sub

    Private Sub BtbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        blEstado = True
        Me.Close()
    End Sub

End Class