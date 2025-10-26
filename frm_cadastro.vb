Public Class frm_cadastro
    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma Foto"
                .InitialDirectory = Application.StartupPath & "\Fotos\"
                .ShowDialog()
                diretorio = .FileName
                ' diretorio = diretorio.Replace("\", "/")
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub frm_cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'conectar_banco()
        conecta_banco_mysql()
        'conecta_banco_access()
        carregar_dados()
        carregar_tipo_dados()
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Try
            sql = $"select * from tb_clientes where cpf='{txt_cpf.Text}'"
            rs = db.Execute(sql)
            If rs.EOF = False Then 'Se existir o cpf na tabela
                sql = $"update tb_clientes set nome='{txt_nome.Text}',
                                            data_nasc='{cmb_data_nasc.Value.ToShortDateString}',
                                           fone='{txt_fone.Text}',
                                           email='{txt_email.Text}',
                                           foto='{diretorio}' where cpf='{txt_cpf.Text}'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                sql = $"insert into tb_clientes (cpf,nome,data_nasc,fone,email,foto) values
                       ('{txt_cpf.Text}', '{txt_nome.Text}', '{cmb_data_nasc.Value.ToShortDateString}',
                        '{txt_fone.Text}','{txt_email.Text}','{diretorio}')"
                rs = db.Execute(sql)
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            End If
            carregar_dados()
            txt_cpf.Clear()
            txt_nome.Clear()
            cmb_data_nasc.Value = Now
            txt_fone.Clear()
            txt_email.Clear()
            img_foto.Load(Application.StartupPath & "\Fotos\nova_foto.png")
            txt_cpf.Focus()

        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")

        End Try
    End Sub



    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Try
            sql = $"select * from tb_clientes where cpf='{txt_cpf.Text}'"
            rs = db.Execute(sql)
            If rs.EOF = False Then 'Se existir o cpf na tabela
                txt_nome.Text = rs.Fields(2).Value
                cmb_data_nasc.Value = rs.Fields(3).Value
                txt_fone.Text = rs.Fields(4).Value
                txt_email.Text = rs.Fields(5).Value
                img_foto.Load(rs.Fields(6).Value)
            Else
                txt_nome.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro ao consultar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub txt_cpf_DoubleClick(sender As Object, e As EventArgs) Handles txt_cpf.DoubleClick
        txt_cpf.Clear()
        txt_nome.Clear()
        cmb_data_nasc.Value = Now
        txt_fone.Clear()
        txt_email.Clear()
        img_foto.Load(Application.StartupPath & "\Fotos\nova_foto.png")
        txt_cpf.Focus()
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        With dgv_dados
            sql = $"select * from tb_clientes where {cmb_campo.Text} like '{txt_buscar.Text}%'"
            rs = db.Execute(sql)
            cont = 1
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(2).Value, Nothing, Nothing)
                rs.MoveNext()
                cont = cont + 1
            Loop
        End With
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados

                If .CurrentRow.Cells(3).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    sql = $"select * from tb_clientes where cpf ='{aux_cpf}'"
                    rs = db.Execute(sql)
                    diretorio = rs.Fields(6).Value
                    diretorio = diretorio.Replace("\", "/")
                    txt_cpf.Text = rs.Fields(1).Value
                    txt_nome.Text = rs.Fields(2).Value
                    cmb_data_nasc.Value = rs.Fields(3).Value
                    txt_fone.Text = rs.Fields(4).Value
                    txt_email.Text = rs.Fields(5).Value
                    img_foto.Load(rs.Fields(6).Value)
                ElseIf .CurrentRow.Cells(4).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente Excluir?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = $"delete from tb_clientes where cpf='{aux_cpf}'"
                        rs = db.Execute(sql)
                        carregar_dados()

                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub


End Class