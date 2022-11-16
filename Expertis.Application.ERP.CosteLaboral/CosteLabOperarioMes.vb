Imports Solmicro.Expertis.Business.ClasesTecozam

Public Class CosteLabOperarioMes

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



    Private Sub CosteLabOperarioMes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargarComboMes()
        cargarComboAnio()
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim mes As Integer = cbxMes.Text
        Dim anio As Integer = cbxAnio.Text
        'Dim clsCE As New CosteEmpresa
        'Dim dtCosteLabMes As DataTable = clsCE.CalcularCosteHoraMes(mes, anio)

        'If dtCostelabMes.rows.count > 0 Then
        '    GridCoste.SetDataBinding(dtCostelabMes, "")
        '    GridCoste.RetrieveStructure()
        '    GridCoste.DataSource = dtCosteLabMes
        'Else
        '    MsgBox("No se han Cargado las lineas del Grid")

        'End If




    End Sub

    
End Class