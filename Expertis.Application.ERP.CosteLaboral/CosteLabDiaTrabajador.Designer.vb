<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CosteLabDiaTrabajador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CosteLabDiaTrabajador))
        Me.advIDOperario = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDOperario = New Solmicro.Expertis.Engine.UI.Label
        Me.advnobra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblnobra = New Solmicro.Expertis.Engine.UI.Label
        Me.clbFechaInicioMin = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaInicio = New Solmicro.Expertis.Engine.UI.Label
        Me.clbFechaInicioMax = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.advidoficio = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblidoficio = New Solmicro.Expertis.Engine.UI.Label
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.advidoficio)
        Me.FilterPanel.Controls.Add(Me.lblidoficio)
        Me.FilterPanel.Controls.Add(Me.clbFechaInicioMax)
        Me.FilterPanel.Controls.Add(Me.Label1)
        Me.FilterPanel.Controls.Add(Me.clbFechaInicioMin)
        Me.FilterPanel.Controls.Add(Me.lblFechaInicio)
        Me.FilterPanel.Controls.Add(Me.advnobra)
        Me.FilterPanel.Controls.Add(Me.lblnobra)
        Me.FilterPanel.Controls.Add(Me.advIDOperario)
        Me.FilterPanel.Controls.Add(Me.lblIDOperario)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 311)
        Me.FilterPanel.Size = New System.Drawing.Size(966, 127)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(966, 311)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Size = New System.Drawing.Size(966, 311)
        Me.Grid.ViewName = "vCosteLabDiaOperarioJP"
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
        Me.MainPanel.Size = New System.Drawing.Size(966, 438)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(966, 438)
        '
        'advIDOperario
        '
        Me.TryDataBinding(advIDOperario, New System.Windows.Forms.Binding("Text", Me, "IDOperario", True))
        Me.advIDOperario.DisabledBackColor = System.Drawing.Color.White
        Me.advIDOperario.DisplayField = "IDOperario"
        Me.advIDOperario.EntityName = "Operario"
        Me.advIDOperario.Location = New System.Drawing.Point(82, 20)
        Me.advIDOperario.Name = "advIDOperario"
        Me.advIDOperario.Size = New System.Drawing.Size(121, 23)
        Me.advIDOperario.TabIndex = 0
        Me.advIDOperario.ViewName = "vMaestroOperarioCompleta"
        '
        'lblIDOperario
        '
        Me.lblIDOperario.Location = New System.Drawing.Point(6, 25)
        Me.lblIDOperario.Name = "lblIDOperario"
        Me.lblIDOperario.Size = New System.Drawing.Size(57, 13)
        Me.lblIDOperario.TabIndex = 1
        Me.lblIDOperario.Text = "Operario"
        '
        'advnobra
        '
        Me.TryDataBinding(advnobra, New System.Windows.Forms.Binding("Text", Me, "nobra", True))
        Me.advnobra.DisabledBackColor = System.Drawing.Color.White
        Me.advnobra.DisplayField = "NObra"
        Me.advnobra.EntityName = "ObraCabecera"
        Me.advnobra.Location = New System.Drawing.Point(82, 49)
        Me.advnobra.Name = "advnobra"
        Me.advnobra.Size = New System.Drawing.Size(121, 23)
        Me.advnobra.TabIndex = 2
        Me.advnobra.ViewName = "tbObraCabecera"
        '
        'lblnobra
        '
        Me.lblnobra.Location = New System.Drawing.Point(6, 54)
        Me.lblnobra.Name = "lblnobra"
        Me.lblnobra.Size = New System.Drawing.Size(35, 13)
        Me.lblnobra.TabIndex = 3
        Me.lblnobra.Text = "Obra"
        '
        'clbFechaInicioMin
        '
        Me.TryDataBinding(clbFechaInicioMin, New System.Windows.Forms.Binding("BindableValue", Me, "FechaInicio", True))
        Me.clbFechaInicioMin.DisabledBackColor = System.Drawing.Color.White
        Me.clbFechaInicioMin.Location = New System.Drawing.Point(82, 78)
        Me.clbFechaInicioMin.Name = "clbFechaInicioMin"
        Me.clbFechaInicioMin.Size = New System.Drawing.Size(121, 21)
        Me.clbFechaInicioMin.TabIndex = 4
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.Location = New System.Drawing.Point(6, 82)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(62, 13)
        Me.lblFechaInicio.TabIndex = 5
        Me.lblFechaInicio.Text = "Fecha >="
        '
        'clbFechaInicioMax
        '
        Me.clbFechaInicioMax.DisabledBackColor = System.Drawing.Color.White
        Me.clbFechaInicioMax.Location = New System.Drawing.Point(82, 103)
        Me.clbFechaInicioMax.Name = "clbFechaInicioMax"
        Me.clbFechaInicioMax.Size = New System.Drawing.Size(121, 21)
        Me.clbFechaInicioMax.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fecha <="
        '
        'advidoficio
        '
        Me.TryDataBinding(advidoficio, New System.Windows.Forms.Binding("Text", Me, "idoficio", True))
        Me.advidoficio.DisabledBackColor = System.Drawing.Color.White
        Me.advidoficio.DisplayField = "IDOficio"
        Me.advidoficio.EntityName = "Oficio"
        Me.advidoficio.Location = New System.Drawing.Point(273, 20)
        Me.advidoficio.Name = "advidoficio"
        Me.advidoficio.Size = New System.Drawing.Size(121, 23)
        Me.advidoficio.TabIndex = 8
        Me.advidoficio.ViewName = "tbMaestroOficio"
        '
        'lblidoficio
        '
        Me.lblidoficio.Location = New System.Drawing.Point(221, 25)
        Me.lblidoficio.Name = "lblidoficio"
        Me.lblidoficio.Size = New System.Drawing.Size(39, 13)
        Me.lblidoficio.TabIndex = 9
        Me.lblidoficio.Text = "Oficio"
        '
        'CosteLabDiaTrabajador
        '
        Me.ClientSize = New System.Drawing.Size(974, 526)
        Me.Name = "CosteLabDiaTrabajador"
        Me.ViewName = "vCosteLabDiaOperarioJP"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents advIDOperario As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblIDOperario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents clbFechaInicioMax As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents clbFechaInicioMin As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaInicio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advnobra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblnobra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advidoficio As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblidoficio As Solmicro.Expertis.Engine.UI.Label

End Class
