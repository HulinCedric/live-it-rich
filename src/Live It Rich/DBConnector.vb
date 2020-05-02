Public Class DBConnector

    Private m_objDBConnector As NpgsqlConnection
    Private m_strDBUser As String
    Private m_strDBPassword As String
    Private m_strDBName As String
    Private m_strDBIP_Address As String
    Private m_strDBIP_Port As String


    Public Sub New(ByVal strDBUser As String, ByVal strDBPassword As String, ByVal strDBName As String, ByVal strDBIP_Address As String, ByVal strDBIP_Port As String)



        m_strDBUser = strDBUser
        m_strDBPassword = strDBPassword
        m_strDBName = strDBName
        m_strDBIP_Address = strDBIP_Address
        m_strDBIP_Port = strDBIP_Port


        m_objDBConnector = New NpgsqlConnection("Server=" + m_strDBIP_Address + ";Port=" + m_strDBIP_Port + ";User Id=" + m_strDBUser + ";Password=" + m_strDBPassword + ";Database=" + m_strDBName + ";")



        Try
            m_objDBConnector.Open()
        Catch ex As Exception
            MsgBox("Connexion échouée." + vbNewLine + "Raison: " + ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle))
        End Try

    End Sub



    Public ReadOnly Property getDBConnector() As NpgsqlConnection
        Get
            Return m_objDBConnector
        End Get
    End Property




End Class
