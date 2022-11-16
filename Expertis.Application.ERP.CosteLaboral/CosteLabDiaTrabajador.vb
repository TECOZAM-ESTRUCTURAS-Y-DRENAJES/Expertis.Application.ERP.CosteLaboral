Imports Solmicro.Expertis.Engine

Public Class CosteLabDiaTrabajador

    Private Sub CosteLabDiaTrabajador_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles Me.QueryExecuting
        e.Filter.Add("IdOperario", FilterOperator.Equal, advIDOperario.Text, FilterType.String)
        e.Filter.Add("FechaInicio", FilterOperator.GreaterThanOrEqual, clbFechaInicioMin.Value)
        e.Filter.Add("FechaInicio", FilterOperator.LessThanOrEqual, clbFechaInicioMax.Value)
        e.Filter.Add("NObra", FilterOperator.Equal, advnobra.Text)
        e.Filter.Add("IdOficio", FilterOperator.Equal, advidoficio.Text, FilterType.String)
    End Sub
End Class
