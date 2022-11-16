Imports System.Data.OleDb
Imports Microsoft.Office
Imports Microsoft.Office.Interop
Imports Solmicro.Expertis.Business.ClasesTecozam
Imports Solmicro.Expertis.Business.Negocio
Imports Solmicro.Expertis.Engine.UI
Imports Solmicro.Expertis.Engine
Imports Solmicro.Expertis
Imports Solmicro.Expertis.Engine.BE.BusinessProcesses
Imports Solmicro.Expertis.Engine.BE

Public Class ImportarArticulado

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
       
    End Sub

    Private Sub ImportarExcel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cargarComboMes()
        'cargarComboAnio()
        Grid1.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False
    End Sub

    Private Sub btnImportar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
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
                    'Meto IDUdVenta y IDUDCompra
                    dtCoste.Columns.Add("IDUdVenta")
                    dtCoste.Columns.Add("IDUdCompra")



                    hoja = "Hoja1"
                    rango = "A1:H500"
                    '    Select Case contador
                    '        Case 0
                    '            'hoja = "FAMILIA 020101"
                    '            'rango = "B2:I944"
                    '            'Cargo de 500 en 500
                    '            hoja = "Hoja1"
                    '            rango = "A1:H500"
                    '        Case 1
                    '            hoja = "FAMILIA 020102"
                    '            rango = "B2:I367"
                    '        Case 2
                    '            hoja = "FAMILIA 020103"
                    '            rango = "B2:I42"
                    '        Case 3
                    '            hoja = "FAMILIA 020104"
                    '            rango = "B2:I94"
                    '        Case 4
                    '            hoja = "FAMILIA 020105"
                    '            rango = "B2:I22"
                    '        Case 5
                    '            hoja = "FAMILIA 020106"
                    '            rango = "B2:I46"
                    '        Case 6
                    '            hoja = "FAMILIA 020107"
                    '            rango = "B2:I29"
                    '        Case 7
                    '            hoja = "FAMILIA 020108"
                    '            rango = "B2:I432"
                    '        Case 8
                    '            hoja = "FAMILIA 020109"
                    '            rango = "B2:I16"
                    '        Case 9
                    '            hoja = "FAMILIA 020110"
                    '            rango = "B2:I42"
                    '        Case 10
                    '            hoja = "FAMILIA 020111"
                    '            rango = "B2:I59"
                    '        Case 11
                    '            hoja = "FAMILIA 020112"
                    '            rango = "B2:I17"
                    '        Case 12
                    '            hoja = "FAMILIA 020113"
                    '            rango = "B2:I69"
                    '        Case 13
                    '            hoja = "FAMILIA 020114"
                    '            rango = "B2:I32"
                    '        Case 14
                    '            hoja = "FAMILIA 020115"
                    '            rango = "B2:I20"
                    '        Case 15
                    '            hoja = "FAMILIA 020116"
                    '            rango = "B2:I141"
                    '        Case 16
                    '            hoja = "FAMILIA 020117"
                    '            rango = "B2:I7"
                    '        Case 17
                    '            hoja = "FAMILIA 020118"
                    '            rango = "B2:I6"
                    '        Case 18
                    '            hoja = "FAMILIA 020119"
                    '            rango = "B2:I40"
                    '        Case 19
                    '            hoja = "FAMILIA 020120"
                    '            rango = "B2:I44"
                    '        Case 20
                    '            hoja = "FAMILIA 020121"
                    '            rango = "B2:I22"
                    '        Case 21
                    '            hoja = "FAMILIA 020122"
                    '            rango = "B2:I39"
                    '        Case 22
                    '            hoja = "FAMILIA 020201"
                    '            rango = "B2:I31"
                    '        Case 23
                    '            hoja = "FAMILIA 020202"
                    '            rango = "B2:I11"
                    '        Case 24
                    '            hoja = "FAMILIA 020203"
                    '            rango = "B2:I14"
                    '        Case 25
                    '            hoja = "FAMILIA 020204"
                    '            rango = "B2:I17"
                    '        Case 26
                    '            hoja = "FAMILIA 0210-0310"
                    '            rango = "B2:I390"
                    '        Case 27
                    '            hoja = "FAMILIA 0209-0311"
                    '            rango = "B2:I92"
                    '        Case 28
                    '            hoja = "FAMILIA 0211-0312"
                    '            rango = "B2:I52"
                    '        Case 29
                    '            hoja = "FAMILIA 0212-0313"
                    '            rango = "B2:I31"
                    '        Case 30
                    '            hoja = "FAMILIA 0213-0314"
                    '            rango = "B2:I36"
                    '        Case 31
                    '            hoja = "FAMILIA 0214-0315"
                    '            rango = "B2:I25"
                    '        Case 32
                    '            hoja = "FAMILIA 0215-0316"
                    '            rango = "B2:I49"
                    '        Case 33
                    '            hoja = "FAMILIA 0216-0317"
                    '            rango = "B2:I63"
                    '        Case 34
                    '            hoja = "FAMILIA 0217-0318"
                    '            rango = "B2:I16"
                    '        Case 35
                    '            hoja = "FAMILIA 0218-0319"
                    '            rango = "B2:I202"
                    '        Case 36
                    '            hoja = "FAMILIA 0219-0320"
                    '            rango = "B2:I128"
                    '        Case 37
                    '            hoja = "FAMILIA 0220-0321"
                    '            rango = "B2:I101"
                    '        Case 38
                    '            hoja = "FAMILIA 0221-0322"
                    '            rango = "B2:I197"
                    '        Case 39
                    '            hoja = "FAMILIA 0222-0323"
                    '            rango = "B2:I45"
                    '        Case 40
                    '            hoja = "FAMILIA 0223-0324"
                    '            rango = "B2:I79"
                    '        Case 41
                    '            hoja = "FAMILIA 0224-0325"
                    '            rango = "B2:I71"
                    '        Case 42
                    '            hoja = "FAMILIA 0225-0326"
                    '            rango = "B2:I158"
                    '        Case 43
                    '            hoja = "FAMILIA 0226-0327"
                    '            rango = "B2:I9"
                    '        Case 44
                    '            hoja = "FAMILIA 0227-0328"
                    '            rango = "B2:I299"

                    '    End Select


                    Dim dt As DataTable = ObtenerDatosExcel(ruta, hoja, rango)
                    MessageBox.Show("El excel tiene " & (dt.Rows.Count) & " filas.")

                    'DTGCoste.DataSource = dt
                    'For Each dr As DataRow In dt.Rows
                    '    'MessageBox.Show(dr(0) & " , " & dr(1) & " , " & dr(3))

                    'Next

                    'Grid1.SetDataBinding(dt, "")
                    'Grid1.RetrieveStructure()
                    'Grid1.RootTable.Columns.Add("Mes")
                    'Grid1.RootTable.Columns.Add("Año")
                    'Grid1.DataSource = dt

                    Dim drCoste As DataRow
                    Grid1.SetDataBinding(dtCoste, "")
                    Grid1.RetrieveStructure()

                    For Each dr As DataRow In dt.Rows
                        'MessageBox.Show(dr(0) & " , " & dr(2) & " , " & dr(7))
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

                        'Grid1.InvokeBusinessRules("mes", drInsert("mes"), Grid1.GetValue("IDCosteEmpresa"))
                        'Dim data As New DataCrearCosteEmpresa

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


                        'David. Actualización del stock en el 011tbMaestroArticuloAlmacen
                        'Dim AA As New ArticuloAlmacen
                        'AA.ActualizaStock(drInsert("StockFisico"), drInsert("IDArticulo"))

                        'Mes	Anio	Nif	CosteEmpresa
                        'data.mes = drInsert("mes")
                        'data.anio = drInsert("anio")
                        'data.nif = drInsert("nif")
                        'data.costeEmpresa = drInsert("CosteEmpresa")
                        'drInsert=clsCE.ApplyBusinessRule("mes",drInsert("IDCosteEmpresa",

                        'ExpertisApp.GenerateMessage(data.mes & " - " & drInsert("anio") & " - " & drInsert("nif") & " - " & drInsert("CosteEmpresa"))
                        'ExpertisApp.ExecuteTask(Of DataCrearCosteEmpresa)(AddressOf CosteEmpresa.CrearCosteEmpresa, data)

                        'dt.Clear()
                        'dtCoste.Clear()
                    Next
                Catch ex As Exception
                    'MessageBox.Show("la linea de fallo es: " & control)
                    ' Se ha producido un error
                    MessageBox.Show("No hay más datos que añadir. ")
                    Me.Close()
                End Try
                ExpertisApp.GenerateMessage("Se han insertado las lineas correctamente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End With
    End Sub
End Class



