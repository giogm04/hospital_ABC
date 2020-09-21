Imports FirebirdSql.Data.FirebirdClient


Module modConexion
    Public CONTRASEÑASYSDBA, CNXSTRING, CNXREP, USUARIO_ACTUAL, USUARIO_REAL As String
    Public FbCon, fbCnf As New FbConnection
    Public FbCs As New FbConnectionStringBuilder
    Public menu As String

    Public Function ConectarConfig(ByVal tipo As String, ByVal servidor As String, ByVal usuario As String, ByVal contraseña As String, ByVal ruta As String) As Boolean

        On Error GoTo errh

        If tipo = "Remota" Then
            ruta = servidor & ":" & ruta
        End If
        FbCs = New FbConnectionStringBuilder
        FbCs.Database = ruta & "System\CONFIG.FDB"
        FbCs.ServerType = FbServerType.Default
        FbCs.UserID = usuario
        FbCs.Password = contraseña
        fbCnf = New FbConnection(FbCs.ToString)
        fbCnf.Open()
        ConectarConfig = True
errh:
        If Err.Number <> 0 Then
            'Call RegistraErrorLog(ByVal "modConexion", ByVal "ConectarConfig", ByVal Err.Number, ByVal Err.Description)
            MsgBox(Err.Source & " " & Err.Description, , "Error")
            ConectarConfig = False
        End If

    End Function
    Public Function ConectarEmpresa(ByVal tipo As String, ByVal servidor As String, ByVal usuario As String, pwd As String, ByVal ruta As String, ByVal empresa As String) As Boolean
        On Error GoTo errh

        If tipo = "Remota" Then
            ruta = servidor & ":" & ruta
        End If
        'CNXSTRING = "DRIVER=Firebird/InterBase(r) driver;UID=" & usuario & ";PWD=" & pwd & ";DBNAME=" & ruta & "\" & empresa & ".FDB"
        CNXSTRING = "Driver=Firebird/InterBase(r) driver;dbname=" & ruta & empresa & ".FDB;uid=SYSDBA;pwd=masterkey"
        FbCs = New FbConnectionStringBuilder
        FbCs.Database = ruta & empresa & ".FDB"
        FbCs.ServerType = FbServerType.Default
        FbCs.UserID = usuario
        FbCs.Password = pwd
        FbCon = New FbConnection(FbCs.ToString)
        FbCon.Open()
        ConectarEmpresa = True
