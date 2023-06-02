Imports System.Data.OleDb
Imports Microsoft.Office
Imports Microsoft.Office.Interop
Imports Solmicro.Expertis.Business.ClasesTecozam
Imports Solmicro.Expertis.Engine.UI
Imports Solmicro.Expertis.Engine
Imports System.Text
Imports Solmicro.Expertis.Engine.BE.BusinessProcesses
Imports Solmicro.Expertis.Business.General
Imports Solmicro.Expertis.Business.Negocio

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
                        'articulo.actualizaFamiliaEntero(IDArticulo)
                        control += 1
                    Next

                Catch
                End Try
            End If
            MessageBox.Show("Actualizacion correcta.")
        End With
    End Sub

    Private Sub bActualizarPrecioCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bActualizarPrecioCompra.Click
        Dim ruta As String
        Dim hoja As String = "Hoja1"
        Dim rango As String = "A1:B3000"
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
                    Dim PrecioCompra As String
                    'Dim IDOperario As String
                    'IDOperario = ExpertisApp.ExecuteTask(Of Object, String)(AddressOf Operario.ObtenerIDOperarioUsuario, Nothing)
                    For Each dr As DataRow In dt.Rows
                        IDArticulo = dr(0)
                        If IDArticulo.ToString.Length = 0 Then
                            Exit For
                        End If
                        PrecioCompra = dr(1).ToString.Replace(",", ".")
                        articulo.actualizaPrecioCompra(IDArticulo, PrecioCompra)
                    Next
                Catch
                End Try
            End If
            MsgBox("Precios actualizados")
        End With
    End Sub


    Private Sub bCrearArticulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCrearArticulos.Click
        Dim contador As Integer
        Dim ruta As String
        Dim hoja As String = 1
        Dim rango As String = ""

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

                    dtCoste.Columns.Add("IDArticulo")
                    dtCoste.Columns.Add("DescArticulo")
                    dtCoste.Columns.Add("IDEstado")
                    dtCoste.Columns.Add("IDTipo")
                    dtCoste.Columns.Add("IDFamilia")
                    dtCoste.Columns.Add("IDSubFamilia")
                    dtCoste.Columns.Add("IDUdInterna")
                    dtCoste.Columns.Add("PrecioEstandarA")
                    dtCoste.Columns.Add("PrecioEstandarB")
                    dtCoste.Columns.Add("UdValoracion")
                    dtCoste.Columns.Add("PesoNeto")
                    dtCoste.Columns.Add("PesoBruto")
                    dtCoste.Columns.Add("TipoEstructura")
                    dtCoste.Columns.Add("TipoRuta")
                    dtCoste.Columns.Add("PuntoVerde")
                    dtCoste.Columns.Add("PVPMinimo")
                    dtCoste.Columns.Add("PorcentajeRechazo")
                    dtCoste.Columns.Add("Plazo")
                    dtCoste.Columns.Add("Volumen")
                    dtCoste.Columns.Add("RecalcularValoracion")
                    dtCoste.Columns.Add("CriterioValoracion")
                    dtCoste.Columns.Add("GestionStockPorLotes")
                    dtCoste.Columns.Add("PrecioUltimaCompraA")
                    dtCoste.Columns.Add("PrecioUltimaCompraB")
                    dtCoste.Columns.Add("LoteMultiplo")
                    dtCoste.Columns.Add("CantMinSolicitud")
                    dtCoste.Columns.Add("CantMaxSolicitud")
                    dtCoste.Columns.Add("LimitarPetDia")
                    dtCoste.Columns.Add("PrecioBase")
                    dtCoste.Columns.Add("Configurable")
                    dtCoste.Columns.Add("StockNegativo")
                    dtCoste.Columns.Add("PlazoFabricacion")
                    dtCoste.Columns.Add("CapacidadDiaria")
                    dtCoste.Columns.Add("AplicarLoteMRP")
                    dtCoste.Columns.Add("NSerieObligatorio")
                    dtCoste.Columns.Add("PuntosMarketing")
                    dtCoste.Columns.Add("ValorReposicionA")
                    dtCoste.Columns.Add("ValorReposicionB")
                    dtCoste.Columns.Add("ControlRecepcion")
                    dtCoste.Columns.Add("GenerarOFArticuloFinal")
                    dtCoste.Columns.Add("TipoFactAlquiler")
                    dtCoste.Columns.Add("Seguridad")
                    dtCoste.Columns.Add("Reglamentacion")
                    dtCoste.Columns.Add("SeguridadReglamentacion")
                    dtCoste.Columns.Add("DiasMinimosFactAlquiler")
                    dtCoste.Columns.Add("SinDtoEnAlquiler")
                    dtCoste.Columns.Add("SinSeguroEnAlquiler")
                    dtCoste.Columns.Add("NecesitaOperario")
                    dtCoste.Columns.Add("FacturacionAsociadaMaq")
                    dtCoste.Columns.Add("FactTasaResiduos")
                    dtCoste.Columns.Add("NoImprimirEnFactura")
                    dtCoste.Columns.Add("RetencionIRPF")
                    dtCoste.Columns.Add("IncluirEnEMCS")
                    dtCoste.Columns.Add("IDUdVenta")
                    dtCoste.Columns.Add("IDUdCompra")



                    hoja = "Hoja1"
                    rango = "A1:H500"

                    Dim dt As DataTable = ObtenerDatosExcel(ruta, hoja, rango)
                    MessageBox.Show("El excel tiene " & (dt.Rows.Count) & " filas.")

                    Dim drCoste As DataRow
                    Grid1.SetDataBinding(dtCoste, "")
                    Grid1.RetrieveStructure()

                    For Each dr As DataRow In dt.Rows
                        If IsDBNull(dr(0)) Then
                        Else
                            If IsDBNull(dr(7)) = False Then
                                Grid1.RetrieveStructure()
                                drCoste = dtCoste.NewRow
                                drCoste("IDTipo") = dr(0)
                                drCoste("IDFamilia") = dr(1)
                                drCoste("IDSubFamilia") = dr(2)
                                drCoste("IDArticulo") = dr(3)
                                drCoste("DescArticulo") = dr(4)
                                drCoste("IDEstado") = "A"
                                drCoste("IDUdInterna") = dr(5)
                                drCoste("IDUdCompra") = dr(5)
                                drCoste("IDUdVenta") = dr(5)
                                drCoste("PrecioEstandarA") = dr(7)
                                drCoste("PrecioEstandarB") = dr(7)
                                drCoste("UdValoracion") = 1
                                drCoste("PesoNeto") = 0
                                drCoste("PesoBruto") = 0
                                drCoste("TipoEstructura") = False
                                drCoste("TipoRuta") = False
                                drCoste("PuntoVerde") = 0
                                drCoste("PVPMinimo") = 0
                                drCoste("PorcentajeRechazo") = 0
                                drCoste("Plazo") = 0
                                drCoste("Volumen") = 0
                                drCoste("RecalcularValoracion") = 1
                                drCoste("CriterioValoracion") = 3
                                drCoste("GestionStockPorLotes") = False
                                drCoste("PrecioUltimaCompraA") = 0
                                drCoste("PrecioUltimaCompraB") = 0
                                drCoste("LoteMultiplo") = 0
                                drCoste("CantMinSolicitud") = 0
                                drCoste("CantMaxSolicitud") = 0
                                drCoste("LimitarPetDia") = False
                                drCoste("PrecioBase") = 0
                                drCoste("Configurable") = False
                                drCoste("StockNegativo") = False
                                drCoste("PlazoFabricacion") = 0
                                drCoste("CapacidadDiaria") = 0
                                drCoste("AplicarLoteMRP") = False
                                drCoste("NSerieObligatorio") = False
                                drCoste("PuntosMarketing") = 0
                                drCoste("ValorReposicionA") = dr(6)
                                drCoste("ValorReposicionB") = dr(6)
                                drCoste("ControlRecepcion") = 0
                                drCoste("GenerarOFArticuloFinal") = False
                                drCoste("TipoFactAlquiler") = 0
                                drCoste("Seguridad") = False
                                drCoste("Reglamentacion") = False
                                drCoste("SeguridadReglamentacion") = False
                                drCoste("DiasMinimosFactAlquiler") = 0
                                drCoste("SinDtoEnAlquiler") = False
                                drCoste("SinSeguroEnAlquiler") = False
                                drCoste("NecesitaOperario") = False
                                drCoste("FacturacionAsociadaMaq") = False
                                drCoste("FactTasaResiduos") = False
                                drCoste("NoImprimirEnFactura") = False
                                drCoste("RetencionIRPF") = True
                                drCoste("IncluirEnEMCS") = False

                                dtCoste.Rows.Add(drCoste)
                                control = control + 1
                            End If
                        End If
                    Next

                    Grid1.DataSource = dtCoste

                    For Each drInsert As DataRow In dtCoste.Rows

                        Dim clsCE As New Articulo
                        Dim dtCE As DataTable = clsCE.AddNewForm
                        dtCE.Rows(0)("IDArticulo") = drInsert("IDArticulo")
                        dtCE.Rows(0)("DescArticulo") = drInsert("DescArticulo")
                        dtCE.Rows(0)("IDEstado") = drInsert("IDEstado")
                        dtCE.Rows(0)("IDTipo") = drInsert("IDTipo")
                        dtCE.Rows(0)("IDFamilia") = drInsert("IDFamilia")
                        dtCE.Rows(0)("IDSubFamilia") = drInsert("IDSubFamilia")
                        dtCE.Rows(0)("IDUdInterna") = drInsert("IDUdInterna")
                        dtCE.Rows(0)("IDUdCompra") = drInsert("IDUdCompra")
                        dtCE.Rows(0)("IDUdVenta") = drInsert("IDUdVenta")
                        dtCE.Rows(0)("PrecioEstandarA") = drInsert("PrecioEstandarA")
                        dtCE.Rows(0)("PrecioEstandarB") = drInsert("PrecioEstandarB")
                        dtCE.Rows(0)("UdValoracion") = drInsert("UdValoracion")
                        dtCE.Rows(0)("PesoNeto") = drInsert("PesoNeto")
                        dtCE.Rows(0)("PesoBruto") = drInsert("PesoBruto")
                        dtCE.Rows(0)("TipoEstructura") = drInsert("TipoEstructura")
                        dtCE.Rows(0)("TipoRuta") = drInsert("TipoRuta")
                        dtCE.Rows(0)("PuntoVerde") = drInsert("PuntoVerde")
                        dtCE.Rows(0)("PVPMinimo") = drInsert("PVPMinimo")
                        dtCE.Rows(0)("PorcentajeRechazo") = drInsert("PorcentajeRechazo")
                        dtCE.Rows(0)("Plazo") = drInsert("Plazo")
                        dtCE.Rows(0)("Volumen") = drInsert("Volumen")
                        dtCE.Rows(0)("RecalcularValoracion") = drInsert("RecalcularValoracion")
                        dtCE.Rows(0)("CriterioValoracion") = drInsert("CriterioValoracion")
                        dtCE.Rows(0)("GestionStockPorLotes") = drInsert("GestionStockPorLotes")
                        dtCE.Rows(0)("PrecioUltimaCompraA") = drInsert("PrecioUltimaCompraA")
                        dtCE.Rows(0)("PrecioUltimaCompraB") = drInsert("PrecioUltimaCompraB")
                        dtCE.Rows(0)("LoteMultiplo") = drInsert("LoteMultiplo")
                        dtCE.Rows(0)("CantMinSolicitud") = drInsert("CantMinSolicitud")
                        dtCE.Rows(0)("CantMaxSolicitud") = drInsert("CantMaxSolicitud")
                        dtCE.Rows(0)("LimitarPetDia") = drInsert("LimitarPetDia")
                        dtCE.Rows(0)("PrecioBase") = drInsert("PrecioBase")
                        dtCE.Rows(0)("Configurable") = drInsert("Configurable")
                        dtCE.Rows(0)("StockNegativo") = drInsert("StockNegativo")
                        dtCE.Rows(0)("PlazoFabricacion") = drInsert("PlazoFabricacion")
                        dtCE.Rows(0)("CapacidadDiaria") = drInsert("CapacidadDiaria")
                        dtCE.Rows(0)("AplicarLoteMRP") = drInsert("AplicarLoteMRP")
                        dtCE.Rows(0)("NSerieObligatorio") = drInsert("NSerieObligatorio")
                        dtCE.Rows(0)("PuntosMarketing") = drInsert("PuntosMarketing")
                        dtCE.Rows(0)("ValorReposicionA") = drInsert("ValorReposicionA")
                        dtCE.Rows(0)("ValorReposicionB") = drInsert("ValorReposicionB")
                        dtCE.Rows(0)("ControlRecepcion") = drInsert("ControlRecepcion")
                        dtCE.Rows(0)("GenerarOFArticuloFinal") = drInsert("GenerarOFArticuloFinal")
                        dtCE.Rows(0)("TipoFactAlquiler") = drInsert("TipoFactAlquiler")
                        dtCE.Rows(0)("Seguridad") = drInsert("Seguridad")
                        dtCE.Rows(0)("Reglamentacion") = drInsert("Reglamentacion")
                        dtCE.Rows(0)("SeguridadReglamentacion") = drInsert("SeguridadReglamentacion")
                        dtCE.Rows(0)("DiasMinimosFactAlquiler") = drInsert("DiasMinimosFactAlquiler")
                        dtCE.Rows(0)("SinDtoEnAlquiler") = drInsert("SinDtoEnAlquiler")
                        dtCE.Rows(0)("SinSeguroEnAlquiler") = drInsert("SinSeguroEnAlquiler")
                        dtCE.Rows(0)("NecesitaOperario") = drInsert("NecesitaOperario")
                        dtCE.Rows(0)("FacturacionAsociadaMaq") = drInsert("FacturacionAsociadaMaq")
                        dtCE.Rows(0)("FactTasaResiduos") = drInsert("FactTasaResiduos")
                        dtCE.Rows(0)("NoImprimirEnFactura") = drInsert("NoImprimirEnFactura")
                        dtCE.Rows(0)("RetencionIRPF") = drInsert("RetencionIRPF")
                        dtCE.Rows(0)("IncluirEnEMCS") = drInsert("IncluirEnEMCS")

                        Try
                            clsCE.Update(dtCE)
                        Catch ex As Exception

                        End Try

                    Next
                Catch ex As Exception
                    MessageBox.Show("No hay más datos que añadir. ")
                    Me.Close()
                End Try
                ExpertisApp.GenerateMessage("Se han insertado las lineas correctamente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End With
    End Sub

    Private Sub bActualizarStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bActualizarStock.Click
        MessageBox.Show("Solo modifica 200 articulos. ")
        Dim ruta As String
        Dim hoja As String = "Hoja1"
        Dim rango As String = "A1:C200"
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
                    Dim aux As New Solmicro.Expertis.Business.ClasesTecozam.MetodosAuxiliares

                    Dim IDArticulo As String

                    Dim sql As String
                    For Each dr As DataRow In dt.Rows
                        IDArticulo = dr(0)
                        If IDArticulo.ToString.Length = 0 Then
                            Exit For
                        End If
                        sql = " UPDATE tbMaestroArticulo "
                        sql &= "SET StockMinimo ='" & dr("StockMinimo") & "', StockMaximo ='" & dr("StockMaximo") & "'"
                        sql &= " WHERE IDArticulo = '" & dr("IDArticulo") & "'"

                        aux.EjecutarSql(sql)
                    Next
                Catch
                End Try
            End If
            MsgBox("Stocks actualizados")
        End With
    End Sub

    Private Sub bAlias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAlias.Click

        Dim ruta As String
        Dim hoja As String = "Hoja1"
        Dim rango As String = "A1:B1000"
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
                    Dim aux As New Solmicro.Expertis.Business.ClasesTecozam.MetodosAuxiliares

                    Dim IDArticulo As String

                    Dim sql As String
                    For Each dr As DataRow In dt.Rows
                        IDArticulo = dr(0)
                        If IDArticulo.ToString.Length = 0 Then
                            Exit For
                        End If
                        sql = "UPDATE tbMaestroArticulo "
                        sql &= "SET Alias ='" & dr("ALIAS").ToString & "'"
                        sql &= " WHERE IDArticulo = '" & dr("IDARTICULO").ToString & "'"

                        aux.EjecutarSql(sql)
                    Next
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
            MsgBox("Stocks actualizados")
        End With
    End Sub
End Class
