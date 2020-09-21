Option Explicit On
Imports FirebirdSql.Data.FirebirdClient
Imports FastReport
Imports FastReport.Report
Imports FastReport.Export
Imports FastReport.Utils
Imports System.Text

Public Class Registry


    Public Sub New()
        Dim sql As String
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        fbCmd.Connection = FbCon

        fbDr.Close()
        fbCmd.Dispose()

    End Sub
End Class
Module modMSP
    Dim m_Left As Single
    Dim m_Top As Single
    Dim m_Width As Single
    Dim m_Height As Single
    Public TIPO_CON, NOMBRE_CON, SERVIDOR_CON, CARPETA_CON, EMPRESA_CON, USUARIO_CON,
    CONTRASEÑA_CON As String
    Public nueva_con As Boolean
    Public grd_busca As DataGridView
    Public tipo_ns, tipo_lote As String

    Public Const APpLICATION = "Conexion"
    Public Path_archivo_ini As String = App_Path() & "\config.ini"

    Private Declare Unicode Function WritePrivateProfileString Lib "kernel32" _
    Alias "WritePrivateProfileStringW" (ByVal lpApplicationName As String,
    ByVal lpKeyName As String, ByVal lpString As String,
    ByVal lpFileName As String) As Int32

    Private Declare Unicode Function GetPrivateProfileString Lib "kernel32" _
    Alias "GetPrivateProfileStringW" (ByVal lpApplicationName As String,
    ByVal lpKeyName As String, ByVal lpDefault As String,
    ByVal lpReturnedString As String, ByVal nSize As Int32,
    ByVal lpFileName As String) As Int32

    Public tipo_forma, parametro_imprimir As String
    Public elem_imprimir_id As Long
    Public Sub Grabar_ini(ByVal iniFileName As String, ByVal Section As String, ByVal ParamName As String, ByVal ParamVal As String)
        Dim Result As Integer = WritePrivateProfileString(Section, ParamName, ParamVal, iniFileName)
    End Sub

    Public Function Leer_ini(ByVal IniFileName As String, ByVal Section As String, ByVal ParamName As String, ByVal ParamDefault As String) As String
        Dim ParamVal As String = Space$(256)
        Dim LenParamVal As Long = GetPrivateProfileString(Section, ParamName, ParamDefault, ParamVal, Len(ParamVal), IniFileName)
        Leer_ini = Left$(ParamVal, LenParamVal)
    End Function
    Class ItemData
        Public Id As Integer
        Public Nombre As String

        Public Sub New(ByVal s As String, ByVal i As Integer)
            Nombre = s
            Id = i
        End Sub

        '//VB.net will decide DisplayMember using this function
        Public Overrides Function ToString() As String
            ToString = Nombre
        End Function
    End Class
    Class ItemDataS
        Public Id As String
        Public Nombre As String

        Public Sub New(ByVal s As String, ByVal i As String)
            Nombre = s
            Id = i
        End Sub

        '//VB.net will decide DisplayMember using this function
        Public Overrides Function ToString() As String
            ToString = Nombre
        End Function
    End Class
    Public frm_actual As String
    Public txt_actual As ToolStripTextBox
    Public Sub LlenarComboConexion()
        Dim con, conexion As String
        Dim ini, fin, lon, lon1 As Integer

        con = Leer_ini(Path_archivo_ini, APPLICATION, "conexiones", "")

        With frmConexion
            .cmbConexion.Items.Clear()
            lon = Len(con)
            ini = 1
            While ini < lon
                fin = InStr(ini, con, "|")
                lon1 = fin - ini
                conexion = Mid(con, ini, lon1)
                .cmbConexion.Items.Add(conexion)
                ini = fin + 1
            End While

            If .cmbConexion.Items.Count() <> 0 Then
                .cmbConexion.SelectedIndex = 0
            End If

        End With

    End Sub

    Public Function App_Path() As String
        Return System.AppDomain.CurrentDomain.BaseDirectory()
    End Function

    Public Sub LlenarFormNuevaConexion(conexion As String)
        Dim tipo As String

        tipo = Leer_ini(Path_archivo_ini, APPLICATION, conexion & "tp", "")

        With frmNuevaConexion
            If tipo = "Local" Then
                .cmbTipoConexion.SelectedIndex = 0
                .cmbTipoConexion.Enabled = False
                .txtNombre.Text = Leer_ini(Path_archivo_ini, APPLICATION, conexion & "nm", "")
                .txtServidor.Text = ""
                .txtServidor.Enabled = False
                .txtCarpetaDatos.Text = Leer_ini(Path_archivo_ini, APPLICATION, conexion & "cr", "")
            End If

            If tipo = "Remota" Then
                .cmbTipoConexion.SelectedIndex = 1
                .cmbTipoConexion.Enabled = False
                .txtNombre.Text = Leer_ini(Path_archivo_ini, APPLICATION, conexion & "nm", "")
                .txtServidor.Text = Leer_ini(Path_archivo_ini, APPLICATION, conexion & "sr", "")
                .txtServidor.Enabled = False
                .txtCarpetaDatos.Text = Leer_ini(Path_archivo_ini, APPLICATION, conexion & "cr", "")
            End If

        End With
    End Sub

    Public Sub SelectAllText(tb As TextBox)
        tb.SelectionStart = 0
        tb.SelectionLength = Len(tb.Text)
    End Sub

    Public Function ExisteConexion(conexion As String) As Boolean
        Dim hay As Integer
        Dim con As String

        con = Leer_ini(Path_archivo_ini, APPLICATION, "conexiones", "")
        hay = InStr(1, con, conexion & "|", vbTextCompare)
        If hay <> 0 Then
            ExisteConexion = True
        Else
            ExisteConexion = False
        End If

    End Function

    Public Sub CargarDatosConexion(conexion As String)
        Dim tipo As String

        tipo = Leer_ini(Path_archivo_ini, APPLICATION, conexion & "tp", "")

        TIPO_CON = tipo

        If tipo = "Local" Then
            SERVIDOR_CON = "LOCALHOST"
            CARPETA_CON = Leer_ini(Path_archivo_ini, APPLICATION, conexion & "cr", "")
        End If

        If tipo = "Remota" Then
            SERVIDOR_CON = Leer_ini(Path_archivo_ini, APPLICATION, conexion & "sr", "")
            CARPETA_CON = Leer_ini(Path_archivo_ini, APPLICATION, conexion & "cr", "")
        End If

    End Sub

    Public Function GuardarConexionExistente(tipo As String, nombre As String, servidor As String, carpeta As String) As Boolean

        If frmNuevaConexion.cmbTipoConexion.Text = "Local" Then
            If tipo = "" Then
                Return False
                Exit Function
            ElseIf carpeta = "" Then
                Return False
                Exit Function
            Else
                Return True
            End If
        End If

        If frmNuevaConexion.cmbTipoConexion.Text = "Remota" Then
            If tipo = "" Then
                Return False
                Exit Function
            ElseIf servidor = "" Then
                Return False
                Exit Function
            ElseIf carpeta = "" Then
                Return False
                Exit Function
            Else
                Return True
            End If
        End If

        Call Grabar_ini(Path_archivo_ini, APPLICATION, nombre & "tp", tipo)
        Call Grabar_ini(Path_archivo_ini, APPLICATION, nombre & "sr", servidor)
        Call Grabar_ini(Path_archivo_ini, APPLICATION, nombre & "cr", carpeta)

    End Function

    Public Sub BorrarConexion(conexion As String)
        Dim lon, lon1, lon2, ini, fin As Integer
        Dim con, parte1, parte2, completo As String

        con = Leer_ini(Path_archivo_ini, APPLICATION, "conexiones", "")
        lon = Len(con)
        ini = InStr(1, con, conexion & "|")
        fin = InStr(ini, con, "|")

        lon1 = ini - 1
        parte1 = Mid(con, 1, lon1)

        lon2 = lon - fin + 2
        parte2 = Mid(con, fin + 1, lon2)

        completo = parte1 + parte2

        Call Grabar_ini(Path_archivo_ini, APPLICATION, "conexiones", completo)

        Call LlenarComboConexion()

    End Sub

    Public Sub GuardarUltimoUsuarioConexion()

        With frmConexion

            Call Grabar_ini(Path_archivo_ini, APPLICATION, "usuariopred", .txtUsuario.Text)
            Call Grabar_ini(Path_archivo_ini, APPLICATION, "conexionpred", .cmbConexion.Text)

        End With

    End Sub

    Public Sub CargarUltimoUsuarioConexion()
        Dim usuario, conexion As String
        Dim indice, cuenta, j As Integer

        With frmConexion

            usuario = Leer_ini(Path_archivo_ini, APPLICATION, "usuariopred", "")
            conexion = Leer_ini(Path_archivo_ini, APPLICATION, "conexionpred", "")

            If usuario = "" Or conexion = "" Then
                Exit Sub
            End If

            .txtUsuario.Text = usuario

            cuenta = .cmbConexion.Items.Count()

            If cuenta = 0 Then
                Exit Sub
            End If

            For j = 0 To cuenta - 1

                If frmConexion.cmbConexion.Items(j).ToString = conexion Then
                    indice = j
                End If

            Next j

            .cmbConexion.SelectedIndex = indice

        End With

    End Sub

    Public Sub GuardarUltimaEmpresa()

        With frmEmpresas

            Call Grabar_ini(Path_archivo_ini, APPLICATION, "empresapred", .lstEmpresas.Text)

        End With

    End Sub

    Public Sub CargarUltimaEmpresa()
        Dim empresa As String
        Dim indice, cuenta, j As Integer

        With frmEmpresas

            empresa = Leer_ini(Path_archivo_ini, APPLICATION, "empresapred", "")

            If empresa = "" Then
                Exit Sub
            End If

            cuenta = .lstEmpresas.Items.Count()

            If cuenta = 0 Then
                Exit Sub
            End If

            For j = 0 To cuenta - 1
                .lstEmpresas.SelectedIndex = j
                If .lstEmpresas.Text = empresa Then
                    indice = j
                End If

            Next j

            .lstEmpresas.SelectedIndex = indice

        End With

    End Sub

    Public Function GuardarConexionNueva(tipo As String, nombre As String, servidor As String, carpeta As String) As Boolean
        Dim con As String

        If frmNuevaConexion.cmbTipoConexion.Text = "Local" Then
            If tipo = "" Then
                Return False
                Exit Function
            ElseIf nombre = "" Then
                Return False
                Exit Function
            ElseIf carpeta = "" Then
                Return False
                Exit Function
            Else
                con = Leer_ini(Path_archivo_ini, APPLICATION, "conexiones", "")
                con = con & nombre & "|"
                Call Grabar_ini(Path_archivo_ini, APPLICATION, "conexiones", con)
                Call Grabar_ini(Path_archivo_ini, APPLICATION, nombre & "tp", tipo)
                Call Grabar_ini(Path_archivo_ini, APPLICATION, nombre & "nm", nombre)
                Call Grabar_ini(Path_archivo_ini, APPLICATION, nombre & "sr", servidor)
                Call Grabar_ini(Path_archivo_ini, APPLICATION, nombre & "cr", carpeta)
                Return True
            End If
        End If

        If frmNuevaConexion.cmbTipoConexion.Text = "Remota" Then
            If tipo = "" Then
                Return False
                Exit Function
            ElseIf nombre = "" Then
                Return False
                Exit Function
            ElseIf servidor = "" Then
                Return False
                Exit Function
            ElseIf carpeta = "" Then
                Return False
                Exit Function
            Else
                con = Leer_ini(Path_archivo_ini, APPLICATION, "conexiones", "")
                con = con & nombre & "|"
                Call Grabar_ini(Path_archivo_ini, APPLICATION, "conexiones", con)
                Call Grabar_ini(Path_archivo_ini, APPLICATION, nombre & "tp", tipo)
                Call Grabar_ini(Path_archivo_ini, APPLICATION, nombre & "nm", nombre)
                Call Grabar_ini(Path_archivo_ini, APPLICATION, nombre & "sr", servidor)
                Call Grabar_ini(Path_archivo_ini, APPLICATION, nombre & "cr", carpeta)
                Return True
            End If
        End If

    End Function
    Public Sub CargarComboConexion()
        Dim conexiones As String
        conexiones = Leer_ini(Path_archivo_ini, APPLICATION, "conexiones", 0)
        If conexiones <> "" Then
            LlenarComboConexion()
        End If
    End Sub
    Public Function GenDoctoID() As Long
        Dim sql As String
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        sql = "SELECT GEN_ID(id_doctos, 1) FROM RDB$DATABASE"
        fbCmd.Connection = FbCon
        fbCmd.CommandText = sql
        fbDr = fbCmd.ExecuteReader
        If fbDr.Read Then
            Return fbDr.GetInt64(0)
        Else
            Return 0
        End If
        fbDr.Close()
        fbCmd.Dispose()
    End Function
    Public Function GenCatalogoID() As Long
        Dim sql As String
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        sql = "SELECT GEN_ID(id_catalogos, 1) FROM RDB$DATABASE"
        fbCmd.Connection = FbCon
        fbCmd.CommandText = sql
        fbDr = fbCmd.ExecuteReader
        If fbDr.Read Then
            Return fbDr.GetInt64(0)
        Else
            Return 0
        End If
        fbDr.Close()
        fbCmd.Dispose()
    End Function
    Public Function GetAlmacenByNombre(almacen As String) As Long
        Dim sql As String
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        sql = "select almacen_id from almacenes where nombre='" & almacen & "'"
        fbCmd.Connection = FbCon
        fbCmd.CommandText = sql
        fbDr = fbCmd.ExecuteReader
        If fbDr.Read Then
            Return fbDr.GetInt64(0)
        Else
            Return 0
        End If
        fbDr.Close()
        fbCmd.Dispose()
    End Function
    Public Function GetAlmacenById(almacen_id As Long) As String
        Dim sql As String
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        sql = "select nombre from almacenes where almacen_id=" & almacen_id
        fbCmd.Connection = FbCon
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
    Public Function GetInfoOrdenCompra(orden_compra As String) As String()
        Dim sql As String
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        Dim info(9) As String
        sql = "SELECT A.DOCTO_CM_ID,A.FOLIO,B.NOMBRE,A.FECHA, A.FECHA_ENTREGA,A.ESTATUS,A.MONEDA_ID,D.NOMBRE,C.NOMBRE,A.ALMACEN_ID FROM " &
            "DOCTOS_CM A INNER JOIN PROVEEDORES B ON (A.PROVEEDOR_ID=B.PROVEEDOR_ID) INNER JOIN ALMACENES C ON (A.ALMACEN_ID=C.ALMACEN_ID) " &
            "INNER JOIN MONEDAS D ON (A.MONEDA_ID=D.MONEDA_ID) LEFT JOIN MASK_FOLIO(A.FOLIO) E ON (A.FOLIO=E.ANT_FOLIO) WHERE UPPER(E.NUEVO_FOLIO)='" & UCase(orden_compra) & "'"
        fbCmd.Connection = FbCon
        fbCmd.CommandText = sql
        fbDr = fbCmd.ExecuteReader
        If fbDr.Read Then
            info(0) = fbDr.GetString(0)
            info(1) = fbDr.GetString(1)
            info(2) = fbDr.GetString(2)
            info(3) = FormatDateTime(fbDr.GetString(3), DateFormat.ShortDate)
            info(4) = FormatDateTime(fbDr.GetString(4), DateFormat.ShortDate)
            info(5) = fbDr.GetString(5)
            info(6) = fbDr.GetString(6)
            info(7) = fbDr.GetString(7)
            info(8) = fbDr.GetString(8)
            info(9) = fbDr.GetString(9)
        Else
            info(0) = "0"
            info(1) = ""
            info(2) = ""
            info(3) = ""
            info(4) = ""
            info(5) = ""
            info(6) = ""
            info(7) = ""
            info(8) = ""
            info(9) = ""
        End If
        fbDr.Close()
        fbCmd.Dispose()
        Return info
    End Function
    Public Function GetInfoAuxiliar(verificacion_pago_id As Long) As String()
        Dim sql As String
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        Dim info(2) As String
        sql = "SELECT A.AUXILIAR_TESORERIA_ID, A.FECHA, A.CONCEPTO FROM SOL_AUXILIARES_TESORERIA A INNER JOIN SOL_VERIFICACION_PAGOS B ON " &
            "(A.AUXILIAR_TESORERIA_ID=B.AUXILIAR_TESORERIA_ID) WHERE B.VERIFICACION_PAGO_ID=" & verificacion_pago_id
        fbCmd.Connection = FbCon
        fbCmd.CommandText = sql
        fbDr = fbCmd.ExecuteReader
        If fbDr.Read Then
            info(0) = fbDr.GetString(0)
            info(1) = FormatDateTime(fbDr.GetDateTime(1), DateFormat.ShortDate)
            info(2) = fbDr.GetString(2)
        Else
            info(0) = "0"
            info(1) = "01/01/2018"
            info(2) = ""
        End If
        fbDr.Close()
        fbCmd.Dispose()
        Return info
    End Function
    Public Function GetInfoCliente(tipo As String, busca As String) As String()
        Dim sql As String
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        Dim info(7) As String

        If tipo = "C" Then
            sql = "SELECT A.CLIENTE_ID,B.CLAVE_CLIENTE, A.NOMBRE, C.NOMBRE_COMERCIAL,IIF(D.DIR_CLI_ID IS NULL,0,D.DIR_CLI_ID),IIF(D.DIR_CLI_ID IS NULL,0,D.DIR_CLI_ID)," &
                "A.MONEDA_ID, A.COND_PAGO_ID FROM CLIENTES A " &
                "LEFT JOIN GET_CLAVE_CLI(A.CLIENTE_ID) B ON (A.CLIENTE_ID=B.CLIENTE_ID) LEFT JOIN LIBRES_CLIENTES C ON (A.CLIENTE_ID=C.CLIENTE_ID) " &
                "LEFT JOIN DIRS_CLIENTES D ON (A.CLIENTE_ID=D.CLIENTE_ID) WHERE B.CLAVE_CLIENTE='" & busca & "'"
        ElseIf tipo = "N" Then
            sql = "SELECT A.CLIENTE_ID,B.CLAVE_CLIENTE, A.NOMBRE, C.NOMBRE_COMERCIAL,IIF(D.DIR_CLI_ID IS NULL,0,D.DIR_CLI_ID),IIF(D.DIR_CLI_ID IS NULL,0,D.DIR_CLI_ID)," &
                "A.MONEDA_ID,A.COND_PAGO_ID FROM CLIENTES A " &
                "LEFT JOIN GET_CLAVE_CLI(A.CLIENTE_ID) B ON (A.CLIENTE_ID=B.CLIENTE_ID) LEFT JOIN LIBRES_CLIENTES C ON (A.CLIENTE_ID=C.CLIENTE_ID) " &
                "LEFT JOIN DIRS_CLIENTES D ON (A.CLIENTE_ID=D.CLIENTE_ID)  WHERE A.NOMBRE='" & busca & "'"
        Else
            sql = "SELECT A.CLIENTE_ID,B.CLAVE_CLIENTE, A.NOMBRE, C.NOMBRE_COMERCIAL,IIF(D.DIR_CLI_ID IS NULL,0,D.DIR_CLI_ID),IIF(D.DIR_CLI_ID IS NULL,0,D.DIR_CLI_ID)," &
                "A.MONEDA_ID,A.COND_PAGO_ID FROM CLIENTES A " &
                "LEFT JOIN GET_CLAVE_CLI(A.CLIENTE_ID) B ON (A.CLIENTE_ID=B.CLIENTE_ID) LEFT JOIN LIBRES_CLIENTES C ON (A.CLIENTE_ID=C.CLIENTE_ID) " &
                "LEFT JOIN DIRS_CLIENTES D ON (A.CLIENTE_ID=D.CLIENTE_ID)  WHERE C.NOMBRE_COMERCIAL='" & busca & "'"
        End If
        fbCmd.Connection = FbCon
        fbCmd.CommandText = sql
        fbDr = fbCmd.ExecuteReader
        If fbDr.Read Then
            info(0) = fbDr.GetInt64(0)
            info(1) = fbDr.GetString(1)
            info(2) = fbDr.GetString(2)
            info(3) = fbDr.GetString(3)
            info(4) = fbDr.GetInt64(4)
            info(5) = fbDr.GetInt64(5)
            info(6) = fbDr.GetInt64(6)
            info(7) = fbDr.GetInt64(7)
        Else
            info(0) = "0"
            info(1) = ""
            info(2) = ""
            info(3) = ""
            info(4) = "0"
            info(5) = "0"
            info(6) = "0"
            info(7) = "0"
        End If
        fbDr.Close()
        fbCmd.Dispose()
        Return info
    End Function
    Public Function GetDatosCliente(cliente_id As Long) As String()
        Dim sql As String
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        Dim info(3) As String


        sql = "SELECT A.CLIENTE_ID,B.CLAVE_CLIENTE, A.NOMBRE, D.EMAIL FROM CLIENTES A " &
                "LEFT JOIN GET_CLAVE_CLI(A.CLIENTE_ID) B ON (A.CLIENTE_ID=B.CLIENTE_ID) INNER JOIN LIBRES_CLIENTES C ON (A.CLIENTE_ID=C.CLIENTE_ID) " &
                "INNER JOIN DIRS_CLIENTES D ON (A.CLIENTE_ID=D.CLIENTE_ID)  WHERE D.NOMBRE_CONSIG='Dirección principal' AND A.CLIENTE_ID=" & cliente_id
        fbCmd.Connection = FbCon
        fbCmd.CommandText = sql
        fbDr = fbCmd.ExecuteReader
        If fbDr.Read Then
            info(0) = fbDr.GetInt64(0)
            info(1) = fbDr.GetString(1)
            info(2) = fbDr.GetString(2)
            info(3) = fbDr.GetString(3)
        Else
            info(0) = "0"
            info(1) = ""
            info(2) = ""
            info(3) = ""
        End If
        fbDr.Close()
        fbCmd.Dispose()
        Return info
    End Function
    Public Function GetInfoConBan(cuenta_ban_id As Long) As String()
        Dim sql As String
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        Dim info(2) As String
        sql = "SELECT B.CUENTA_ID,A.CUENTA_CONTABLE FROM CUENTAS_BANCARIAS A INNER JOIN CUENTAS_CO B ON (A.CUENTA_CONTABLE=" &
            "B.CUENTA_PT) WHERE A.CUENTA_BAN_ID=" & cuenta_ban_id
        fbCmd.Connection = FbCon
        fbCmd.CommandText = sql
        fbDr = fbCmd.ExecuteReader
        If fbDr.Read Then
            info(0) = fbDr.GetString(0)
            info(1) = fbDr.GetString(1)
        Else
            info(0) = "0"
            info(1) = ""
        End If
        fbDr.Close()
        fbCmd.Dispose()
        Return info
    End Function
    Public Function GetInfoPolizaBan(docto_ba_id As Long) As Long()
        Dim sql As String
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        Dim info(1) As Long
        sql = "SELECT DOCTO_CO_ID,TIPO_POLIZA_ID FROM GET_POLIZA_MOVTO_BA(" & docto_ba_id & ")"
        fbCmd.Connection = FbCon
        fbCmd.CommandText = sql
        fbDr = fbCmd.ExecuteReader
        If fbDr.Read Then
            info(0) = fbDr.GetInt64(0)
            info(1) = fbDr.GetInt64(1)
        Else
            info(0) = 0
            info(1) = 0
        End If
        fbDr.Close()
        fbCmd.Dispose()
        Return info
    End Function
    Public Function GetProvedorId(rfc As String) As Long
        Dim sql As String
        Dim fbCmd As New FbCommand
        Dim fbDr1 As FbDataReader
        sql = "SELECT PROVEEDOR_ID FROM PROVEEDORES WHERE UPPER(RFC_CURP)='" & UCase(rfc) & "'"
        fbCmd.Connection = FbCon
        fbCmd.CommandText = sql
        fbDr1 = fbCmd.ExecuteReader
        If fbDr1.Read Then
            If Not fbDr1.GetValue(0) Is DBNull.Value Then
                Return fbDr1.GetInt64(0)
            Else
                Return 0
            End If
        Else
            Return 0
        End If
        fbDr1.Close()
        fbCmd.Dispose()
    End Function
    Public Function GetCondPagoId(rfc As String) As Long
        Dim sql As String
        Dim fbCmd As New FbCommand
        Dim fbDr1 As FbDataReader
        sql = "SELECT PROVEEDOR_ID FROM PROVEEDORES WHERE UPPER(RFC_CURP)='" & UCase(rfc) & "'"
        fbCmd.Connection = FbCon
        fbCmd.CommandText = sql
        fbDr1 = fbCmd.ExecuteReader
        If fbDr1.Read Then
            If Not fbDr1.GetValue(0) Is DBNull.Value Then
                Return fbDr1.GetInt64(0)
            Else
                Return 0
            End If
        Else
            Return 0
        End If
        fbDr1.Close()
        fbCmd.Dispose()
    End Function
    Public Function GetArticuloProvedorId(proveedor_id As Long) As Long
        Dim sql As String
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        sql = "select articulo_id from sol_proveedor_articulo where proveedor_id=" & proveedor_id
        fbCmd.Connection = FbCon
        fbCmd.CommandText = sql
        fbDr = fbCmd.ExecuteReader
        If fbDr.Read Then
            Return fbDr.GetInt64(0)
        Else
            Return 0
        End If
        fbDr.Close()
        fbCmd.Dispose()
    End Function
    Public Sub GuardarClaveCatSec(elem_id As Long, clave As String, nombre_tabla As String)
        Dim sql As String
        Dim fbCmd As New FbCommand
        sql = "INSERT INTO CLAVES_CAT_SEC(ELEM_ID,NOMBRE_TABLA,CLAVE) VALUES(" & elem_id & ",'" & nombre_tabla & "','" & clave & "')"
        fbCmd.Connection = FbCon
        fbCmd.CommandText = sql
        fbCmd.ExecuteNonQuery()
        fbCmd.Dispose()
    End Sub
    Public Function GetMonedaId(clave_fiscal As String) As Long
        Dim sql As String
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        sql = "select moneda_id from monedas where clave_fiscal='" & clave_fiscal & "'"
        fbCmd.Connection = FbCon
        fbCmd.CommandText = sql
        fbDr = fbCmd.ExecuteReader
        If fbDr.Read Then
            Return fbDr.GetInt64(0)
        Else
            Return 0
        End If
        fbDr.Close()
        fbCmd.Dispose()
    End Function
    Public Function GetSolAlmacenId(almacen_id As Long) As Long
        Dim sql As String
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        sql = "SELECT ALMACEN_ID FROM SOL_ALMACENES WHERE ALMACEN_ID=" & almacen_id
        fbCmd.Connection = FbCon
        fbCmd.CommandText = sql
        fbDr = fbCmd.ExecuteReader
        If fbDr.Read Then
            Return fbDr.GetInt64(0)
        Else
            Return 0
        End If
        fbDr.Close()
        fbCmd.Dispose()
    End Function
    Public Function GetNombreMoneda(clave_fiscal As String) As String
        Dim sql As String
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        sql = "select nombre from monedas where clave_fiscal='" & clave_fiscal & "'"
        fbCmd.Connection = FbCon
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
    Public Sub LlenarCmbMeses(cmb As ComboBox)
        cmb.Items.Clear()
        cmb.Items.Add(New ItemData("Enero", 1))
        cmb.Items.Add(New ItemData("Febrero", 2))
        cmb.Items.Add(New ItemData("Marzo", 3))
        cmb.Items.Add(New ItemData("Abril", 4))
        cmb.Items.Add(New ItemData("Mayo", 5))
        cmb.Items.Add(New ItemData("Junio", 6))
        cmb.Items.Add(New ItemData("Julio", 7))
        cmb.Items.Add(New ItemData("Agosto", 8))
        cmb.Items.Add(New ItemData("Septiembre", 9))
        cmb.Items.Add(New ItemData("Octubre", 10))
        cmb.Items.Add(New ItemData("Noviembre", 11))
        cmb.Items.Add(New ItemData("Diciembre", 12))
        cmb.SelectedIndex = 0
    End Sub
    Public Sub LlenarCmb(cmb As ComboBox, sql As String)
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        fbCmd.Connection = FbCon
        fbCmd.CommandText = sql
        fbDr = fbCmd.ExecuteReader
        cmb.Items.Clear()
        While fbDr.Read
            cmb.Items.Add(New ItemData(Trim(fbDr.GetString(0)), fbDr.GetInt64(1)))
            fbDr.NextResult()
        End While
        If cmb.Items.Count() > 0 Then cmb.SelectedIndex = 0
        fbCmd.Dispose()
        fbDr.Close()
    End Sub
    Public Sub LlenarCmb(cmb As ToolStripComboBox, sql As String)
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        fbCmd.Connection = FbCon
        fbCmd.CommandText = sql
        fbDr = fbCmd.ExecuteReader
        cmb.Items.Clear()
        While fbDr.Read
            cmb.Items.Add(New ItemData(fbDr.GetString(0), fbDr.GetInt64(1)))
            fbDr.NextResult()
        End While
        If cmb.Items.Count() > 0 Then cmb.SelectedIndex = 0
        fbCmd.Dispose()
        fbDr.Close()
    End Sub
    Public Sub LlenarCmbStr(cmb As ComboBox, sql As String)
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        fbCmd.Connection = FbCon
        fbCmd.CommandText = sql
        fbDr = fbCmd.ExecuteReader
        cmb.Items.Clear()
        While fbDr.Read
            cmb.Items.Add(New ItemDataS(fbDr.GetString(0), fbDr.GetString(1)))
            fbDr.NextResult()
        End While
        If cmb.Items.Count() > 1 Then
            cmb.SelectedIndex = 1
        ElseIf cmb.Items.Count() > 0 Then
            cmb.SelectedIndex = 0
        End If
        fbCmd.Dispose()
        fbDr.Close()
    End Sub
    Public Sub SeleccionarCmbByNombre(cmb As ComboBox, nombre As String)
        Dim i, indice As Integer
        With cmb
            For i = 0 To cmb.Items.Count() - 1
                .SelectedIndex = i
                If .SelectedItem.nombre = nombre Then
                    indice = i
                End If
            Next i
            If cmb.Items.Count() > 0 Then cmb.SelectedIndex = indice
        End With
    End Sub
    Public Sub SeleccionarCmbByNombre2(cmb As ComboBox, nombre As String)
        Dim i, indice As Integer
        With cmb
            For i = 0 To cmb.Items.Count() - 1
                .SelectedIndex = i
                If .Text = nombre Then
                    indice = i
                End If
            Next i

            If cmb.Items.Count() > 0 Then cmb.SelectedIndex = indice
        End With
    End Sub
    Public Function GetIndexDataGridViewValor(grd As DataGridView, col As Integer, Valor As String) As Integer
        Dim i, indice As Integer
        With grd
            For i = 0 To grd.RowCount - 1
                If grd.Item(col, i).Value.ToString = Valor Then
                    indice = i
                End If
            Next i
            Return indice
        End With
    End Function
    Public Function GetIndexDataGridViewValorParecido(grd As DataGridView, col As Integer, Valor As String) As Integer
        Dim i, indice As Integer
        With grd
            For i = 0 To grd.RowCount - 1
                If InStr(1, grd.Item(col, i).Value.ToString, Valor, CompareMethod.Text) > 0 Then
                    indice = i
                End If
            Next i
            Return indice
        End With
    End Function
    Public Sub SeleccionarCmbByValor(cmb As ComboBox, Valor As Long)
        Dim i, indice As Integer
        With cmb
            For i = 0 To cmb.Items.Count() - 1
                .SelectedIndex = i
                If .SelectedItem.Id = Valor Then
                    indice = i
                End If
            Next i

            If .Items.Count > 0 Then .SelectedIndex = indice
        End With
    End Sub
    Public Sub SeleccionarCmbByValor(cmb As ToolStripComboBox, Valor As Long)
        Dim i, indice As Integer
        With cmb
            For i = 0 To cmb.Items.Count() - 1
                .SelectedIndex = i
                If .SelectedItem.Id = Valor Then
                    indice = i
                End If
            Next i

            If .Items.Count > 0 Then .SelectedIndex = indice
        End With
    End Sub
    Public Sub SeleccionarCmbByValor(cmb As ComboBox, Valor As String)
        Dim i, indice As Integer
        With cmb

            If Valor <> "" Then
                For i = 0 To cmb.Items.Count() - 1
                    .SelectedIndex = i
                    If .SelectedItem.Id = Valor Then
                        indice = i
                    End If
                Next i
            End If

            If .Items.Count > 0 Then .SelectedIndex = indice
        End With
    End Sub
    Public Sub SeleccionarListByNombre(lst As ListBox, nombre As String)
        Dim i, indice As Integer
        With lst
            For i = 0 To lst.Items.Count() - 1
                .SelectedIndex = i
                If .SelectedItem.ToString = nombre Then
                    indice = i
                End If
            Next i
            If .Items.Count() > 0 Then .SelectedIndex = indice
        End With
    End Sub
    Public Function GetFolioAleatorio() As String
        Dim i As Integer = 1
        Dim folio As String = ""
        Dim num As Integer
        While i <= 9
            num = Rnd() * 100
            If Char.IsLetterOrDigit(Chr(num)) Then
                folio = folio & Chr(num)
                i = i + 1
            End If
        End While
        Return folio
    End Function
    Public Function GetFolioTemp() As String
        Dim sql As String
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        sql = "SELECT FOLIO_TEMP FROM GEN_FOLIO_TEMP_S"
        fbCmd.Connection = FbCon
        fbCmd.CommandText = sql
        fbDr = fbCmd.ExecuteReader
        If fbDr.Read Then
            Return DeFolio(fbDr.GetString(0))
        Else
            Return "000000000"
        End If
        fbDr.Close()
        fbCmd.Dispose()
    End Function
    Public Function AFolio(folio As String) As String
        Dim letra1, letra2, num1, num2, busca As String
        Dim lon, i, j, num As Long

        num2 = ""
        letra2 = ""
        lon = Len(folio)

        For i = 1 To lon

            For j = 65 To 90

                busca = Mid(folio, i, 1)

                If busca = Chr(j) Then
                    letra1 = Chr(j)
                Else
                    letra1 = ""
                End If

                letra2 = letra2 & letra1

            Next j

        Next i

        '---------------------------------------------------------------------------------------

        For i = 1 To lon

            For j = 48 To 57

                busca = Mid(folio, i, 1)

                If busca = Chr(j) Then
                    num1 = Chr(j)
                Else
                    num1 = ""
                End If

                num2 = num2 & num1

            Next j

        Next i

        num = CLng(num2)

        Return letra2 & num

    End Function
    Public Function ExtraerSerie(folio As String) As String
        Dim letra1, letra2, busca As String
        Dim lon, i, j As Long

        letra2 = ""
        lon = Len(folio)

        For i = 1 To lon

            For j = 65 To 90

                busca = Mid(folio, i, 1)

                If busca = Chr(j) Then
                    letra1 = Chr(j)
                Else
                    letra1 = ""
                End If

                letra2 = letra2 & letra1

            Next j

        Next i


        ExtraerSerie = letra2

    End Function
    Public Function ExtraerFolio(folio As String) As Long
        Dim num1, num2, busca As String
        Dim lon, i, j, num As Long

        num2 = ""
        lon = Len(folio)

        For i = 1 To lon

            For j = 48 To 57

                busca = Mid(folio, i, 1)

                If busca = Chr(j) Then
                    num1 = Chr(j)
                Else
                    num1 = ""
                End If

                num2 = num2 & num1

            Next j

        Next i

        num = CLng(num2)

        ExtraerFolio = num

    End Function

    Public Function DeFolio(folio As String) As String
        Dim letra1, letra2, num1, num2, num3, busca As String
        Dim lon, i, j, num, lonletra, lonnum, lontotal, dif As Long

        num2 = ""
        letra2 = ""
        lon = Len(folio)

        For i = 1 To lon

            For j = 65 To 90

                busca = Mid(folio, i, 1)

                If busca = Chr(j) Then
                    letra1 = Chr(j)
                Else
                    letra1 = ""
                End If

                letra2 = letra2 & letra1

            Next j

        Next i

        '---------------------------------------------------------------------------------------

        For i = 1 To lon

            For j = 48 To 57

                busca = Mid(folio, i, 1)

                If busca = Chr(j) Then
                    num1 = Chr(j)
                Else
                    num1 = ""
                End If

                num2 = num2 & num1

            Next j

        Next i

        num = CLng(num2)
        num3 = ""
        lonletra = Len(letra2)
        lonnum = Len(num2)
        lontotal = lonletra + lonnum
        dif = 9 - lontotal

        If lonletra = 3 Then
            If lonnum = 6 Then
                num3 = letra2 & num
            ElseIf lonnum = 5 Then
                num3 = letra2 & "0" & num
            ElseIf lonnum = 4 Then
                num3 = letra2 & "00" & num
            ElseIf lonnum = 3 Then
                num3 = letra2 & "000" & num
            ElseIf lonnum = 2 Then
                num3 = letra2 & "0000" & num
            ElseIf lonnum = 1 Then
                num3 = letra2 & "00000" & num
            End If
        ElseIf lonletra = 2 Then
            If lonnum = 7 Then
                num3 = letra2 & num
            ElseIf lonnum = 6 Then
                num3 = letra2 & "0" & num
            ElseIf lonnum = 5 Then
                num3 = letra2 & "00" & num
            ElseIf lonnum = 4 Then
                num3 = letra2 & "000" & num
            ElseIf lonnum = 3 Then
                num3 = letra2 & "0000" & num
            ElseIf lonnum = 2 Then
                num3 = letra2 & "00000" & num
            ElseIf lonnum = 1 Then
                num3 = letra2 & "000000" & num
            End If
        ElseIf lonletra = 1 Then
            If lonnum = 8 Then
                num3 = letra2 & num
            ElseIf lonnum = 7 Then
                num3 = letra2 & "0" & num
            ElseIf lonnum = 6 Then
                num3 = letra2 & "00" & num
            ElseIf lonnum = 5 Then
                num3 = letra2 & "000" & num
            ElseIf lonnum = 4 Then
                num3 = letra2 & "0000" & num
            ElseIf lonnum = 3 Then
                num3 = letra2 & "00000" & num
            ElseIf lonnum = 2 Then
                num3 = letra2 & "000000" & num
            ElseIf lonnum = 1 Then
                num3 = letra2 & "0000000" & num
            End If
        ElseIf lonletra = 0 Then
            If lonnum = 9 Then
                num3 = letra2 & num
            ElseIf lonnum = 8 Then
                num3 = letra2 & "0" & num
            ElseIf lonnum = 7 Then
                num3 = letra2 & "00" & num
            ElseIf lonnum = 6 Then
                num3 = letra2 & "000" & num
            ElseIf lonnum = 5 Then
                num3 = letra2 & "0000" & num
            ElseIf lonnum = 4 Then
                num3 = letra2 & "00000" & num
            ElseIf lonnum = 3 Then
                num3 = letra2 & "000000" & num
            ElseIf lonnum = 2 Then
                num3 = letra2 & "0000000" & num
            ElseIf lonnum = 1 Then
                num3 = letra2 & "00000000" & num
            End If
        End If

        DeFolio = num3

    End Function

    Public Function AjustarFolio(folio As String) As String
        Dim lon As Integer

        lon = Len(folio)

        If lon = 1 Then
            Return folio & "        "
        ElseIf lon = 2 Then
            Return folio & "       "
        ElseIf lon = 3 Then
            Return folio & "      "
        ElseIf lon = 4 Then
            Return folio & "     "
        ElseIf lon = 5 Then
            Return folio & "    "
        ElseIf lon = 6 Then
            Return folio & "   "
        ElseIf lon = 7 Then
            Return folio & "  "
        ElseIf lon = 8 Then
            Return folio & " "
        ElseIf lon = 9 Then
            Return folio
        Else
            Return ""
        End If

    End Function
    Public Function ConvertirFecha2(fecha As String) As String
        Dim dia, mes As String
        Dim dia1, mes1, anio1 As Integer

        anio1 = Mid(fecha, 1, 4)
        mes1 = Mid(fecha, 6, 2)
        dia1 = Mid(fecha, 9, 2)

        If dia1 < 10 Then
            dia = "0" & dia1
        Else
            dia = dia1
        End If

        If mes1 < 10 Then
            mes = "0" & mes1
        Else
            mes = mes1
        End If

        Return mes & "/" & dia & "/" & anio1

    End Function
    Public Function ConvertirFecha(fecha As String) As String
        Dim dia, mes As String
        Dim dia1, mes1, anio1 As Integer

        dia1 = Mid(fecha, 1, 2)
        mes1 = Mid(fecha, 4, 2)
        anio1 = Mid(fecha, 7, 4)

        If dia1 < 10 Then
            dia = "0" & dia1
        Else
            dia = dia1
        End If

        If mes1 < 10 Then
            mes = "0" & mes1
        Else
            mes = mes1
        End If

        ConvertirFecha = mes & "/" & dia & "/" & anio1

    End Function
    Public Function GetFechaAñoActual(fecha1 As String, fecha2 As String) As String
        Dim dia, mes As String
        Dim dia1, mes1, anio1 As Integer

        dia1 = Mid(fecha1, 1, 2)
        mes1 = Mid(fecha1, 4, 2)
        anio1 = Mid(fecha2, 7, 4)

        If dia1 < 10 Then
            dia = "0" & dia1
        Else
            dia = dia1
        End If

        If mes1 < 10 Then
            mes = "0" & mes1
        Else
            mes = mes1
        End If

        Return mes & "/" & dia & "/" & anio1

    End Function
    Public Function ConvertirFechaHora(fecha As Date) As String
        Dim h, m, s, d, mm, a As String
        Dim h1, m1, s1, d1, mm1, a1 As Integer

        d1 = fecha.Day
        mm1 = fecha.Month
        a1 = fecha.Year

        h1 = DateAndTime.Hour(fecha)
        m1 = DateAndTime.Minute(fecha)
        s1 = DateAndTime.Second(fecha)

        If h1 < 10 Then h = "0" & h1 Else h = h1
        If m1 < 10 Then m = "0" & m1 Else m = m1
        If s1 < 10 Then s = "0" & s1 Else s = s1

        If d1 < 10 Then d = "0" & d1 Else d = d1
        If mm1 < 10 Then mm = "0" & mm1 Else mm = mm1
        If a1 < 10 Then a = "0" & a1 Else a = a1
        Return mm & "/" & d & "/" & a & " " & h & ":" & m & ":" & s

    End Function
    Public Function GetComa(palabra As String) As String
        GetComa = Chr(34) & palabra & Chr(34)
    End Function
    Public Sub LlenarLstFormas(lst As ListBox, tipo As String)
        Dim archivo, ruta As String
        ruta = Leer_ini(Path_archivo_ini, APpLICATION, "ruta_formas", "") & "\" & tipo & "\*.frx"
        With lst
            .Items.Clear()
            archivo = Dir(ruta)
            If archivo <> "" Then
                .Items.Add(System.IO.Path.GetFileNameWithoutExtension(archivo))
                While archivo <> ""
                    archivo = Dir()
                    If archivo <> "" Then
                        .Items.Add(System.IO.Path.GetFileNameWithoutExtension(archivo))
                    End If
                End While
                If .Items.Count <> 0 Then
                    .SelectedIndex = 0
                End If
            End If
        End With
    End Sub


    Public Sub LlenarCmbArchivo(ruta As String, cmb As ComboBox)
        Dim lineas, linea, codigo, nombre As String
        Dim lon, j, i, k, l As Integer
        lineas = My.Computer.FileSystem.ReadAllText(ruta)
        lon = Len(lineas)
        codigo = ""
        j = 1
        i = 1
        While j < lon
            l = InStr(j, lineas, vbCrLf)
            If l > 0 Then
                k = l
                linea = Trim(Mid(lineas, j, k - j))
                j = k + 2
                codigo = Mid(linea, 1, InStr(linea, "|", CompareMethod.Text) - 1)
                nombre = Mid(linea, InStr(linea, "|", CompareMethod.Text) + 1, InStr(InStr(linea, "|", CompareMethod.Text) + 1, linea, "|", CompareMethod.Text) - InStr(linea, "|", CompareMethod.Text) - 1)
                cmb.Items.Add(New ItemDataS(codigo, nombre))
            Else
                k = lon - j
                linea = Trim(Mid(lineas, j, k + 1))
                j = lon
            End If
        End While
        If cmb.Items.Count > 0 Then cmb.SelectedIndex = 0
    End Sub

    '    Public Sub EnviarCorreo(direccion As String, asunto As String, mensaje As String, orden_trabajo_id As Long, reporte As String)
    '        On Error GoTo fn_err
    '        Dim correo, servidor, pass, puerto, remitente, ruta As String
    '        Dim reg As New Registry
    '        servidor = reg.Servidor
    '        remitente = reg.Remitente
    '        correo = reg.Usuario
    '        pass = reg.Contraseña
    '        puerto = reg.Puerto
    '        Dim ssl As Integer = 0
    '        If reg.Usar_ssl = "True" Then ssl = 1 Else ssl = 0

    '        If direccion <> "" Then
    '            Dim email = New Email.EmailExport

    '            email.Account.Address = correo
    '            email.Account.Name = remitente
    '            email.Account.Host = servidor
    '            email.Account.Port = puerto
    '            email.Account.UserName = correo
    '            email.Account.Password = pass
    '            email.Account.MessageTemplate = ""
    '            email.Account.EnableSSL = ssl

    '            email.Address = direccion
    '            email.Subject = asunto
    '            email.MessageBody = mensaje

    '            If reporte <> "" Then
    '                Dim rep = New Report
    '                rep.SetParameterValue("cn", CNXSTRING)
    '                rep.SetParameterValue("orden_id", orden_trabajo_id)
    '                rep.Prepare()
    '                Dim pdf = New Pdf.PDFExport()
    '                pdf.SetName("ORDEN DE TRABAJO GRUPO MG & M")
    '                email.Export = pdf
    '                email.SendEmail(rep)
    '            End If
    '            email.SendEmail()
    '            MsgBox("La orden de trabajo fue enviada correctamente.", vbInformation)
    '        Else
    '            MsgBox("No hay alguna dirección para el envío.", vbInformation)
    '        End If
    '        Exit Sub
    'fn_err:
    '        MsgBox("Ocurrió un error: " & Err.Number & " " & Err.Description)
    '    End Sub
    Public Sub ImprimirFormaEtiqueta(imprimir As Boolean, impresora As String, reporte As String, proceso_id As Long, docto_cm_det_id As Long)
        Dim rp As New Report
        'On Error GoTo err_fn
        If reporte <> "" Then
            'MsgBox(CNXSTRING)
            rp.Load(reporte)
            rp.SetParameterValue("cn", CNXSTRING)
            rp.SetParameterValue("proceso_id", proceso_id)
            rp.SetParameterValue("docto_cm_det_id", docto_cm_det_id)
            If imprimir = False Then
                rp.Show()
            Else
                rp.PrintSettings.Printer = impresora
                rp.Print()
            End If
        Else
            MsgBox("la ruta de reportes no es válida", MsgBoxStyle.Critical)
        End If
        Exit Sub
