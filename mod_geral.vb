Module mod_geral
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public diretorio, sql, aux_cpf, resp As String  'Declaração de Variáveis
    Public usuario_logado As String
    Public cont As Integer
    Public dir_banco = Application.StartupPath & "\Banco\cadastro.mdb"


    Sub conecta_banco_access()
        Try
            'String de Conexão SQL-SERVER
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dir_banco)
            MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao Conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub


    Sub conectar_banco()
        Try
            'String de Conexão SQL-SERVER
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=SALA07\SQLEXPRESS;Initial Catalog=cad_clientes_adsma2;trusted_connection=yes;")
            MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao Conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub


    Sub conecta_banco_mysql()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("DRIVER={MySQL ODBC 3.51 Driver};SERVER=localhost;DATABASE=cad_clientes_adsma2;UID=root;PWD=usbw;port=3307;option=3;")

        Catch ex As Exception
            MsgBox("Erro ao Conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_dados()
        With frm_cadastro.dgv_dados
            sql = "select * from tb_clientes order by nome asc"
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

    Sub carregar_tipo_dados()
        With frm_cadastro.cmb_campo.Items
            .Add("CPF")
            .Add("NOME")
        End With
        frm_cadastro.cmb_campo.SelectedIndex = 1
    End Sub



End Module
