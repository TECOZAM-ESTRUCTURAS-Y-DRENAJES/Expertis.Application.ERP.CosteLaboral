Imports System.Data.OleDb
Imports Microsoft.Office
Imports Microsoft.Office.Interop
Imports Solmicro.Expertis.Business.ClasesTecozam
Imports Solmicro.Expertis.Engine.UI
Imports Solmicro.Expertis.Engine

Public Class ImportarExcelSubFamilias

    Public Function ObtenerDatosExcel(ByVal ruta As String, ByVal hoja As String, ByVal rango As String) As DataTable
        Dim MyConnection As System.Data.OleDb.OleDbConnection
        Dim DtSet As System.Data.DataSet
        Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
        MyConnection = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='" & ruta & "';Extended Properties=Excel 8.0;")
        MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [" & hoja & "$" & rango & "]", MyConnection)
        'MyCommand.TableMappings.Add("Table", "Net-informations.com")
        DtSet = New System.Data.DataSet
        MyCommand.Fill(DtSet)
        Dim dt As DataTable = DtSet.Tables(0)
        MyConnection.Close()

        Return dt



    End Function
    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ruta As String
        Dim hoja As String = 1
        Dim rango As String = "A2:D28"
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx|Todos los archivos(*.*)|*.*"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If .ShowDialog = Windows.Forms.DialogResult.OK Then

                TextBox1.Text = openFD.FileName
                Dim dtCoste As New DataTable
                Dim control = 0
                Try
                    ruta = openFD.FileName
                    Dim dt As DataTable = ObtenerDatosExcel(ruta, hoja, rango)
                    MessageBox.Show(" el excel tiene " & dt.Rows.Count & " lineas")

                    'DTGCoste.DataSource = dt
                    'For Each dr As DataRow In dt.Rows
                    '    'MessageBox.Show(dr(0) & " , " & dr(1) & " , " & dr(3))

                    'Next

                    'Grid1.SetDataBinding(dt, "")
                    'Grid1.RetrieveStructure()
                    'Grid1.RootTable.Columns.Add("Mes")
                    'Grid1.RootTable.Columns.Add("Año")
                    'Grid1.DataSource = dt




                    dtCoste.Columns.Add("IDTipo")
                    dtCoste.Columns.Add("IDFamilia")
                    dtCoste.Columns.Add("IDSubFamilia")
                    dtCoste.Columns.Add("DescSubFamilia")

                    Dim drCoste As DataRow
                    Grid1.SetDataBinding(dtCoste, "")
                    Grid1.RetrieveStructure()

                    For Each dr As DataRow In dt.Rows
                        'MessageBox.Show(dr(0) & " , " & dr(2) & " , " & dr(7kkkkkkkk
                        If IsDBNull(dr(0)) Then

                        Else
                            If IsDBNull(dr(7)) = False Then
                                Grid1.RetrieveStructure()
                                drCoste = dtCoste.NewRow
                                drCoste("IDTipo") = cbxMes.Value
                                drCoste("IDFamilia") = cbxAnio.Value
                                drCoste("IDSubFamilia") = (dr(2))
                                drCoste("DescSubFamilia") = dr(1)
                                dtCoste.Rows.Add(drCoste)
                                control = control + 1
                            End If
                        End If
                    Next
                    Grid1.DataSource = dtCoste

                    For Each drInsert As DataRow In dtCoste.Rows

                        'Grid1.InvokeBusinessRules("mes", drInsert("mes"), Grid1.GetValue("IDCosteEmpresa"))
                        'Dim data As New DataCrearCosteEmpresa
                        Dim clsCE As New SubFamilias
                        Dim dtCE As DataTable = clsCE.AddNewForm
                        dtCE.Rows(0)("IDTipo") = drInsert("IDTipo")
                        dtCE.Rows(0)("IDFamilia") = drInsert("IDFamilia")
                        dtCE.Rows(0)("IDSubFamilia") = drInsert("IDSubFamilia")
                        dtCE.Rows(0)("DescSubFamilia") = drInsert("DescSubFamilia")
                        clsCE.Update(dtCE)

                        'Mes	Anio	Nif	CosteEmpresa
                        'data.mes = drInsert("mes")
                        'data.anio = drInsert("anio")
                        'data.nif = drInsert("nif")
                        'data.costeEmpresa = drInsert("CosteEmpresa")
                        'drInsert=clsCE.ApplyBusinessRule("mes",drInsert("IDCosteEmpresa",

                        'ExpertisApp.GenerateMessage(data.mes & " - " & drInsert("anio") & " - " & drInsert("nif") & " - " & drInsert("CosteEmpresa"))
                        'ExpertisApp.ExecuteTask(Of DataCrearCosteEmpresa)(AddressOf CosteEmpresa.CrearCosteEmpresa, data)
                    Next
                    ExpertisApp.GenerateMessage("Se han insertado las lineas correctamente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)





                Catch ex As Exception
                    'MessageBox.Show("la linea de fallo es: " & control)
                    ' Se ha producido un error
                    MessageBox.Show(ex.Message)

                End Try
            End If
        End With



    End Sub


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

    Private Sub ImportarExcel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarComboMes()
        cargarComboAnio()
        Grid1.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False
    End Sub

End Class

Public Class SubFamilias

    Inherits Solmicro.Expertis.Engine.BE.BusinessHelper

    Public Sub New()
        MyBase.New(cnEntidad)
    End Sub

    Private Const cnEntidad = "tbMaestroSubFamilias"
End Class