err_fn:
        MsgBox(Err.Description)
    End Sub
    Public Sub ImprimirFormaEtiquetas(imprimir As Boolean, impresora As String, reporte As String, proceso_id As Long)
        Dim rp As New Report
        On Error GoTo err_fn
        If reporte <> "" Then
            'MsgBox(CNXSTRING)
            rp.Load(reporte)
            rp.SetParameterValue("cn", CNXSTRING)
            rp.SetParameterValue("proceso_id", proceso_id)
            If imprimir = False Then
                rp.Show()
            Else
                rp.PrintSettings.Printer = impresora
                rp.Print()
            End If
        Else
            MsgBox("la ruta de reportes no es válida", MsgBoxStyle.Critical)
        End If
        Exit Sub
err_fn:
        MsgBox(Err.Description)
    End Sub
    Public Sub ImprimirForma(imprimir As Boolean, impresora As String, reporte As String, prorrateo_id As Long)
        Dim rp As New Report
        On Error GoTo err_fn
        If reporte <> "" Then
            'MsgBox(CNXSTRING)
            rp.Load(reporte)
            rp.SetParameterValue("conn", CNXSTRING)
            rp.SetParameterValue("prorrateo_id", prorrateo_id)
            If imprimir = False Then
                rp.Show()
            Else
                rp.PrintSettings.Printer = impresora
                rp.Print()
            End If
        Else
            MsgBox("la ruta de reportes no es válida", MsgBoxStyle.Critical)
        End If
        Exit Sub
