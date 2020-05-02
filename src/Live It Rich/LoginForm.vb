Public Class LoginForm

    ' TODO : insérez le code pour effectuer une authentification personnalisée à l'aide du nom d'utilisateur et du mot de passe fournis 
    ' (Voir http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' L'objet Principal personnalisé peut ensuite être associé à l'objet Principal du thread actuel comme suit : 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' CustomPrincipal est l'implémentation IPrincipal utilisée pour effectuer l'authentification. 
    ' Par la suite, My.User retournera les informations d'identité encapsulées dans l'objet CustomPrincipal
    ' telles que le nom d'utilisateur, le nom complet, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Dim objDBConnect As DBConnector

        Dim strLog, strPass As String

        Dim objPgCommand As NpgsqlCommand

        Dim objReadResults As NpgsqlDataReader

        Dim objReadAdapter As NpgsqlDataAdapter

        Dim bLogOk As Boolean = False

        Dim objData As DataTable


        'Recuperer les valeur des textbox
        '
        strLog = UsernameTextBox.Text
        strPass = PasswordTextBox.Text

        'Crée une connection avec la base et la table specifié
        '
        objDBConnect = New DBConnector("postgres", "boomboom", "lir", "localhost", "5432")

        'Verifier la connection a la base de donnée
        '
        If (objDBConnect.getDBConnector.FullState = ConnectionState.Open) Then

            '-------------------------CAS1 ----------------------
            'cas de lecture de requete sur resultat multiple

            ''Créer requete a executer sur la base de donnée
            ''
            'objPgCommand = New NpgsqlCommand("SELECT ""Login"", ""Pass"" FROM ""User"" WHERE ""Login"" = '" + strLog + "' AND ""Pass"" = '" + strPass + "' ;", objDBConnect.getDBConnector)

            ''Executer et recuperer le resutlat de la requete
            ''
            'objReadResults = objPgCommand.ExecuteReader()

            ''Verifier le resultat avec les parametre des text box
            ''
            'Do While (objReadResults.Read())

            '    ' Mettre a jour le flag en cas d'égalité
            '    '
            '    If (objReadResults(0).ToString = strLog And objReadResults(1).ToString = strPass) Then
            '        bLogOk = True
            '    End If

            'Loop

            ''Fermer le reader
            ''
            'objReadResults.Close()


    
            '-------------------------CAS2 ----------------------
            'cas de requete avec resultat unique(une ligne, une colone)

            'Requete sql
            '
            objPgCommand = New NpgsqlCommand("SELECT COUNT(*) FROM ""User"" WHERE ""Login"" = '" + strLog + "' AND ""Pass"" = '" + strPass + "' ;", objDBConnect.getDBConnector)

            'Verifie si il y a un resultat de la requete
            '
            If (CInt(objPgCommand.ExecuteScalar()) = 1) Then

                'Mettre a jour le flag
                '
                bLogOk = True

            End If


            If (bLogOk = True) Then
                MsgBox("Utilisateur authentifié", CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Information, MsgBoxStyle))
                Me.Close()
            Else
                MsgBox("Erreur d'autenthification", CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle))
            End If

        Else
            MsgBox("Live It Rich non connecté à la BD", CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle))

        End If



        ''Créer requete a executer sur la base de donnée
        ''
        'objPgCommand = New NpgsqlCommand("SELECT ""Login"", ""Pass"" FROM ""User"" WHERE ""Login"" = '" + strLog + "' AND ""Pass"" = '" + strPass + "' ;", objDBConnect.getDBConnector)


        ''Permet de visualiser le resultat sur la table datagridwiev sur le forumlaire
        ''
        'objReadAdapter = New NpgsqlDataAdapter(objPgCommand)
        'objData = New DataTable
        'objReadAdapter.Fill(objData)
        'DataGridView1.DataSource = objData

        ''Permet de recuperer dans un tableau, les lignes de la requete select hello
        ''
        'Dim objRows() As DataRow
        'objRows = objData.Select("Hello = 'aaa'")


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
