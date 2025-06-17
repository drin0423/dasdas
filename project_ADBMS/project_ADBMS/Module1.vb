Imports System.Windows.Forms

Module Module1
    Public cn As New ADODB.Connection
    Public rs As New ADODB.Recordset

    Sub con()
        With cn
            If .State = 1 Then .Close()
            .ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC\source\repos\project_ADBMS\project_ADBMS\bin\Debug\adbms.mdb;Persist Security Info=False;"
            .CursorLocation = ADODB.CursorLocationEnum.adUseClient
            .Open()
        End With
    End Sub




    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New role())
    End Sub
End Module
