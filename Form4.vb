Public Class gerenciar
    Private Sub gerenciar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
    End Sub
    Sub carregar_dados_datagrid()
        dgv_dados.Rows.Clear()
        sql = "select * from tb_usuarios"
        rs = db.Execute(sql)
        Do While Not rs.EOF
            dgv_dados.Rows.Add(rs.Fields(1).Value,
                               rs.Fields(2).Value,
                               rs.Fields(3).Value,
                               rs.Fields(4).Value,
                               rs.Fields(0).Value,
                               rs.Fields(5).Value)
            rs.MoveNext()
        Loop
    End Sub


    Private Sub btn_exibir_Click(sender As Object, e As EventArgs) Handles btn_exibir.Click
        carregar_dados_datagrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = $"select * from tb_usuarios where cpf='{txt_cpf.Text}'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            txt_cpf.Text = rs.Fields(0).Value
            txt_nome_completo.Text = rs.Fields(1).Value
            txt_email.Text = rs.Fields(2).Value
            txt_usuario.Text = rs.Fields(3).Value
            txt_senha.Text = rs.Fields(4).Value
            txt_status.Text = rs.Fields(5).Value
            carregar_dados_datagrid()
        Else
            MsgBox("CPF não encontrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
        End If
    End Sub

    Private Sub btn_bloquear_Click(sender As Object, e As EventArgs) Handles btn_bloquear.Click
        If String.IsNullOrEmpty(txt_cpf.Text) Or String.IsNullOrEmpty(txt_nome_completo.Text) Or String.IsNullOrEmpty(txt_email.Text) Or String.IsNullOrEmpty(txt_senha.Text) Or String.IsNullOrEmpty(txt_usuario.Text) Then
            MsgBox("Por favor, faça uma busca por CPF.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Exit Sub
        End If
        sql = $"select * from tb_usuarios where cpf='{txt_cpf.Text}'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            If rs.Fields(5).Value = "BLOQUEADO" Then
                MsgBox("O usuário já está bloqueado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub
            Else
                sql = $"update tb_usuarios set status='BLOQUEADO' where cpf='{txt_cpf.Text}'"
                rs = db.Execute(sql)
                carregar_dados_datagrid()
                MsgBox("Usuário bloqueado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If

        End If
    End Sub

    Private Sub btn_desbloquear_Click(sender As Object, e As EventArgs) Handles btn_desbloquear.Click
        If String.IsNullOrEmpty(txt_cpf.Text) Or String.IsNullOrEmpty(txt_nome_completo.Text) Or String.IsNullOrEmpty(txt_email.Text) Or String.IsNullOrEmpty(txt_senha.Text) Or String.IsNullOrEmpty(txt_usuario.Text) Then
            MsgBox("Por favor, faça uma busca por CPF.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Exit Sub
        End If
        sql = $"select * from tb_usuarios where cpf='{txt_cpf.Text}'"
        rs = db.Execute(sql)

        If rs.EOF = False Then
            If rs.Fields(5).Value = "ATIVO" Then
                MsgBox("O usuário já está desbloqueado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub
            Else
                sql = $"update tb_usuarios set status='ATIVO' where cpf='{txt_cpf.Text}'"
                rs = db.Execute(sql)

                carregar_dados_datagrid()
                MsgBox("Usuário desbloqueado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If


        End If
    End Sub

    Private Sub btn_deletar_Click(sender As Object, e As EventArgs) Handles btn_deletar.Click
        If String.IsNullOrEmpty(txt_cpf.Text) Or String.IsNullOrEmpty(txt_nome_completo.Text) Or String.IsNullOrEmpty(txt_email.Text) Or String.IsNullOrEmpty(txt_senha.Text) Or String.IsNullOrEmpty(txt_usuario.Text) Then
            MsgBox("Por favor, faça uma busca por CPF.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Exit Sub
        End If
        resp = MsgBox("Deseja realmente deletar o usuário com CPF: " & txt_cpf.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = vbNo Then
            Exit Sub
        End If
        sql = $"DELETE FROM tb_usuarios WHERE cpf = '{txt_cpf.Text}'"
        db.Execute(sql)
        MsgBox("Usuário deletado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        carregar_dados_datagrid()
        txt_nome_completo.Clear()
        txt_email.Clear()
        txt_cpf.Clear()
        txt_senha.Clear()
        txt_usuario.Clear()
        txt_status.Clear()
        txt_cpf.Focus()
    End Sub

    Private Sub txt_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Me.Close()
    End Sub

    Private Sub btn_alterar_Click(sender As Object, e As EventArgs) Handles btn_alterar.Click
        Try

            sql = $"update tb_usuarios set nome_completo='{txt_nome_completo.Text}', email='{txt_email.Text}', usuario='{txt_usuario.Text}', senha='{txt_senha.Text}', status='{txt_status.Text}' where cpf='{txt_cpf.Text}'"
            db.Execute(sql)
            MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao alterar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub CheckBox_campos_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_campos.CheckedChanged
        If CheckBox_campos.Checked = True Then

            txt_nome_completo.Enabled = True
            txt_email.Enabled = True
            txt_usuario.Enabled = True
            txt_senha.Enabled = True

        Else
            txt_nome_completo.Enabled = False
            txt_email.Enabled = False
            txt_usuario.Enabled = False
            txt_senha.Enabled = False

        End If

    End Sub
End Class