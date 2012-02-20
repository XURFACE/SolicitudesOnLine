Imports System.Security.Cryptography
Imports System.Text
Imports System.Net
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Drawing.Drawing2D
Imports System.Web.UI.WebControls

Namespace MP.DW.UTL
    Public Class clsUTL_Helpers
        Declare Function GetUserName Lib "advapi32.dll" Alias "GetUserNameA" (ByVal lpBuffer As String, ByRef nSize As Integer) As Integer
        Public Shared Function CstrMP(ByVal xobjObject As Object) As String
            If IsNothing(xobjObject) Or IsDBNull(xobjObject) Then
                Return ""
            Else
                Return xobjObject
            End If
        End Function

        Public Shared Function CIntMP(ByVal xobjObject As Object) As Integer
            If Not IsNumeric(xobjObject) Or IsDBNull(xobjObject) Or xobjObject.ToString = "" Then
                Return 0
            Else
                Return xobjObject
            End If

        End Function

        Public Shared Function CLngMP(ByVal xobjObject As Object) As Long
            If Not IsNumeric(xobjObject) Or IsDBNull(xobjObject) Or String.IsNullOrEmpty(xobjObject) Then
                Return 0
            Else
                Return xobjObject
            End If
        End Function

        Public Shared Function CuidMP(ByVal xobjObject As Object) As Guid
            If IsNothing(xobjObject) Or IsDBNull(xobjObject) Then
                Return Nothing
            Else
                Return xobjObject
            End If
        End Function

        Public Shared Function CDateMP(ByVal xobjObject As Object) As Nullable(Of Date)
            If IsDBNull(xobjObject) Or xobjObject.ToString = "" Or Not IsDate(xobjObject) Then
                Return Nothing
            Else
                Return CDate(xobjObject)

            End If
        End Function

        Public Shared Function CDblMP(ByVal xobjObject As Object) As Double
            If Not IsNumeric(xobjObject) Or String.IsNullOrEmpty(xobjObject) Or IsDBNull(xobjObject) Then
                Return 0
            Else
                Return xobjObject
            End If

        End Function
        Public Shared Function CBoolMP(ByVal xobjObject As Object) As Nullable(Of Boolean)
            If IsDBNull(xobjObject) Then
                Return Nothing
            Else
                Try
                    If xobjObject.ToString.ToUpper.Equals("TRUE") Then Return True
                    If xobjObject.ToString.ToUpper.Equals("FALSE") Then Return False
                    Return xobjObject
                Catch ex As Exception
                    Return Nothing
                End Try

            End If

        End Function
        Public Shared Function CDecMP(ByVal xobjObject As Object) As Nullable(Of Decimal)
            If IsDBNull(xobjObject) Then
                Return Nothing
            Else
                Return CDec(xobjObject)
            End If

        End Function
        Public Shared Function CstrIgnoreAccentoMP(ByVal xstring As String) As String
            If InStr(xstring.ToUpper, "Á") > 0 Or _
                InStr(xstring.ToUpper, "É") > 0 Or _
                InStr(xstring.ToUpper, "Í") > 0 Or _
                InStr(xstring.ToUpper, "Ó") > 0 Or _
                InStr(xstring.ToUpper, "Ú") > 0 Then
                Return xstring.ToUpper.Replace("Á", "[AÁ]").Replace("É", "[EÉ]").Replace("Í", "[IÍ]").Replace("Ó", "[OÓ]").Replace("Ú", "[UÚ]")
            Else
                Return xstring.ToUpper.Replace("A", "[AÁ]").Replace("E", "[EÉ]").Replace("I", "[IÍ]").Replace("O", "[OÓ]").Replace("U", "[UÚ]")
            End If
        End Function
        Public Shared Function CnullMP(ByVal xstring As String) As Object
            If IsNothing(xstring) Then
                Return DBNull.Value
            Else
                If xstring.Trim().Length.Equals(0) Then Return DBNull.Value Else Return xstring
            End If
        End Function
        Public Shared Function CnullMP(ByVal xInt As Nullable(Of Integer)) As Object
            If Not xInt.HasValue Then
                Return DBNull.Value
            Else
                If xInt.Value.Equals(0) Or xInt.Value.ToString().Trim().Length.Equals(0) Then Return DBNull.Value Else Return xInt.Value
            End If
        End Function
        Public Shared Function CnullMP(ByVal xInt As Integer) As Object
            If IsNothing(xInt) Then
                Return DBNull.Value
            Else
                If (xInt.Equals(0) Or xInt.ToString().Trim().Length.Equals(0)) Then Return DBNull.Value Else Return xInt
            End If
        End Function
        Public Shared Function CnullMP(ByVal xInt64 As Long) As Object
            If (xInt64.CompareTo(Nothing) = 1) Then
                Return DBNull.Value
            Else
                If (xInt64.Equals(0) Or xInt64.ToString().Trim().Length.Equals(0)) Then Return DBNull.Value Else  : Return xInt64
            End If
        End Function
        Public Shared Function CnullMP(ByVal xdate As DateTime) As Object
            If (xdate.CompareTo(Nothing) = 1) Then
                Return DBNull.Value
            Else
                If (xdate.ToString().Trim().Length.Equals(0)) Then Return DBNull.Value Else  : Return xdate
            End If
        End Function
        Public Shared Function CnullMP(ByVal xDouble As Double) As Object
            If (xDouble.CompareTo(Nothing) = 1) Then
                Return DBNull.Value
            Else
                If (xDouble.Equals(0) Or xDouble.ToString().Trim().Length.Equals(0)) Then Return DBNull.Value Else Return xDouble
            End If
        End Function
        Public Shared Function CnullMP(ByVal xBool As Boolean) As Object
            If (xBool.CompareTo(Nothing) = 1) Then
                Return DBNull.Value
            Else
                If (xBool.ToString().Trim().Length.Equals(0)) Then Return DBNull.Value Else Return xBool
            End If
        End Function
        Public Shared Function CBoolDBMP(ByVal xBool As Boolean) As Object
            If (xBool) Then Return "S" Else Return "N"
        End Function

        Public Shared Function crearCarpeta(ByVal xstrRutaIni As String, _
                                            ByRef strmsgOut As String, _
                                            ByVal xlngIdEmp As String) As Boolean
            xstrRutaIni = xstrRutaIni + Now.ToString("yyyy/MM/dd").Replace("/", "\") & "\" & xlngIdEmp
            Try
                If Not System.IO.Directory.Exists(xstrRutaIni) Then
                    System.IO.Directory.CreateDirectory(xstrRutaIni)
                End If
                strmsgOut = xstrRutaIni & "\"
                Return True
            Catch ex As Exception
                strmsgOut = ex.Message
                Return False
            End Try
        End Function

        Public Shared Function crearCarpeta(ByVal xstrRutaIni As String, _
                                            ByRef strmsgOut As String) As Boolean
            xstrRutaIni = xstrRutaIni + Now.ToString("yyyy/MM/dd").Replace("/", "\")
            Try
                If Not System.IO.Directory.Exists(xstrRutaIni) Then
                    System.IO.Directory.CreateDirectory(xstrRutaIni)
                End If
                strmsgOut = xstrRutaIni & "\"
                Return True
            Catch ex As Exception
                strmsgOut = ex.Message
                Return False
            End Try
        End Function

        Public Shared Function crearCarpeta(ByVal xstrRutaIni As String, _
                                            ByRef strmsgOut As String, _
                                            ByVal xlngIdEmp As String, ByVal idProd As String) As Boolean
            xstrRutaIni = xstrRutaIni + Now.ToString("yyyy/MM/dd").Replace("/", "\") & "\" & xlngIdEmp & "\" & idProd
            Try
                If Not System.IO.Directory.Exists(xstrRutaIni) Then
                    System.IO.Directory.CreateDirectory(xstrRutaIni)
                End If
                strmsgOut = xstrRutaIni & "\"
                Return True
            Catch ex As Exception
                strmsgOut = ex.Message
                Return False
            End Try
        End Function

        ''' <summary>
        ''' Obtiene y setea los datos de auditoria al objeto que será ingresado
        ''' </summary>
        ''' <param name="xobj">Entidad a la que se le setearan los datos</param>
        ''' <remarks>se deben heredar el objeto de BE_Base</remarks>
        Public Shared Sub DatosAuditoria(ByRef xobj As Object, ByVal xstrAUD_SERVICIO As String, ByVal xstrUsrGenerico As String)
            Try
                xobj.strAUD_IP_MAQ = GetIP()
                xobj.strAUD_MATRICULA_USR = GetUser()
                xobj.strAUD_NOM_MAQ = GetHostName()
                xobj.strAUD_SERVICIO = xstrAUD_SERVICIO
                xobj.strAUD_USR_GENERICO = xstrUsrGenerico
            Catch ex As Exception
                Throw New Exception("Error al agregar los datos de auditoria :" & ex.Message)
            End Try
        End Sub

        ''' <summary>
        ''' Obtiene el usuario logueado
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetUser() As String
            Dim Ret As Integer
            Dim UserName As String
            Dim Buffer As String
            Buffer = New String(CChar(" "), 25)
            Ret = GetUserName(Buffer, 25)
            UserName = Mid(Buffer, 1, InStr(Buffer, Chr(0)) - 1)
            Return UserName
        End Function

        ''' <summary>
        ''' Obtiene el nombre del equipo
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetHostName() As String
            Dim host_name As String = Dns.GetHostName
            Return host_name
        End Function

        ''' <summary>
        ''' Obtiene el Ip del equipo
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetIP() As String
            Dim host_name As String = Dns.GetHostName
            Dim este_host As IPHostEntry = Dns.GetHostEntry(host_name)
            Return este_host.AddressList(0).ToString
        End Function

        Public Shared Function GenerateRandomCode(ByVal xrandom As Random) As String
            Dim s As String = ""
            For i As Int16 = 0 To 4
                s = String.Concat(s, xrandom.Next(10).ToString())
            Next
            Return s
        End Function

        ''' <summary>
        ''' Llena los combobox(dropdownlist) con el datatable asignado
        ''' </summary>
        ''' <param name="xddlCombo">control al que se llenara los datos</param>
        ''' <param name="xdt">datatable que servira como fuente de datos</param>
        ''' <param name="xstrValue">Columna que servira como dato de valor</param>
        ''' <param name="xstrText">Columna que servira como visible</param>
        ''' <param name="xblnAddTodos">indicador de agregar item "Todos"</param>
        ''' <param name="xblnAddSelOpt">indicador de agregar item "Seleccione opcion"</param>
        ''' <param name="xstrTextOption">Texto alternativo que completara a las opciones "Todos" o "seleccione opcion"</param>
        ''' <param name="xintSelctdIndx">Indice seleccionado por defecto</param>
        ''' <param name="xstrSelctdValue">valor seleccionado por defecto</param>
        ''' <remarks></remarks>
        Public Shared Sub llenacombo(ByVal xddlCombo As DropDownList, ByRef xdt As DataTable, _
                               ByVal xstrValue As String, ByVal xstrText As String, _
                               Optional ByVal xblnAddTodos As Boolean = False, _
                               Optional ByVal xblnAddSelOpt As Boolean = False, _
                               Optional ByVal xstrTextOption As String = "", _
                               Optional ByVal xintSelctdIndx As Integer = 0, _
                               Optional ByVal xstrSelctdValue As String = "")

            If xblnAddTodos Or xblnAddSelOpt Then
                Dim dr = xdt.NewRow
                dr(xstrValue) = "000"
                If xblnAddTodos Then dr(xstrText) = String.Format("------------Todos{0}------------", xstrTextOption)
                If xblnAddSelOpt Then dr(xstrText) = String.Format("------Seleccione{0}------", xstrTextOption)
                xdt.Rows.InsertAt(dr, 0)
            End If
            xddlCombo.SelectedIndex = -1
            xddlCombo.DataSource = xdt
            xddlCombo.DataValueField = xstrValue
            xddlCombo.DataTextField = xstrText
            xddlCombo.DataBind()
            If Not IsNothing(xdt) AndAlso xdt.Rows.Count > 0 Then
                If String.IsNullOrEmpty(xstrSelctdValue) Then
                    xddlCombo.SelectedIndex = xintSelctdIndx
                Else
                    Dim lisit As ListItem = xddlCombo.Items.FindByValue(xstrSelctdValue)
                    If Not IsNothing(lisit) Then xddlCombo.SelectedIndex = xddlCombo.Items.IndexOf(lisit)
                End If
            ElseIf xddlCombo.Items.Count > 0 Then
                xddlCombo.Items.Clear()
            End If
            xdt = Nothing

        End Sub
        ''' <summary>
        ''' Formato de mensaje de error
        ''' </summary>
        ''' <param name="xstrMensaje"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function Formatomsgerr(ByVal ParamArray xstrMensaje() As String) As String
            Dim strb As New StringBuilder
            For Each Str As String In xstrMensaje
                strb.Append(String.Format("<li>{0}</li>", Str))
            Next
            Return String.Format("<div class='messbox'><ul>{0}</ul></div>", strb.ToString)
        End Function
        ''' <summary>
        ''' Filtra un datatable en base a una columna y un valor para esa columna
        ''' </summary>
        ''' <param name="TablaFuente"></param>
        ''' <param name="strCanpoFiltro"></param>
        ''' <param name="strValorFiltro"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function SeleccionFiltro(ByVal TablaFuente As DataTable, _
                                       ByVal strCanpoFiltro As String, _
                                       ByVal strValorFiltro As String) As DataTable
            Dim dv As DataView = TablaFuente.DefaultView
            dv.RowFilter = strCanpoFiltro + "=" + strValorFiltro
            Return dv.ToTable
        End Function

    End Class
    Public Class seguridad
        Public Shared Function Encripta(ByVal Pass As String) As String
            Dim Clave As String, i As Integer, Pass2 As String
            Dim CAR As String, Codigo As String
            Clave = "%�&/@#$A"
            Pass2 = ""
            For i = 1 To Len(Pass)
                CAR = Mid(Pass, i, 1)
                Codigo = Mid(Clave, ((i - 1) Mod Len(Clave)) + 1, 1)
                Pass2 = Pass2 & Right("0" & Hex(Asc(Codigo) Xor Asc(CAR)), 2)
            Next i
            Encripta = Pass2
        End Function
        Public Shared Function DesEncripta(ByVal Pass As String) As String
            Dim Clave As String, i As Integer, Pass2 As String
            Dim CAR As String, Codigo As String
            Dim j As Integer

            Clave = "%�&/@#$A"
            Pass2 = ""
            j = 1
            For i = 1 To Len(Pass) Step 2
                CAR = Mid(Pass, i, 2)
                Codigo = Mid(Clave, ((j - 1) Mod Len(Clave)) + 1, 1)
                Pass2 = Pass2 & Chr(Asc(Codigo) Xor Val("&h" + CAR))
                j = j + 1
            Next i
            DesEncripta = Pass2
        End Function
        Public Shared Function Encripta(ByVal valAlgoritmo As AlgoritmoDeEncriptacion, ByVal strCadena As String, Optional ByVal valIV As Byte = 0, Optional ByVal valKey As Byte = 0) As String
            Dim Codificacion As New UTF8Encoding
            Select Case valAlgoritmo
                Case AlgoritmoDeEncriptacion.MD5
                    Dim md5Hasher As MD5 = MD5.Create()
                    Dim data As Byte() = md5Hasher.ComputeHash(Encoding.Default.GetBytes(
                    strCadena))
                    Dim sBuilder As New StringBuilder()
                    Dim i As Integer
                    For i = 0 To data.Length - 1
                        sBuilder.Append(data(i).ToString("x2"))
                    Next i
                    Return sBuilder.ToString()
                Case AlgoritmoDeEncriptacion.SHA
                    Dim data() As Byte = Codificacion.GetBytes(strCadena)
                    Dim resultado() As Byte
                    Dim sha As New SHA1CryptoServiceProvider()
                    resultado = sha.ComputeHash(data)
                    Dim sb As New StringBuilder
                    For i As Integer = 0 To resultado.Length - 1
                        If resultado(i) < 16 Then
                            sb.Append("0")
                        End If
                        sb.Append(resultado(i).ToString("x"))
                    Next
                    Return sb.ToString() '<-
                Case AlgoritmoDeEncriptacion.TRIPLE_DESC
                    Dim message As Byte() = Codificacion.GetBytes(strCadena)
                    Dim criptoProvider As New TripleDESCryptoServiceProvider
                    Dim criptoTransform As ICryptoTransform = criptoProvider.
                    CreateEncryptor(criptoProvider.Key, criptoProvider.IV)
                    Dim memorystream As New IO.MemoryStream
                    Dim cryptoStream As New CryptoStream(memorystream, criptoTransform, CryptoStreamMode.Write)
                    cryptoStream.FlushFinalBlock()
                    Dim encriptado As Byte() = memorystream.ToArray
                    Dim cadenaEncriptada = Codificacion.GetString(encriptado)
                    Return cadenaEncriptada
                Case Else
                    Return ""
            End Select
        End Function
        Public Enum AlgoritmoDeEncriptacion
            MD5 = 0
            SHA = 1
            TRIPLE_DESC
        End Enum
    End Class
    Public Class CaptchaImage
#Region "Propiedades"
        Private _text As String
        Private _width As Int32
        Private _height As Int32
        Private _familyName As String
        Private _image As Bitmap

        Public ReadOnly Property Text As String
            Get
                Return _text
            End Get
        End Property

        Public ReadOnly Property Image As Bitmap
            Get
                Return _image
            End Get
        End Property

        Public ReadOnly Property Width As Int32
            Get
                Return _width
            End Get
        End Property

        Public ReadOnly Property Height As Int32
            Get
                Return _height
            End Get
        End Property
#End Region
        Private random As Random = New Random()

        '// ====================================================================
        '// Initializes a new instance of the CaptchaImage class using the
        '// specified text, width and height.
        '// ====================================================================
        Sub New(ByVal s As String, ByVal width As Int32, ByVal height As Int32)
            _text = s
            SetDimensions(width, height)
            GenerateImage()
        End Sub

        '// ====================================================================
        '// Initializes a new instance of the CaptchaImage class using the
        '// specified text, width, height and font family.
        '// ====================================================================
        Sub New(ByVal s As String, ByVal width As Int32, ByVal height As Int32, ByVal familyName As String)
            _text = s
            SetDimensions(width, height)
            SetFamilyName(familyName)
            GenerateImage()
        End Sub

        '// ====================================================================
        '// This member overrides Object.Finalize.
        '// ====================================================================
        '~CaptchaImage()
        '{
        '	Dispose(false);
        '}

        '// ====================================================================
        '// Releases all resources used by this object.
        '// ====================================================================
        Public Sub Dispose()
            GC.SuppressFinalize(Me)
            Me.Dispose(True)
        End Sub

        '// ====================================================================
        '// Custom Dispose method to clean up unmanaged resources.
        '// ====================================================================
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                '// Dispose of the bitmap.
                Me.Image.Dispose()
            End If
        End Sub

        '// ====================================================================
        '// Sets the image width and height.
        '// ====================================================================
        Private Sub SetDimensions(ByVal width As Int32, ByVal height As Int32)
            '// Check the width and height.
            If (width <= 0) Then _
                Throw New ArgumentOutOfRangeException("width", width, "Argument out of range, must be greater than zero.")
            If (height <= 0) Then _
                Throw New ArgumentOutOfRangeException("height", height, "Argument out of range, must be greater than zero.")
            _width = width
            _height = height
        End Sub

        '// ====================================================================
        '// Sets the font used for the image text.
        '// ====================================================================
        Private Sub SetFamilyName(ByVal familyName As String)
            '// If the named font is not installed, default to a system font.
            Try
                Dim font As New Font(_familyName, 12.0F)
                _familyName = familyName
                font.Dispose()
            Catch ex As Exception
                _familyName = System.Drawing.FontFamily.GenericSerif.Name
            End Try
        End Sub

        '// ====================================================================
        '// Creates the bitmap image.
        '// ====================================================================
        Private Sub GenerateImage()
            '// Create a new 32-bit bitmap image.
            Dim bitmap As New Bitmap(_width, _height, PixelFormat.Format32bppArgb)

            '// Create a graphics object for drawing.
            Dim g As Graphics = Graphics.FromImage(bitmap)
            g.SmoothingMode = SmoothingMode.AntiAlias
            Dim rect As New Rectangle(0, 0, _width, _height)

            '// Fill in the background.
            Dim hatchBrush As New HatchBrush(HatchStyle.SmallConfetti, Color.LightGray, Color.White)
            g.FillRectangle(hatchBrush, rect)

            '// Set up the text font.
            Dim size As SizeF
            Dim fontSize As Decimal = rect.Height + 1
            Dim font As Font
            '// Adjust the font size until the text fits within the image.
            Do
                fontSize -= 1
                font = New Font(_familyName, fontSize, FontStyle.Bold)
                size = g.MeasureString(_text, font)
            Loop While (size.Width > rect.Width)

            '// Set up the text format.
            Dim format As New StringFormat()
            format.Alignment = StringAlignment.Center
            format.LineAlignment = StringAlignment.Center

            '// Create a path using the text and warp it randomly.
            Dim path As New GraphicsPath()
            path.AddString(_text, font.FontFamily, font.Style, font.Size, rect, format)
            Dim v As Decimal = 4.0F
            Dim points As PointF() = { _
                New PointF(random.Next(rect.Width) / v, random.Next(rect.Height) / v), _
                New PointF(rect.Width - random.Next(rect.Width) / v, random.Next(rect.Height) / v), _
                New PointF(random.Next(rect.Width) / v, rect.Height - random.Next(rect.Height) / v), _
                New PointF(rect.Width - random.Next(rect.Width) / v, rect.Height - random.Next(rect.Height) / v)}

            Dim matrix As New Matrix()
            matrix.Translate(0.0F, 0.0F)
            path.Warp(points, rect, matrix, WarpMode.Perspective, 0.0F)

            '// Draw the text.
            hatchBrush = New HatchBrush(HatchStyle.LargeConfetti, Color.LightGray, Color.DarkGray)
            g.FillPath(hatchBrush, path)

            '// Add some random noise.
            Dim m As Int32 = Math.Max(rect.Width, rect.Height)
            For i As Int32 = 0 To CInt((rect.Width * rect.Height / 30.0F))
                Dim x As Int32 = random.Next(rect.Width)
                Dim y As Int32 = random.Next(rect.Height)
                Dim w As Int32 = random.Next(m / 50)
                Dim h As Int32 = random.Next(m / 50)
                g.FillEllipse(hatchBrush, x, y, w, h)
            Next

            '// Clean up.
            font.Dispose()
            hatchBrush.Dispose()
            g.Dispose()

            '// Set the image.
            _image = bitmap
        End Sub
    End Class
End Namespace