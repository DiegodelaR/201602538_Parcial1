<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbPetén = New System.Windows.Forms.CheckBox()
        Me.cbIzabal = New System.Windows.Forms.CheckBox()
        Me.cbCostaSur = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbHelicóptero = New System.Windows.Forms.RadioButton()
        Me.rbJet = New System.Windows.Forms.RadioButton()
        Me.rbAvioneta = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de Aeronave"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt4)
        Me.GroupBox1.Controls.Add(Me.txt3)
        Me.GroupBox1.Controls.Add(Me.txt2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnCalcular)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.txt1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbPetén)
        Me.GroupBox1.Controls.Add(Me.cbIzabal)
        Me.GroupBox1.Controls.Add(Me.cbCostaSur)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.rbHelicóptero)
        Me.GroupBox1.Controls.Add(Me.rbJet)
        Me.GroupBox1.Controls.Add(Me.rbAvioneta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 388)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vuelos"
        '
        'txt4
        '
        Me.txt4.Location = New System.Drawing.Point(368, 311)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(100, 22)
        Me.txt4.TabIndex = 18
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(368, 257)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(100, 22)
        Me.txt3.TabIndex = 17
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(368, 207)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(100, 22)
        Me.txt2.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(236, 313)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(236, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Descuentos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(236, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Sub Total"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(300, 130)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(88, 33)
        Me.btnCalcular.TabIndex = 12
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(205, 130)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(78, 33)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(413, 130)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(79, 33)
        Me.btnLimpiar.TabIndex = 10
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(288, 72)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(100, 22)
        Me.txt1.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(263, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cantidad de pasajeros"
        '
        'cbPetén
        '
        Me.cbPetén.AutoSize = True
        Me.cbPetén.Location = New System.Drawing.Point(10, 313)
        Me.cbPetén.Name = "cbPetén"
        Me.cbPetén.Size = New System.Drawing.Size(69, 20)
        Me.cbPetén.TabIndex = 7
        Me.cbPetén.Text = "Petén"
        Me.cbPetén.UseVisualStyleBackColor = True
        '
        'cbIzabal
        '
        Me.cbIzabal.AutoSize = True
        Me.cbIzabal.Location = New System.Drawing.Point(10, 271)
        Me.cbIzabal.Name = "cbIzabal"
        Me.cbIzabal.Size = New System.Drawing.Size(71, 20)
        Me.cbIzabal.TabIndex = 6
        Me.cbIzabal.Text = "Izabal"
        Me.cbIzabal.UseVisualStyleBackColor = True
        '
        'cbCostaSur
        '
        Me.cbCostaSur.AutoSize = True
        Me.cbCostaSur.Location = New System.Drawing.Point(10, 227)
        Me.cbCostaSur.Name = "cbCostaSur"
        Me.cbCostaSur.Size = New System.Drawing.Size(96, 20)
        Me.cbCostaSur.TabIndex = 5
        Me.cbCostaSur.Text = "Costa Sur"
        Me.cbCostaSur.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Destino"
        '
        'rbHelicóptero
        '
        Me.rbHelicóptero.AutoSize = True
        Me.rbHelicóptero.Location = New System.Drawing.Point(9, 143)
        Me.rbHelicóptero.Name = "rbHelicóptero"
        Me.rbHelicóptero.Size = New System.Drawing.Size(109, 20)
        Me.rbHelicóptero.TabIndex = 3
        Me.rbHelicóptero.TabStop = True
        Me.rbHelicóptero.Text = "Helicóptero"
        Me.rbHelicóptero.UseVisualStyleBackColor = True
        '
        'rbJet
        '
        Me.rbJet.AutoSize = True
        Me.rbJet.Location = New System.Drawing.Point(9, 99)
        Me.rbJet.Name = "rbJet"
        Me.rbJet.Size = New System.Drawing.Size(49, 20)
        Me.rbJet.TabIndex = 2
        Me.rbJet.TabStop = True
        Me.rbJet.Text = "Jet"
        Me.rbJet.UseVisualStyleBackColor = True
        '
        'rbAvioneta
        '
        Me.rbAvioneta.AutoSize = True
        Me.rbAvioneta.Location = New System.Drawing.Point(9, 58)
        Me.rbAvioneta.Name = "rbAvioneta"
        Me.rbAvioneta.Size = New System.Drawing.Size(89, 20)
        Me.rbAvioneta.TabIndex = 1
        Me.rbAvioneta.TabStop = True
        Me.rbAvioneta.Text = "Avioneta"
        Me.rbAvioneta.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(958, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rbHelicóptero As RadioButton
    Friend WithEvents rbJet As RadioButton
    Friend WithEvents rbAvioneta As RadioButton
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents txt1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbPetén As CheckBox
    Friend WithEvents cbIzabal As CheckBox
    Friend WithEvents cbCostaSur As CheckBox
    Friend WithEvents txt4 As TextBox
    Friend WithEvents txt3 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
