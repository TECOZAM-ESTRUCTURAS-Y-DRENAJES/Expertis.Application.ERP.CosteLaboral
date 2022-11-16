<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CIMntoConsultaCosteEmpresa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIMntoConsultaCosteEmpresa))
        Me.advIDOperario = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDOperario = New Solmicro.Expertis.Engine.UI.Label
        Me.cmbMes = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblMes = New Solmicro.Expertis.Engine.UI.Label
        Me.cmbAnio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblAnio = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDOficio = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDOficio = New Solmicro.Expertis.Engine.UI.Label
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
        Me.FilterPanel.Controls.Add(Me.advIDOficio)
        Me.FilterPanel.Controls.Add(Me.lblIDOficio)
        Me.FilterPanel.Controls.Add(Me.cmbAnio)
        Me.FilterPanel.Controls.Add(Me.lblAnio)
        Me.FilterPanel.Controls.Add(Me.cmbMes)
        Me.FilterPanel.Controls.Add(Me.lblMes)
        Me.FilterPanel.Controls.Add(Me.advIDOperario)
        Me.FilterPanel.Controls.Add(Me.lblIDOperario)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 369)
        Me.FilterPanel.Size = New System.Drawing.Size(1153, 108)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(1153, 369)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Size = New System.Drawing.Size(1153, 369)
        Me.Grid.ViewName = "vCosteEmpresa"
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
        Me.MainPanel.Size = New System.Drawing.Size(1153, 477)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(1153, 477)
        '
        'advIDOperario
        '
        Me.TryDataBinding(advIDOperario, New System.Windows.Forms.Binding("Text", Me, "IDOperario", True))
        Me.advIDOperario.DisabledBackColor = System.Drawing.Color.White
        Me.advIDOperario.DisplayField = "IDOperario"
        Me.advIDOperario.EntityName = "Operario"
        Me.advIDOperario.Location = New System.Drawing.Point(84, 21)
        Me.advIDOperario.Name = "advIDOperario"
        Me.advIDOperario.PrimaryDataFields = "IDOperario"
        Me.advIDOperario.Size = New System.Drawing.Size(121, 23)
        Me.advIDOperario.TabIndex = 0
        Me.advIDOperario.ViewName = "vMaestroOperarioCompleta"
        '
        'lblIDOperario
        '
        Me.lblIDOperario.Location = New System.Drawing.Point(8, 26)
        Me.lblIDOperario.Name = "lblIDOperario"
        Me.lblIDOperario.Size = New System.Drawing.Size(71, 13)
        Me.lblIDOperario.TabIndex = 1
        Me.lblIDOperario.Text = "IDOperario"
        '
        'cmbMes
        '
        Me.TryDataBinding(cmbMes, New System.Windows.Forms.Binding("Value", Me, "Mes", True))
        cmbMes_DesignTimeLayout.LayoutString = resources.GetString("cmbMes_DesignTimeLayout.LayoutString")
        Me.cmbMes.DesignTimeLayout = cmbMes_DesignTimeLayout
        Me.cmbMes.DisabledBackColor = System.Drawing.Color.White
        Me.cmbMes.Location = New System.Drawing.Point(84, 50)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.SelectedIndex = -1
        Me.cmbMes.SelectedItem = Nothing
        Me.cmbMes.Size = New System.Drawing.Size(121, 21)
        Me.cmbMes.TabIndex = 2
        '
        'lblMes
        '
        Me.lblMes.Location = New System.Drawing.Point(50, 54)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(29, 13)
        Me.lblMes.TabIndex = 3
        Me.lblMes.Text = "Mes"
        '
        'cmbAnio
        '
        Me.TryDataBinding(cmbAnio, New System.Windows.Forms.Binding("Value", Me, "Anio", True))
        cmbAnio_DesignTimeLayout.LayoutString = resources.GetString("cmbAnio_DesignTimeLayout.LayoutString")
        Me.cmbAnio.DesignTimeLayout = cmbAnio_DesignTimeLayout
        Me.cmbAnio.DisabledBackColor = System.Drawing.Color.White
        Me.cmbAnio.Location = New System.Drawing.Point(84, 77)
        Me.cmbAnio.Name = "cmbAnio"
        Me.cmbAnio.SelectedIndex = -1
        Me.cmbAnio.SelectedItem = Nothing
        Me.cmbAnio.Size = New System.Drawing.Size(121, 21)
        Me.cmbAnio.TabIndex = 4
        '
        'lblAnio
        '
        Me.lblAnio.Location = New System.Drawing.Point(47, 81)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.Size = New System.Drawing.Size(32, 13)
        Me.lblAnio.TabIndex = 5
        Me.lblAnio.Text = "Anio"
        '
        'advIDOficio
        '
        Me.TryDataBinding(advIDOficio, New System.Windows.Forms.Binding("Text", Me, "IDOficio", True))
        Me.advIDOficio.DisabledBackColor = System.Drawing.Color.White
        Me.advIDOficio.Location = New System.Drawing.Point(295, 21)
        Me.advIDOficio.Name = "advIDOficio"
        Me.advIDOficio.Size = New System.Drawing.Size(121, 23)
        Me.advIDOficio.TabIndex = 6
        '
        'lblIDOficio
        '
        Me.lblIDOficio.Location = New System.Drawing.Point(237, 26)
        Me.lblIDOficio.Name = "lblIDOficio"
        Me.lblIDOficio.Size = New System.Drawing.Size(53, 13)
        Me.lblIDOficio.TabIndex = 7
        Me.lblIDOficio.Text = "IDOficio"
        '
        'CIMntoConsultaCosteEmpresa
        '
        Me.ClientSize = New System.Drawing.Size(1161, 565)
        Me.Name = "CIMntoConsultaCosteEmpresa"
        Me.Text = "Consulta Coste Empresa"
        Me.ViewName = "vCosteEmpresa"
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
    Friend WithEvents advIDOperario As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblIDOperario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDOficio As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblIDOficio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmbAnio As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblAnio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmbMes As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblMes As Solmicro.Expertis.Engine.UI.Label

End Class
