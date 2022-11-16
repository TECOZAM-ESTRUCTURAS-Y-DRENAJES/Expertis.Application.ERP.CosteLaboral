<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CosteLabOperarioMes
    Inherits Solmicro.Expertis.Engine.UI.FormBase

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim cbxAnio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CosteLabOperarioMes))
        Dim cbxMes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.btnCalcular = New Solmicro.Expertis.Engine.UI.Button
        Me.cbxAnio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.cbxMes = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.Panel2 = New Solmicro.Expertis.Engine.UI.Panel
        Me.GridCoste = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1.suspendlayout()
        CType(Me.cbxAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxMes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.suspendlayout()
        CType(Me.GridCoste, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnCalcular)
        Me.Panel1.Controls.Add(Me.cbxAnio)
        Me.Panel1.Controls.Add(Me.cbxMes)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(904, 88)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(181, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Año"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Mes"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(356, 27)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(229, 23)
        Me.btnCalcular.TabIndex = 2
        Me.btnCalcular.Text = "Calcular Euro / Hora Operario"
        '
        'cbxAnio
        '
        cbxAnio_DesignTimeLayout.LayoutString = resources.GetString("cbxAnio_DesignTimeLayout.LayoutString")
        Me.cbxAnio.DesignTimeLayout = cbxAnio_DesignTimeLayout
        Me.cbxAnio.DisabledBackColor = System.Drawing.Color.White
        Me.cbxAnio.Location = New System.Drawing.Point(231, 30)
        Me.cbxAnio.Name = "cbxAnio"
        Me.cbxAnio.SelectedIndex = -1
        Me.cbxAnio.SelectedItem = Nothing
        Me.cbxAnio.Size = New System.Drawing.Size(100, 21)
        Me.cbxAnio.TabIndex = 1
        '
        'cbxMes
        '
        cbxMes_DesignTimeLayout.LayoutString = resources.GetString("cbxMes_DesignTimeLayout.LayoutString")
        Me.cbxMes.DesignTimeLayout = cbxMes_DesignTimeLayout
        Me.cbxMes.DisabledBackColor = System.Drawing.Color.White
        Me.cbxMes.Location = New System.Drawing.Point(47, 30)
        Me.cbxMes.Name = "cbxMes"
        Me.cbxMes.SelectedIndex = -1
        Me.cbxMes.SelectedItem = Nothing
        Me.cbxMes.Size = New System.Drawing.Size(100, 21)
        Me.cbxMes.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GridCoste)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(904, 421)
        Me.Panel2.TabIndex = 1
        '
        'GridCoste
        '
        Me.GridCoste.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCoste.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridCoste.EntityName = Nothing
        Me.GridCoste.Location = New System.Drawing.Point(0, 0)
        Me.GridCoste.Name = "GridCoste"
        Me.GridCoste.PrimaryDataFields = Nothing
        Me.GridCoste.SecondaryDataFields = Nothing
        Me.GridCoste.Size = New System.Drawing.Size(904, 421)
        Me.GridCoste.TabIndex = 0
        Me.GridCoste.ViewName = Nothing
        '
        'CosteLabOperarioMes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 509)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CosteLabOperarioMes"
        Me.Text = "CosteLabOperarioMes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cbxAnio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxMes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GridCoste, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cbxMes As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents Panel2 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents GridCoste As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents btnCalcular As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cbxAnio As Solmicro.Expertis.Engine.UI.ComboBox
End Class
