<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDatos
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
        Dim cbxMes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDatos))
        Dim cbxAnio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.cbxMes = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.cbxAnio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label3 = New Solmicro.Expertis.Engine.UI.Label
        Me.btnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.btnCancelar = New Solmicro.Expertis.Engine.UI.Button
        CType(Me.cbxMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxMes
        '
        cbxMes_DesignTimeLayout.LayoutString = resources.GetString("cbxMes_DesignTimeLayout.LayoutString")
        Me.cbxMes.DesignTimeLayout = cbxMes_DesignTimeLayout
        Me.cbxMes.DisabledBackColor = System.Drawing.Color.White
        Me.cbxMes.Location = New System.Drawing.Point(237, 50)
        Me.cbxMes.Name = "cbxMes"
        Me.cbxMes.SelectedIndex = -1
        Me.cbxMes.SelectedItem = Nothing
        Me.cbxMes.Size = New System.Drawing.Size(100, 21)
        Me.cbxMes.TabIndex = 0
        '
        'cbxAnio
        '
        cbxAnio_DesignTimeLayout.LayoutString = resources.GetString("cbxAnio_DesignTimeLayout.LayoutString")
        Me.cbxAnio.DesignTimeLayout = cbxAnio_DesignTimeLayout
        Me.cbxAnio.DisabledBackColor = System.Drawing.Color.White
        Me.cbxAnio.Location = New System.Drawing.Point(237, 88)
        Me.cbxAnio.Name = "cbxAnio"
        Me.cbxAnio.SelectedIndex = -1
        Me.cbxAnio.SelectedItem = Nothing
        Me.cbxAnio.Size = New System.Drawing.Size(100, 21)
        Me.cbxAnio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(111, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mes Producción"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(111, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Año Producción"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(432, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "SELECCIONE DATOS PARA OBTENER EL RESUMEN DE COSTES POR OBRA"
        '
        'btnAceptar
        '
        Me.btnAceptar.Icon = CType(resources.GetObject("btnAceptar.Icon"), System.Drawing.Icon)
        Me.btnAceptar.Location = New System.Drawing.Point(114, 142)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(100, 23)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Icon = CType(resources.GetObject("btnCancelar.Icon"), System.Drawing.Icon)
        Me.btnCancelar.Location = New System.Drawing.Point(237, 142)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 23)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        '
        'FrmDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 186)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxAnio)
        Me.Controls.Add(Me.cbxMes)
        Me.Name = "FrmDatos"
        Me.Text = "FrmDatos"
        CType(Me.cbxMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxAnio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxMes As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents cbxAnio As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents btnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents btnCancelar As Solmicro.Expertis.Engine.UI.Button
End Class