err_fn:
        MsgBox(Err.Description)
    End Sub
    Public Sub ImprimirSimulacionCalculoCosto(imprimir As Boolean, simulacion_id As Long)
        Dim rp As New Report
        Dim reporte As String
        'On Error GoTo err_fn
        reporte = Leer_ini(Path_archivo_ini, APpLICATION, "ruta_reportes", "") & "SIMULACION DE CALCULO DE COSTOS.frx"
        If reporte <> "" Then
            rp.Load(reporte)
            rp.SetParameterValue("cn", CNXSTRING)
            rp.SetParameterValue("SIMULACION_ID", simulacion_id)
            rp.Show()
        Else
            MsgBox("la ruta de reportes no es válida", MsgBoxStyle.Critical)
        End If
        Exit Sub
err_fn:
        MsgBox(Err.Description)
    End Sub
    Public Sub ImprimirListadoOrdenes(imprimir As Boolean, orden_prod_id As Long)
        Dim rp As New Report
        Dim reporte As String
        On Error GoTo err_fn
        reporte = Leer_ini(Path_archivo_ini, APpLICATION, "ruta_formas", "") & "\LISTADO DE ORDENES DE TRABAJO.frx"
        If reporte <> "" Then
            rp.Load(reporte)
            rp.SetParameterValue("cn", CNXSTRING)
            rp.SetParameterValue("orden_prod_id", orden_prod_id)

            rp.Show()
        Else
            MsgBox("la ruta de reportes no es válida", MsgBoxStyle.Critical)
        End If
        Exit Sub
