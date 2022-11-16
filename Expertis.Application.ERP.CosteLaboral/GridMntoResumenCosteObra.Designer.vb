<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GridMntoResumenCosteObra
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cmbMes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cmbAnio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GridMntoResumenCosteObra))
        Me.advidObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblidObra = New Solmicro.Expertis.Engine.UI.Label
        Me.cmbMes = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblMesProd = New Solmicro.Expertis.Engine.UI.Label
        Me.cmbAnio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblAnioProd = New Solmicro.Expertis.Engine.UI.Label
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cmbMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.cmbAnio)
        Me.FilterPanel.Controls.Add(Me.lblAnioProd)
        Me.FilterPanel.Controls.Add(Me.cmbMes)
        Me.FilterPanel.Controls.Add(Me.lblMesProd)
        Me.FilterPanel.Controls.Add(Me.advidObra)
        Me.FilterPanel.Controls.Add(Me.lblidObra)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 333)
        Me.FilterPanel.Size = New System.Drawing.Size(852, 118)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(852, 333)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Size = New System.Drawing.Size(852, 333)
        Me.Grid.ViewName = "vCosteLaboralResumObra"
        '
        'CheckAll
        '
        Me.CheckAll.Icon = CType(resources.GetObject("CheckAll.Icon"), System.Drawing.Icon)
        '
        'UncheckAll
        '
        Me.UncheckAll.Icon = CType(resources.GetObject("UncheckAll.Icon"), System.Drawing.Icon)
        '
        'ExecuteQuery
        '
        Me.ExecuteQuery.Icon = CType(resources.GetObject("ExecuteQuery.Icon"), System.Drawing.Icon)
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Icon = CType(resources.GetObject("ShowAllCheckedItems.Icon"), System.Drawing.Icon)
        '
        'ClearFilter
        '
        Me.ClearFilter.Icon = CType(resources.GetObject("ClearFilter.Icon"), System.Drawing.Icon)
        '
        'Export
        '
        Me.Export.Icon = CType(resources.GetObject("Export.Icon"), System.Drawing.Icon)
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(245, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(852, 451)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Icon = CType(resources.GetObject("ExecuteActions.Icon"), System.Drawing.Icon)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(852, 451)
        '
        'advidObra
        '
        Me.TryDataBinding(advidObra, New System.Windows.Forms.Binding("Text", Me, "idObra", True))
        Me.advidObra.DisabledBackColor = System.Drawing.Color.White
        Me.advidObra.DisplayField = "NObra"
        Me.advidObra.EntityName = "ObraCabecera"
        Me.advidObra.Location = New System.Drawing.Point(138, 22)
        Me.advidObra.Name = "advidObra"
        Me.advidObra.Size = New System.Drawing.Size(121, 23)
        Me.advidObra.TabIndex = 0
        Me.advidObra.ViewName = "tbObraCabecera"
        '
        'lblidObra
        '
        Me.lblidObra.Location = New System.Drawing.Point(6, 27)
        Me.lblidObra.Name = "lblidObra"
        Me.lblidObra.Size = New System.Drawing.Size(35, 13)
        Me.lblidObra.TabIndex = 1
        Me.lblidObra.Text = "Obra"
        '
        'cmbMes
        '
        Me.TryDataBinding(cmbMes, New System.Windows.Forms.Binding("Value", Me, "MesProd", True))
        cmbMes_DesignTimeLayout.LayoutString = resources.GetString("cmbMes_DesignTimeLayout.LayoutString")
        Me.cmbMes.DesignTimeLayout = cmbMes_DesignTimeLayout
        Me.cmbMes.DisabledBackColor = System.Drawing.Color.White
        Me.cmbMes.Location = New System.Drawing.Point(138, 55)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.SelectedIndex = -1
        Me.cmbMes.SelectedItem = Nothing
        Me.cmbMes.Size = New System.Drawing.Size(121, 21)
        Me.cmbMes.TabIndex = 2
        '
        'lblMesProd
        '
        Me.lblMesProd.Location = New System.Drawing.Point(6, 59)
        Me.lblMesProd.Name = "lblMesProd"
        Me.lblMesProd.Size = New System.Drawing.Size(95, 13)
        Me.lblMesProd.TabIndex = 3
        Me.lblMesProd.Text = "Mes Produccion"
        '
        'cmbAnio
        '
        Me.TryDataBinding(cmbAnio, New System.Windows.Forms.Binding("Value", Me, "AnioProd", True))
        cmbAnio_DesignTimeLayout.LayoutString = resources.GetString("cmbAnio_DesignTimeLayout.LayoutString")
        Me.cmbAnio.DesignTimeLayout = cmbAnio_DesignTimeLayout
        Me.cmbAnio.DisabledBackColor = System.Drawing.Color.White
        Me.cmbAnio.Location = New System.Drawing.Point(138, 85)
        Me.cmbAnio.Name = "cmbAnio"
        Me.cmbAnio.SelectedIndex = -1
        Me.cmbAnio.SelectedItem = Nothing
        Me.cmbAnio.Size = New System.Drawing.Size(121, 21)
        Me.cmbAnio.TabIndex = 4
        '
        'lblAnioProd
        '
        Me.lblAnioProd.Location = New System.Drawing.Point(6, 89)
        Me.lblAnioProd.Name = "lblAnioProd"
        Me.lblAnioProd.Size = New System.Drawing.Size(95, 13)
        Me.lblAnioProd.TabIndex = 5
        Me.lblAnioProd.Text = "Año Produccion"
        '
        'GridMntoResumenCosteObra
        '
        Me.ClientSize = New System.Drawing.Size(860, 539)
        Me.Name = "GridMntoResumenCosteObra"
        Me.ViewName = "vCosteLaboralResumObra"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.cmbMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbAnio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbAnio As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblAnioProd As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmbMes As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblMesProd As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advidObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblidObra As Solmicro.Expertis.Engine.UI.Label

End Class
