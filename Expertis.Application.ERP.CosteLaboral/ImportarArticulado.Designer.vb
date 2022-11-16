<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportarArticulado
    Inherits Solmicro.Expertis.Engine.UI.SimpleMnto

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
        Me.components = New System.ComponentModel.Container
        Dim Grid1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportarArticulado))
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.btnImportar = New Solmicro.Expertis.Engine.UI.Button
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.TextBox1 = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Panel3 = New Solmicro.Expertis.Engine.UI.Panel
        Me.Grid1 = New Solmicro.Expertis.Engine.UI.Grid
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        Me.Panel1.suspendlayout()
        Me.Panel3.suspendlayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBar
        '
        Me.ToolBar.Size = New System.Drawing.Size(721, 39)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 39)
        Me.MenuBar.Size = New System.Drawing.Size(504, 26)
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.Panel3)
        Me.MainPanel.Controls.Add(Me.Panel1)
        Me.MainPanel.Size = New System.Drawing.Size(947, 487)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnImportar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(947, 106)
        Me.Panel1.TabIndex = 0
        '
        'btnImportar
        '
        Me.btnImportar.Location = New System.Drawing.Point(583, 12)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(117, 23)
        Me.btnImportar.TabIndex = 2
        Me.btnImportar.Text = "Importar Excel"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(19, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ruta"
        '
        'TextBox1
        '
        Me.TextBox1.DisabledBackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(90, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(433, 21)
        Me.TextBox1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Grid1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 106)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(947, 381)
        Me.Panel3.TabIndex = 2
        '
        'Grid1
        '
        Grid1_DesignTimeLayout.LayoutString = resources.GetString("Grid1_DesignTimeLayout.LayoutString")
        Me.Grid1.DesignTimeLayout = Grid1_DesignTimeLayout
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid1.EntityName = "Articulo"
        Me.Grid1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.PrimaryDataFields = "IDArticulo"
        Me.Grid1.SecondaryDataFields = "IDFamilia"
        Me.Grid1.Size = New System.Drawing.Size(947, 381)
        Me.Grid1.TabIndex = 0
        Me.Grid1.ViewName = "tbMaestroArticulo"
        '
        'ImportarArticulado
        '
        Me.ClientSize = New System.Drawing.Size(955, 560)
        Me.EntityName = "Articulo"
        Me.Name = "ImportarArticulado"
        Me.NavigationFields = "IDArticulo"
        Me.ViewName = "tbMaestroArticulo"
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents btnImportar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TextBox1 As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Panel3 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents Grid1 As Solmicro.Expertis.Engine.UI.Grid

End Class