err_fn:
        MsgBox(Err.Description)
    End Sub
    Public Sub ImprimirListaMateriales(imprimir As Boolean, orden_prod_id As Long)
        Dim rp As New Report
        Dim reporte As String
        On Error GoTo err_fn
        reporte = Leer_ini(Path_archivo_ini, APpLICATION, "ruta_formas", "") & "\LISTA DE MATERIALES.frx"
        If reporte <> "" Then
            rp.Load(reporte)
            rp.SetParameterValue("cn", CNXSTRING)
            rp.SetParameterValue("orden_prod_id", orden_prod_id)

            rp.Show()
        Else
            MsgBox("la ruta de reportes no es válida", MsgBoxStyle.Critical)
        End If
        Exit Sub
err_fn:
        MsgBox(Err.Description)
    End Sub
    Public Sub ImprimirRregistroProduccion(imprimir As Boolean, reg_prod_id As Long)
        Dim rp As New Report
        Dim reporte As String
        On Error GoTo err_fn
        reporte = Leer_ini(Path_archivo_ini, APpLICATION, "ruta_formas", "") & "\REGISTRO DE PRODUCCION.frx"
        If reporte <> "" Then
            rp.Load(reporte)
            rp.SetParameterValue("cn", CNXSTRING)
            rp.SetParameterValue("reg_prod_id", reg_prod_id)
            rp.Show()
        Else
            MsgBox("la ruta de reportes no es válida", MsgBoxStyle.Critical)
        End If
        Exit Sub
