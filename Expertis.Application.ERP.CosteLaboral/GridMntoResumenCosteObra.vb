Imports Solmicro.Expertis.Business.ClasesTecozam
Imports Solmicro.Expertis.Engine

Public Class GridMntoResumenCosteObra



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
        cmbMes.DataSource = dtMes
        cmbMes.ValueMember = "mes"
        cmbMes.DisplayMember = "mes"
        'cmbMes.Value = Month(Now) - 1
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
        cmbAnio.DataSource = dtAnio
        cmbAnio.ValueMember = "anio"
        cmbAnio.DisplayMember = "anio"
        'cmbAnio.Value = Year(Now)
    End Sub


    Private Sub GridMntoResumenCosteObra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargarComboMes()
        cargarComboAnio()
    End Sub

    Private Sub GridMntoResumenCosteObra_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles Me.QueryExecuting
        e.Filter.Add("nobra", FilterOperator.Equal, advidObra.Text, FilterType.String)
        e.Filter.Add("MesProd", FilterOperator.Equal, cmbMes.Value)
        e.Filter.Add("AnioProd", FilterOperator.Equal, cmbAnio.Value)
    End Sub
End Class
