Public Class login

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Dim super_usuario, senha_admin As String
        super_usuario = "admin"
        senha_admin = "admin123"
        If txt_usuario.Text = super_usuario And txt_senha.Text = senha_admin Then
            MsgBox("Login realizado com sucesso Sejá bem vindo Admin!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            usuario_logado = txt_usuario.Text
            txt_usuario.Clear()
            txt_senha.Clear()
            Me.Hide()
            Form1.ShowDialog()
            Exit Sub
        End If
        If String.IsNullOrEmpty(txt_usuario.Text) Or String.IsNullOrEmpty(txt_senha.Text) Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Exit Sub
        End If
        Try
            sql = $"select * from tb_usuarios where usuario='{txt_usuario.Text}' and senha='{txt_senha.Text}' "
            rs = db.Execute(sql)
            If rs.EOF = False Then 'Se existir o usuário na tabela
                If rs.Fields(5).Value <> "ATIVO" Then
                    MsgBox("Usuário bloqueado! Contate o administrador.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                    txt_usuario.Clear()
                    txt_senha.Clear()
                    txt_usuario.Focus()
                Else
                    MsgBox("Login realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    txt_usuario.Clear()
                    txt_senha.Clear()
                    Me.Hide()
                    Form1.ShowDialog()
                End If
            Else
                MsgBox("Usuário ou senha inválidos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("Erro ao realizar login!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(txt_usuario.Text) Or String.IsNullOrEmpty(txt_senha.Text) Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Exit Sub
        ElseIf txt_usuario.Text = "admin" And txt_senha.Text = "admin123" Then
            MsgBox("Login realizado com sucesso Sejá bem vindo Admin!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            usuario_logado = txt_usuario.Text
            txt_usuario.Clear()
            txt_senha.Clear()
            Me.Hide()
            cadastro.Show()
        Else
            MsgBox("Acesso apenas de administradores!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            txt_usuario.Clear()
            txt_senha.Clear()
            txt_usuario.Focus()
        End If
    End Sub

    Private Sub exibir_senha_CheckedChanged(sender As Object, e As EventArgs) Handles exibir_senha.CheckedChanged
        If exibir_senha.Checked Then
            txt_senha.PasswordChar = ""
        Else
            txt_senha.PasswordChar = "*"
        End If
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        resp = MsgBox("Deseja realmente sair?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = vbNo Then
            Exit Sub
        End If
        Me.Close()
    End Sub
End Class