err_fn:
        MsgBox(Err.Description)
    End Sub
    Public Sub ImprimirSugerenciaCompras(imprimir As Boolean, orden_prod_id As Long)
        Dim rp As New Report
        Dim reporte As String
        On Error GoTo err_fn
        reporte = Leer_ini(Path_archivo_ini, APpLICATION, "ruta_formas", "") & "\SUGERENCIA DE COMPRA.frx"
        If reporte <> "" Then
            rp.Load(reporte)
            rp.SetParameterValue("cn", CNXSTRING)
            rp.SetParameterValue("orden_prod_id", orden_prod_id)

            rp.Show()
        Else
            MsgBox("la ruta de reportes no es válida", MsgBoxStyle.Critical)
        End If
        Exit Sub
err_fn:
        MsgBox(Err.Description)
    End Sub
    Public Sub ImprimirPropuestaFabricacion(imprimir As Boolean, propuesta_fabr_id As Long)
        Dim rp As New Report
        Dim reporte As String
        On Error GoTo err_fn
        reporte = Leer_ini(Path_archivo_ini, APpLICATION, "ruta_formas", "") & "\PROPUESTA DE FABRICACION.frx"
        If reporte <> "" Then
            rp.Load(reporte)
            rp.SetParameterValue("cn", CNXSTRING)
            rp.SetParameterValue("prop_fabr_id", propuesta_fabr_id)

            rp.Show()
        Else
            MsgBox("la ruta de reportes no es válida", MsgBoxStyle.Critical)
        End If
        Exit Sub
