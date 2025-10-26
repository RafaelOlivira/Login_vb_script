<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gerenciar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.senha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_exibir = New System.Windows.Forms.Button()
        Me.txt_nome_completo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_bloquear = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_status = New System.Windows.Forms.TextBox()
        Me.btn_desbloquear = New System.Windows.Forms.Button()
        Me.btn_deletar = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.btn_alterar = New System.Windows.Forms.Button()
        Me.CheckBox_campos = New System.Windows.Forms.CheckBox()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_dados
        '
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nome, Me.email, Me.usuario, Me.senha, Me.cpf, Me.status})
        Me.dgv_dados.Location = New System.Drawing.Point(78, 83)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.Size = New System.Drawing.Size(635, 302)
        Me.dgv_dados.TabIndex = 0
        '
        'nome
        '
        Me.nome.HeaderText = "Nome"
        Me.nome.Name = "nome"
        '
        'email
        '
        Me.email.HeaderText = "Email"
        Me.email.Name = "email"
        '
        'usuario
        '
        Me.usuario.HeaderText = "Usuário"
        Me.usuario.Name = "usuario"
        '
        'senha
        '
        Me.senha.HeaderText = "Senha"
        Me.senha.Name = "senha"
        '
        'cpf
        '
        Me.cpf.HeaderText = "CPF"
        Me.cpf.Name = "cpf"
        '
        'status
        '
        Me.status.HeaderText = "status"
        Me.status.Name = "status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(310, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Gerenciar usuários"
        '
        'btn_exibir
        '
        Me.btn_exibir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exibir.Location = New System.Drawing.Point(78, 401)
        Me.btn_exibir.Name = "btn_exibir"
        Me.btn_exibir.Size = New System.Drawing.Size(128, 34)
        Me.btn_exibir.TabIndex = 2
        Me.btn_exibir.Text = "EXIBIR"
        Me.btn_exibir.UseVisualStyleBackColor = True
        '
        'txt_nome_completo
        '
        Me.txt_nome_completo.Enabled = False
        Me.txt_nome_completo.Location = New System.Drawing.Point(744, 162)
        Me.txt_nome_completo.Name = "txt_nome_completo"
        Me.txt_nome_completo.Size = New System.Drawing.Size(304, 20)
        Me.txt_nome_completo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(741, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nome completo:"
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(1076, 162)
        Me.txt_cpf.Mask = "000.000.000-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(107, 20)
        Me.txt_cpf.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1073, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "BUSCAR POR CPF:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(741, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Email:"
        '
        'txt_email
        '
        Me.txt_email.Enabled = False
        Me.txt_email.Location = New System.Drawing.Point(744, 223)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(304, 20)
        Me.txt_email.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(741, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Usuário:"
        '
        'txt_usuario
        '
        Me.txt_usuario.Enabled = False
        Me.txt_usuario.Location = New System.Drawing.Point(744, 291)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(164, 20)
        Me.txt_usuario.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(741, 322)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Senha:"
        '
        'txt_senha
        '
        Me.txt_senha.Enabled = False
        Me.txt_senha.Location = New System.Drawing.Point(744, 343)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(164, 20)
        Me.txt_senha.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1189, 162)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 26)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "BUSCAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_bloquear
        '
        Me.btn_bloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_bloquear.Location = New System.Drawing.Point(744, 381)
        Me.btn_bloquear.Name = "btn_bloquear"
        Me.btn_bloquear.Size = New System.Drawing.Size(128, 34)
        Me.btn_bloquear.TabIndex = 15
        Me.btn_bloquear.Text = "BLOQUEAR"
        Me.btn_bloquear.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(995, 322)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "STATUS:"
        '
        'txt_status
        '
        Me.txt_status.Enabled = False
        Me.txt_status.Location = New System.Drawing.Point(999, 345)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(93, 20)
        Me.txt_status.TabIndex = 17
        '
        'btn_desbloquear
        '
        Me.btn_desbloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_desbloquear.Location = New System.Drawing.Point(878, 381)
        Me.btn_desbloquear.Name = "btn_desbloquear"
        Me.btn_desbloquear.Size = New System.Drawing.Size(128, 34)
        Me.btn_desbloquear.TabIndex = 18
        Me.btn_desbloquear.Text = "DESBLOQUEAR"
        Me.btn_desbloquear.UseVisualStyleBackColor = True
        '
        'btn_deletar
        '
        Me.btn_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deletar.Location = New System.Drawing.Point(1012, 381)
        Me.btn_deletar.Name = "btn_deletar"
        Me.btn_deletar.Size = New System.Drawing.Size(128, 34)
        Me.btn_deletar.TabIndex = 19
        Me.btn_deletar.Text = "DELETAR"
        Me.btn_deletar.UseVisualStyleBackColor = True
        '
        'btn_sair
        '
        Me.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sair.Location = New System.Drawing.Point(1146, 535)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(128, 34)
        Me.btn_sair.TabIndex = 20
        Me.btn_sair.Text = "SAIR"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'btn_alterar
        '
        Me.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_alterar.Location = New System.Drawing.Point(1146, 381)
        Me.btn_alterar.Name = "btn_alterar"
        Me.btn_alterar.Size = New System.Drawing.Size(128, 34)
        Me.btn_alterar.TabIndex = 21
        Me.btn_alterar.Text = "ALTERAR"
        Me.btn_alterar.UseVisualStyleBackColor = True
        '
        'CheckBox_campos
        '
        Me.CheckBox_campos.AutoSize = True
        Me.CheckBox_campos.Location = New System.Drawing.Point(1059, 226)
        Me.CheckBox_campos.Name = "CheckBox_campos"
        Me.CheckBox_campos.Size = New System.Drawing.Size(64, 17)
        Me.CheckBox_campos.TabIndex = 22
        Me.CheckBox_campos.Text = "Campos"
        Me.CheckBox_campos.UseVisualStyleBackColor = True
        '
        'gerenciar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1301, 597)
        Me.Controls.Add(Me.CheckBox_campos)
        Me.Controls.Add(Me.btn_alterar)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.btn_deletar)
        Me.Controls.Add(Me.btn_desbloquear)
        Me.Controls.Add(Me.txt_status)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_bloquear)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nome_completo)
        Me.Controls.Add(Me.btn_exibir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_dados)
        Me.Name = "gerenciar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciar Usuários"
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents usuario As DataGridViewTextBoxColumn
    Friend WithEvents senha As DataGridViewTextBoxColumn
    Friend WithEvents cpf As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_exibir As Button
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents txt_nome_completo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_bloquear As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_status As TextBox
    Friend WithEvents btn_desbloquear As Button
    Friend WithEvents btn_deletar As Button
    Friend WithEvents btn_sair As Button
    Friend WithEvents btn_alterar As Button
    Friend WithEvents CheckBox_campos As CheckBox
End Class
