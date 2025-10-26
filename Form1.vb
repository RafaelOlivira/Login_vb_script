Public Class Form1
    Private Sub AdivinharNúmeroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdivinharNúmeroToolStripMenuItem.Click
        Try
            Process.Start(Application.StartupPath & "\Batch\teste.bat")
        Catch ex As Exception
            MsgBox("Erro ao executar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Try
            Process.Start("calc.exe")
        Catch ex As Exception
            MsgBox("Erro ao executar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub BlocoDeNotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlocoDeNotasToolStripMenuItem.Click
        Try
            Process.Start("notepad.exe")
        Catch ex As Exception
            MsgBox("Erro ao executar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub CadastroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem.Click
        If usuario_logado <> "admin" Then
            MsgBox("Acesso Negado! Apenas o Admin pode acessar o cadastro.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        Else
            frm_cadastro.Show()
        End If

    End Sub

    Private Sub GerenciarUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerenciarUsuariosToolStripMenuItem.Click
        If usuario_logado <> "admin" Then
            MsgBox("Acesso Negado! Apenas o Admin pode gerenciar usuários.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        Else
            gerenciar.Show()
        End If

    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        resp = MsgBox("Deseja realmente sair?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = vbNo Then
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub VOLTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VOLTARToolStripMenuItem.Click
        Me.Close()
        login.Show()
    End Sub
End Class