errh:
        If Err.Number <> 0 Then
            'Call RegistraErrorLog(ByVal "modConexion", ByVal "ConectarEmpresa", ByVal Err.Number, ByVal Err.Description)
            MsgBox(Err.Source & " " & Err.Description, , "Error")
            ConectarEmpresa = False
        End If

    End Function

    Public Function HayConexionConfig() As Boolean
        If fbCnf.State = ConnectionState.Open Then
            HayConexionConfig = True
        Else
            HayConexionConfig = False
        End If
    End Function
    Public Function RevisaNodo999() As Boolean
        Dim sql As String
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        sql = "Select nombre from registry where nombre='master'"
        fbCmd.Connection = fbCnf
        fbCmd.CommandText = sql
        fbDr = fbCmd.ExecuteReader
        If fbDr.Read Then
            Return True
        Else
            Return False
        End If
        fbCmd.Dispose()
        fbDr.Close()
    End Function
    Public Sub CrearNodo999(contraseña As String)
        Dim sql As String
        Dim fbCmd As New FbCommand
        Dim fbTr As FbTransaction
        sql = "insert into registry(elemento_id,nombre,tipo,padre_id,valor) values(999999,'master','V',1,'" & contraseña & "')"
        fbCmd.Connection = fbCnf
        'fbTr = FbCon.BeginTransaction
        fbCmd.CommandText = sql
        fbCmd.ExecuteNonQuery()
        ' fbTr.Commit()
        sql = "GRANT SELECT ON REGISTRY TO PUBLIC;"
        ' fbTr = FbCon.BeginTransaction
        fbCmd.CommandText = sql
        fbCmd.ExecuteNonQuery()
        'fbTr.Commit()
    End Sub
    Public Function ComparaContraseñaSYSDBA(contraseña) As Boolean
        Dim sql As String
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        sql = "select valor from registry where nombre='master' and valor='" & contraseña & "'"
        fbCmd.Connection = fbCnf
        fbCmd.CommandText = sql
        fbDr = fbCmd.ExecuteReader
        If fbDr.Read Then
            Return True
        Else
            Return False
        End If
        fbCmd.Dispose()
        fbDr.Close()
    End Function
    Public Sub ActualizaNodo999(contraseña As String)
        Dim sql As String
        Dim fbCmd As New FbCommand
        'Dim fbTr As FbTransaction
        sql = "update registry set valor='" & contraseña & "' where nombre='master'"
        fbCmd.Connection = fbCnf
        'fbTr = FbCon.BeginTransaction
        fbCmd.CommandText = sql
        fbCmd.ExecuteNonQuery()
        'fbTr.Commit()
        fbCmd.Dispose()
    End Sub
    Public Function GetContraseñaSYSDBA() As String
        Dim sql As String
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        sql = "select valor from registry where nombre='master'"
        fbCmd.Connection = fbCnf
        fbCmd.CommandText = sql
        fbDr = fbCmd.ExecuteReader
        If fbDr.Read Then
            Return fbDr.GetString(0)
        Else
            Return ""
        End If
        fbDr.Close()
        fbCmd.Dispose()
    End Function
    Public Sub LlenarListEmpresas()
        Dim sql As String
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        sql = "Select nombre_corto from empresas order by nombre_corto"
        fbCmd.Connection = fbCnf
        fbCmd.CommandText = sql
        fbDr = fbCmd.ExecuteReader
        With frmEmpresas
            .lstEmpresas.Items.Clear()
            While fbDr.Read
                .lstEmpresas.Items.Add(fbDr.GetString(0))
                fbDr.NextResult()
            End While
            If .lstEmpresas.Items.Count > 0 Then .lstEmpresas.SelectedIndex = 0
        End With
        fbCmd.Dispose()
        fbDr.Close()
    End Sub

    Public Sub LlenarEmpresasUsuario(ByVal usuario As String)
        Dim sql As String
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        sql = "select c.nombre_corto From usuarios a inner join empresas_usuarios b on (a.usuario_id = b.usuario_id) " _
        & "inner join empresas c on (b.empresa_id = c.empresa_id) where a.usuario_id = " & GetIdUsuario(usuario)
        fbCmd.Connection = fbCnf
        fbCmd.CommandText = sql
        fbDr = fbCmd.ExecuteReader
        With frmEmpresas
            .lstEmpresas.Items.Clear()
            While fbDr.Read
                .lstEmpresas.Items.Add(fbDr.GetString(0))
                fbDr.NextResult()
            End While
            If .lstEmpresas.Items.Count > 0 Then .lstEmpresas.SelectedIndex = 0
        End With
    End Sub

    Public Function GetIdUsuario(ByVal usuario As String) As Long
        Dim sql As String
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        sql = "select usuario_id from usuarios where nombre='" & usuario & "'"
        fbCmd.Connection = fbCnf
        fbCmd.CommandText = sql
        fbDr = fbCmd.ExecuteReader
        If fbDr.Read Then
            If Not fbDr.GetValue(0) Is DBNull.Value Then
                Return fbDr.GetInt64(0)
            Else
                Return 0
            End If
        Else
            Return 0
        End If
            fbCmd.Dispose()
            fbDr.Close()
    End Function
    Public Function GetNombreUsuario(idusuario) As String
        Dim sql As String
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        sql = "select nombre from usuarios where usuario_id=" & idusuario
        fbCmd.Connection = fbCnf
        fbCmd.CommandText = sql
        fbDr = fbCmd.ExecuteReader
        If fbDr.Read Then
            Return fbDr.GetString(0)
        Else
            Return ""
        End If
        fbCmd.Dispose()
        fbDr.Close()
    End Function
    Public Function GetIdEmpresa(empresa As String) As Long
        Dim sql As String
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        sql = "select empresa_id from empresas where nombre_corto='" & empresa & "'"
        fbCmd.Connection = fbCnf
        fbCmd.CommandText = sql
        fbDr = fbCmd.ExecuteReader
        If fbDr.Read Then
            Return fbDr.GetInt64(0)
        Else
            Return 0
        End If
        fbCmd.Dispose()
        fbDr.Close()
    End Function

    Public Function GetNombreEmpresa(empresa_id) As String
        Dim sql As String
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        sql = "select nombre from empresas where empresa_id=" & empresa_id
        fbCmd.Connection = fbCnf
        fbCmd.CommandText = sql
        fbDr = fbCmd.ExecuteReader
        If fbDr.Read Then
            Return fbDr.GetString(0)
        Else
            Return ""
        End If
        fbCmd.Dispose()
        fbDr.Close()
    End Function

    Public Function HayConexionEmpresa() As Boolean
        If FbCon.State = ConnectionState.Open Then
            HayConexionEmpresa = True
        Else
            HayConexionEmpresa = False
        End If
    End Function
    Public Sub LlenarCmbCnf(cmb As ComboBox, sql As String)
        Dim fbdr As FbDataReader
        Dim fbCmd As New FbCommand

        fbCmd.Connection = fbCnf
        fbCmd.CommandText = sql
        fbdr = fbCmd.ExecuteReader

        cmb.Items.Clear()

        While fbdr.Read
            cmb.Items.Add(New ItemData(fbdr.GetString(0), fbdr.GetInt64(1)))
            fbdr.NextResult()
        End While

        If cmb.Items.Count() > 0 Then
            cmb.SelectedIndex = 0
        End If

    End Sub
End Module
