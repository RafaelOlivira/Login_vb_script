Public Class cadastro
    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        If String.IsNullOrEmpty(txt_nome_completo.Text) Or String.IsNullOrEmpty(txt_email.Text) Or String.IsNullOrEmpty(txt_senha.Text) Or String.IsNullOrEmpty(txt_cpf.Text) Or String.IsNullOrEmpty(txt_usuario.Text) Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Exit Sub
        End If

        Try
            ' Variáveis para facilitar
            Dim nome As String = txt_nome_completo.Text
            Dim email As String = txt_email.Text
            Dim senha As String = txt_senha.Text
            Dim cpf As String = txt_cpf.Text
            Dim usuario As String = txt_usuario.Text
            sql = $"insert into tb_usuarios (cpf,nome_completo, email, usuario, senha,status) values
                   ('{cpf}', '{nome}', '{email}', '{usuario}','{senha}','{"ATIVO"}')"
            rs = db.Execute(sql)

            MsgBox("Cadastro realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            txt_nome_completo.Clear()
            txt_email.Clear()
            txt_senha.Clear()
            txt_usuario.Clear()
            txt_cpf.Clear()
            txt_nome_completo.Focus()
        Catch ex As Exception
            MsgBox("Erro ao cadastrar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Hide()
        login.ShowDialog()
    End Sub
End Class