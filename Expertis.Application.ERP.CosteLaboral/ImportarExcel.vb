Imports System.Data.OleDb
Imports Microsoft.Office
Imports Microsoft.Office.Interop
Imports Solmicro.Expertis.Business.ClasesTecozam
Imports Solmicro.Expertis.Engine.UI
Imports Solmicro.Expertis.Engine
Imports System.Text

Public Class ImportarExcel

    Public Function ObtenerDatosExcel(ByVal ruta As String, ByVal hoja As String, ByVal rango As String) As DataTable
        Dim MyConnection As System.Data.OleDb.OleDbConnection
        Dim DtSet As System.Data.DataSet
        Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
        MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & ruta & "';Extended Properties=Excel 12.0;")
        MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [" & hoja & "$" & rango & "]", MyConnection)
        'MyCommand.TableMappings.Add("Table", "Net-informations.com")
        DtSet = New System.Data.DataSet
        MyCommand.Fill(DtSet)
        Dim dt As DataTable = DtSet.Tables(0)
        MyConnection.Close()

        Return dt

    End Function

    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        Dim ruta As String
        Dim hoja As String = 1
        Dim rango As String = "B8:I2222"
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




                    dtCoste.Columns.Add("mes")
                    dtCoste.Columns.Add("Anio")
                    dtCoste.Columns.Add("nif")
                    dtCoste.Columns.Add("Trabajador")
                    dtCoste.Columns.Add("CosteEmpresa")

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
                                drCoste("mes") = cbxMes.Value
                                drCoste("Anio") = cbxAnio.Value
                                drCoste("nif") = (dr(2))
                                drCoste("Trabajador") = dr(1)
                                drCoste("CosteEmpresa") = CDbl(dr(7))
                                dtCoste.Rows.Add(drCoste)
                                control = control + 1
                            End If
                        End If
                    Next
                    Grid1.DataSource = dtCoste

                    For Each drInsert As DataRow In dtCoste.Rows

                        'Grid1.InvokeBusinessRules("mes", drInsert("mes"), Grid1.GetValue("IDCosteEmpresa"))
                        'Dim data As New DataCrearCosteEmpresa


                        'Dim clsCE As New CosteEmpresa
                        'Dim dtCE As DataTable = clsCE.AddNewForm
                        'dtCE.Rows(0)("Mes") = drInsert("mes")
                        'dtCE.Rows(0)("Anio") = drInsert("Anio")
                        'dtCE.Rows(0)("Nif") = drInsert("Nif")
                        'dtCE.Rows(0)("CosteEmpresa") = drInsert("CosteEmpresa")
                        'clsCE.Update(dtCE)

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

    Private Sub ImportarExcel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargarComboMes()
        cargarComboAnio()
        Grid1.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False
    End Sub


    Private Sub aPrecios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aPrecios.Click
        Dim ruta As String
        Dim hoja As String = "Hoja1"
        Dim rango As String = "A1:C1500"
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
                    'MessageBox.Show(" El excel tiene " & dt.Rows.Count & " lineas")
                    Dim articulo As New Solmicro.Expertis.Business.Negocio.Articulo
                    Dim IDArticulo As String
                    Dim ValorA As String
                    Dim PrecioA As String

                    For Each dr As DataRow In dt.Rows
                        IDArticulo = dr(0)
                        ValorA = dr(1).ToString.Replace(",", ".")
                        PrecioA = dr(2).ToString.Replace(",", ".")
                        articulo.actualizaPrecioYReposicion(IDArticulo, ValorA, PrecioA)
                        'articulo.actualizaPrecioYReposicion(IDArticulo, ValorA, PrecioA)
                    Next
                Catch
                End Try
            End If
            MsgBox("Precios actualizados")
        End With
    End Sub

    Private Sub bcheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bcheck.Click
        Dim ruta As String
        Dim hoja As String = "Hoja1"
        Dim rango As String = "A1:C1500"
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
                    'MessageBox.Show(" El excel tiene " & dt.Rows.Count & " lineas")
                    Dim sb As StringBuilder = New StringBuilder()

                    For Each dr As DataRow In dt.Rows
                        Dim dt2 As New DataTable
                        Dim f As New Filter
                        f.Add("IDArticulo", FilterOperator.Equal, dt.Rows(control)("IDArticulo"))
                        dt2 = New BE.DataEngine().Filter("tbMaestroArticulo", f)

                        If dt2.Rows.Count <> 1 Then
                            'MsgBox("El articulo " & dt.Rows(control)("IDArticulo") & " no existe.")
                            sb.Append(" " & dt.Rows(control)("IDArticulo"))
                        End If

                        control += 1
                    Next
                    MessageBox.Show(sb.ToString)
                Catch
                End Try
            End If

        End With
    End Sub

    Private Sub bactfami_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bactfami.Click
        Dim ruta As String
        Dim hoja As String = "Hoja1"
        Dim rango As String = "A1:B1500"
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
                    Dim articulo As New Solmicro.Expertis.Business.Negocio.Articulo
                    Dim IDArticulo As String

                    For Each dr As DataRow In dt.Rows
                        IDArticulo = dr(0)
                        articulo.actualizaFamiliaEntero(IDArticulo)
                        control += 1
                    Next

                Catch
                End Try
            End If
            MessageBox.Show("Actualizacion correcta.")
        End With
    End Sub
End Class