err_fn:
        MsgBox(Err.Description)
    End Sub
    Public Function replaceAnsi(cadena As String) As String
        Dim Encw1252 As Encoding = Encoding.GetEncoding("windows-1252")
        Dim EncUTF8 As Encoding = Encoding.GetEncoding("utf-8")
        Dim Str As String

        'Convert UTF8-encoded clipboard to Windows1252
        Str = Encw1252.GetString(Encoding.Convert(EncUTF8, Encw1252, Encoding.Default.GetBytes(cadena)))

        'Replace some faulty bits
        Dim builder As New StringBuilder(Str)
        builder.Replace("? ", "à")
        Str = builder.ToString

        'Copy converted text back to clipboard
        replaceAnsi = Str

    End Function


    Public Sub GuardarConfForm(formulario As Form)
        With formulario
            Grabar_ini(Path_archivo_ini, APPLICATION, formulario.Name & "_w", .Width)
            Grabar_ini(Path_archivo_ini, APPLICATION, formulario.Name & "_h", .Height)
            Grabar_ini(Path_archivo_ini, APPLICATION, formulario.Name & "_x", .Location.X)
            Grabar_ini(Path_archivo_ini, APPLICATION, formulario.Name & "_y", .Location.Y)
        End With
    End Sub
    Public Sub CargarConfForm(formulario As Form)
        Dim w As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim h As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim w1 As Integer = Leer_ini(Path_archivo_ini, APPLICATION, formulario.Name & "_w", 1000)
        Dim h1 As Integer = Leer_ini(Path_archivo_ini, APPLICATION, formulario.Name & "_h", 1000)
        If w1 > w And h1 > h Then
            w1 = w
            h1 = h
        End If
        Dim x As Integer = Leer_ini(Path_archivo_ini, APpLICATION, formulario.Name & "_x", 10)
        Dim y As Integer = Leer_ini(Path_archivo_ini, APpLICATION, formulario.Name & "_y", 10)
        If x < 0 Then x = 10
        If y < 0 Then y = 10
        With formulario
            .SetBounds(x, y, w1, h1)
        End With
    End Sub
    Public Sub GuardarConfFormGrid(grd As DataGridView)
        Dim col As DataGridViewColumnCollection
        Dim i As Integer
        With grd
            col = grd.Columns
            For i = 0 To .Columns.Count - 1
                Grabar_ini(Path_archivo_ini, APpLICATION, grd.Name & "_w_" & col(i).Name, col(i).Width)
                'Grabar_ini(Path_archivo_ini, APpLICATION, grd.Name & "_ht_" & col(i).Name, col(i).HeaderText)
            Next i
        End With
    End Sub
    Public Sub CargarConfFormGrid(grd As DataGridView)
        Dim col As DataGridViewColumnCollection
        Dim i As Integer
        With grd
            col = .Columns
            For i = 0 To .Columns.Count - 1
                col(i).Width = Leer_ini(Path_archivo_ini, APpLICATION, grd.Name & "_w_" & col(i).Name, 50)
                'col(i).HeaderText = Leer_ini(Path_archivo_ini, APPLICATION, grd.Name & "_ht_" & col(i).Name, "col" & i)
                If i = 0 Then col(i).Visible = False
            Next i
        End With
    End Sub

    Public Sub SeleccionarValorGrid(grd As DataGridView, col As Integer, valor As String)
        Dim i, indice As Integer
        With grd
            For i = 0 To grd.RowCount - 1
                If grd.Item(col, i).Value = valor Then
                    indice = i
                End If
            Next i
            .FirstDisplayedScrollingRowIndex = i
            .Rows(i).Selected = True
        End With
    End Sub
    Public Sub LlenarfrmPermisos()

        With frmPermisos.chlPermisos
            .Items.Add(New ItemData("Catálogos", 10), False)
            .Items.Add(New ItemData(" Catálogo", 100), False)
            .Items.Add(New ItemData("  Nuevo", 101), False)
            .Items.Add(New ItemData("  Abrir", 102), False)
            .Items.Add(New ItemData("  Editar", 103), False)
            .Items.Add(New ItemData("  Eliminar", 104), False)

            .Items.Add(New ItemData("Movimientos", 20), False)
            .Items.Add(New ItemData(" Movimiento", 200), False)
            .Items.Add(New ItemData("  Nuevo", 201), False)
            .Items.Add(New ItemData("  Abrir", 202), False)
            .Items.Add(New ItemData("  Editar", 203), False)
            .Items.Add(New ItemData("  Eliminar", 204), False)

            .SelectedIndex = 0
        End With
    End Sub
    Public Sub CargarPermisosUsuario(usuario_id As Long)
        Dim i1 As Long

        With frmPermisos.chlPermisos
            For i1 = 0 To .Items.Count - 1
                .SelectedIndex = i1
                If TienePermisoUsuario(usuario_id, .SelectedItem.Id) = True Then
                    .SetItemChecked(i1, True)
                Else
                    .SetItemChecked(i1, False)
                End If
            Next i1
        End With
    End Sub
    Public Function TienePermisoUsuario(ByVal usuario_id As Long, funcion_id As Long) As Boolean
        Dim sql1 As String
        Dim fbDr As FbDataReader
        Dim fbCmd As New FbCommand

        sql1 = "Select funcion_id from sol_permisos where usuario_id=" & usuario_id & " And funcion_id=" & funcion_id
        fbCmd.Connection = FbCon
        fbCmd.CommandText = sql1
        fbDr = fbCmd.ExecuteReader
        If fbDr.Read Then
            Return True
        Else
            Return False
        End If
        fbDr.Close()
        fbCmd.Dispose()
    End Function

    Public Sub InsertaPermisoUsuario(usuario_id As Long, funcion_id As Long)
        Dim sql1 As String
        Dim fbCmd As New FbCommand
        sql1 = "insert into sol_permisos values(" & GenCatalogoID() & "," & usuario_id _
        & "," & funcion_id & ")"
        fbCmd.Connection = FbCon
        fbCmd.CommandText = sql1
        fbCmd.ExecuteNonQuery()
    End Sub
    Public Sub EliminarPermisosUsuario(usuario_id As Long)
        Dim sql1 As String
        Dim fbCmd As New FbCommand
        sql1 = "delete from sol_permisos where usuario_id=" & usuario_id
        fbCmd.Connection = FbCon
        fbCmd.CommandText = sql1
        fbCmd.ExecuteNonQuery()
    End Sub

    Public Sub EliminaPermisoUsuario(usuario_id As Long, funcion_id As Long)
        Dim sql1 As String
        Dim fbCmd As New FbCommand
        sql1 = "delete from sol_permisos where usuario_id=" & usuario_id & " And funcion_id=" & funcion_id
        fbCmd.Connection = FbCon
        fbCmd.CommandText = sql1
        fbCmd.ExecuteNonQuery()
    End Sub

    Public Sub ActualizaPermisosUsuario(usuario_id As Long)
        Dim i1 As Long
        With frmPermisos.chlPermisos
            For i1 = 0 To .Items.Count - 1
                .SelectedIndex = i1
                If .GetItemChecked(i1) = True And TienePermisoUsuario(usuario_id, .SelectedItem.id) = False Then
                    InsertaPermisoUsuario(usuario_id, .SelectedItem.id)
                ElseIf .GetItemChecked(i1) = False And TienePermisoUsuario(usuario_id, .SelectedItem.Id) = True Then
                    EliminaPermisoUsuario(usuario_id, .SelectedItem.id)
                End If
            Next i1
        End With
    End Sub
    Public Sub LlenarCmbColumna(grd As DataGridView, sql As String, columna As Integer, fila As Integer)
        Dim cmb = New DataGridViewComboBoxCell
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        fbCmd.Connection = FbCon
        fbCmd.CommandText = sql
        fbDr = fbCmd.ExecuteReader
        cmb.Items.Clear()
        While fbDr.Read
            If fbDr.GetString(0) <> "" Then cmb.Items.Add(Trim(fbDr.GetString(0)))
            fbDr.NextResult()
        End While
        If cmb.Items.Count > 0 Then cmb.Items.IndexOf(0)
        grd(columna, fila) = cmb
        fbDr.Close()
        fbCmd.Dispose()
    End Sub
    Public Function GetValorRegistry(nombre) As String
        Dim sql As String
        Dim fbCmd As New FbCommand
        Dim fbDr As FbDataReader
        fbCmd.Connection = FbCon

        sql = "select valor from registry where nombre='" & nombre & "'"
        fbCmd.CommandText = sql
        fbDr = fbCmd.ExecuteReader
        If fbDr.Read Then
            If Not fbDr.GetValue(0) Is DBNull.Value Then
                Return fbDr.GetString(0)
            Else
                Return ""
            End If
        Else
            Return ""
        End If
    End Function
    Public Sub SetValorRegistry(nombre As String, valor As String)
        Dim sql1 As String
        Dim fbCmd As New FbCommand
        sql1 = "UPDATE REGISTRY SET VALOR=" & valor & " WHERE NOMBRE='" & nombre & "'"
        fbCmd.Connection = FbCon
        fbCmd.CommandText = sql1
        fbCmd.ExecuteNonQuery()
    End Sub

    Public Sub LlenarAutoComplete(auto As AutoCompleteStringCollection, sql As String)
        Dim fbDr As FbDataReader
        Dim fbCmd As New FbCommand

        fbCmd.Connection = FbCon
        fbCmd.CommandText = sql
        fbDr = fbCmd.ExecuteReader
        auto.Clear()
        While fbDr.Read
            auto.Add(fbDr.GetString(0))
            fbDr.NextResult()
        End While
        fbDr.Close()
        fbCmd.Dispose()
       
    End Sub

    Public Function GetTipoPeriodo(formulario As String) As String
        Dim periodo As String

        periodo = Leer_ini(Path_archivo_ini, APpLICATION, formulario, "")
        If Len(periodo) >= 2 Then
            GetTipoPeriodo = Mid(periodo, 1, InStr(1, periodo, "|", vbTextCompare) - 1)
        Else
            GetTipoPeriodo = 0
        End If
    End Function
    Public Function GetP1(formulario As String) As String
        Dim periodo, tipo As String
        periodo = Leer_ini(Path_archivo_ini, APpLICATION, formulario, "")
        tipo = GetTipoPeriodo(formulario)
        If tipo = "H" Or tipo = "P" Then
            If Len(periodo) >= 14 Then
                Return Mid(periodo, 3, InStr(3, periodo, "|", vbTextCompare) - 3)
            Else
                Return FormatDateTime(Today, DateFormat.ShortDate)
            End If
        Else
            Return FormatDateTime(Today, DateFormat.ShortDate)
        End If
    End Function

    Public Function GetP2(formulario As String) As String
        Dim periodo, tipo As String
        periodo = Leer_ini(Path_archivo_ini, APpLICATION, formulario, "")
        tipo = GetTipoPeriodo(formulario)
        If tipo = "H" Or tipo = "P" Then
            If Len(periodo) >= 14 Then
                Return Mid(periodo, 14, Len(periodo) - 13)
            Else
                Return FormatDateTime(Today, DateFormat.ShortDate)
            End If
        Else
            Return FormatDateTime(Today, DateFormat.ShortDate)
        End If
    End Function
    Public Sub CargarPeriodoVista(frm As String, txt As ToolStripTextBox)
        Dim tipo, p1, p2 As String

        tipo = GetTipoPeriodo(frm)
        If tipo = "P" Then
            p1 = GetP1(frm)
            p2 = GetP2(frm)
            txt.Text = "Del " & p1 & " al " & p2
        ElseIf tipo = "H" Then
            txt.Text = "El día de hoy " & Date.Today
        Else
            txt.Text = "Todos los movimientos"
        End If


    End Sub
    Public Sub GuardarPeriodoVista(form_actual As String, tipo As String, p1 As String, p2 As String)

        Grabar_ini(Path_archivo_ini, APpLICATION, form_actual, tipo & "|" & p1 & "|" & p2)

    End Sub


    Public Sub CopiarPermisosUsuario(usuario_origen_id As Long, usuario_destino_id As Long)
        Dim sql As String
        Dim fbCmd As New FbCommand
        fbCmd.Connection = FbCon
        sql = "INSERT INTO SOL_PERMISOS (USUARIO_ID, FUNCION_ID) " &
            "SELECT " & usuario_destino_id & ",FUNCION_ID FROM SOL_PERMISOS WHERE USUARIO_ID=" & usuario_origen_id
        fbCmd.CommandText = sql
        fbCmd.ExecuteNonQuery()
        fbCmd.Dispose()
    End Sub
    '    Public Sub LlenarCmbImpresoraFormas()
    '        With frmImprimirForma.cmbImpresora
    '            For Each strPrinter As String In System.Drawing.Printing.PrinterSettings.InstalledPrinters
    '                .Items.Add(strPrinter)
    '            Next
    '            If .Items.Count > 0 Then
    '                .SelectedIndex = 0
    '            End If
    '        End With
    '    End Sub
    '    Public Sub ImprimirForma(tipo As String, impresora As String, forma As String, parametro As String, valor As Long, imprimir As Boolean)
    '        Dim rp As New Report
    '        Dim reporte As String
    '        On Error GoTo err_fn

    '        reporte = Leer_ini(Path_archivo_ini, APpLICATION, "ruta_formas", "") & "\" & tipo & "\" & forma & ".frx"
    '        If reporte <> "" Then
    '            rp.Load(reporte)
    '            rp.SetParameterValue("cn", CNXSTRING)
    '            rp.SetParameterValue(parametro, valor)
    '            rp.PrintSettings.ShowDialog = False
    '            rp.PrintSettings.Printer = impresora
    '            If imprimir = False Then
    '                rp.Show()
    '            Else
    '                rp.Print()
    '            End If
    '        Else
    '            MsgBox("la ruta de reportes no es válida", MsgBoxStyle.Critical)
    '        End If
    '        Exit Sub
    'err_fn:
    '        MsgBox(Err.Description)
    '    End Sub
    Public Function GetDouble(importe As String) As Double
        Return Val(Replace(importe, ",", ""))
    End Function
    Public Sub GuardarValorConfig(clave As String, valor As String)
        Dim sql As String
        Dim fbCmd As New FbCommand
        sql = "update registry set valor ='" & valor & "' where nombre='" & clave & "'"
        fbCmd.Connection = FbCon
        fbCmd.CommandText = sql
        fbCmd.ExecuteNonQuery()
        fbCmd.Dispose()
    End Sub
    Public Sub CerrarForms()
        Dim iForm As Integer
        iForm = My.Application.OpenForms.Count
        Do Until iForm = 1 ' Forms(0) es el MDI, ese no lo cerramos
            My.Application.OpenForms.Item(iForm - 1).Close()
            iForm = iForm - 1
        Loop
    End Sub
    Public Function ContarSeleccionados(grd As DataGridView, col As Integer) As Integer
        Dim i, j As Integer
        j = 0
        With grd
            For i = 0 To .Rows.Count - 1
                If .Item(1, i).Value = "S" Then j = j + 1
            Next i
        End With
        Return j
    End Function
    Public Sub SeleccionarTodos(chk As CheckBox, grd As DataGridView, col As Integer)

        If chk.Checked = True Then
            For i = 0 To grd.RowCount - 1
                grd.Item(col, i).Value = "S"
            Next i
            chk.Text = "Deseleccionar todos"
        Else
            For i = 0 To grd.RowCount - 1
                grd.Item(col, i).Value = "N"
            Next i
            chk.Text = "Seleccionar todos"
        End If
    End Sub
    Public Sub EliminaValorBuscado(grd As DataGridView, col As Integer, Valor As String, parecido As Boolean)
        Dim i, indice As Integer
        With grd
            If parecido = False Then
                For i = 0 To grd.RowCount - 1
                    If grd.Item(col, i).Value.ToString = Valor Then
                        indice = i
                    End If
                Next i
            Else
                For i = 0 To grd.RowCount - 1
                    If InStr(1, grd.Item(col, i).Value.ToString, Valor, CompareMethod.Text) > 0 Then
                        indice = i
                    End If
                Next i
            End If
            grd.Rows.RemoveAt(indice)
        End With
    End Sub
    Public Function GenCad(caracter As String, numero As Integer) As String
        Dim i As Integer
        Dim cadena As String = ""
        For i = 1 To numero
            cadena = cadena & caracter
        Next i
        Return cadena
    End Function
    Public Sub SeleccionarValorBuscado(grd As DataGridView, col As Integer, col_sel As Integer, Valor As String, parecido As Boolean)
        Dim i, indice As Integer
        With grd
            If parecido = False Then
                For i = 0 To grd.RowCount - 1
                    If grd.Item(col, i).Value.ToString = Valor Then
                        indice = i
                    End If
                Next i
            Else
                For i = 0 To grd.RowCount - 1
                    If InStr(1, grd.Item(col, i).Value.ToString, Valor, CompareMethod.Text) > 0 Then
                        indice = i
                    End If
                Next i
            End If
            If indice > 0 Then
                grd.FirstDisplayedScrollingRowIndex = indice
                grd.CurrentCell = grd.Rows(indice).Cells(col_sel)
            End If
        End With
    End Sub
    Public Function ExisteValorBuscado(grd As DataGridView, col As Integer, fila_actual As Integer, Valor As String) As Boolean
        Dim i, existe As Integer
        With grd

            For i = 0 To grd.RowCount - 2
                If InStr(1, grd.Item(col, i).Value, Valor, CompareMethod.Text) > 0 And i <> fila_actual Then
                    existe = existe + 1
                End If
            Next i
            If existe > 0 And grd.RowCount > 2 Then
                Return True
            Else
                Return False
            End If
        End With
    End Function
    Public Function GetTotalesGrid(grd As DataGridView, col As Integer) As Double
        With grd
            Dim total As Double = 0
            Dim i As Integer
            For i = 0 To .Rows.Count - 1
                total = total + CDbl(.Item(col, i).Value)
            Next i
            Return total
        End With
    End Function
    Public Sub SeleccionarValorBuscado(grd As DataGridView, col As Integer, Valor As String, parecido As Boolean)
        Dim i, indice As Integer
        With grd
            If parecido = False Then
                For i = 0 To grd.RowCount - 1
                    If grd.Item(col, i).Value.ToString = Valor Then
                        indice = i
                    End If
                Next i
            Else
                For i = 0 To grd.RowCount - 1
                    If InStr(1, grd.Item(col, i).Value.ToString, Valor, CompareMethod.Text) > 0 Then
                        indice = i
                    End If
                Next i
            End If
            If indice > 0 Then
                grd.FirstDisplayedScrollingRowIndex = indice
                grd.CurrentCell = grd.Rows(indice).Cells(1)
            End If
        End With
    End Sub
End Module
