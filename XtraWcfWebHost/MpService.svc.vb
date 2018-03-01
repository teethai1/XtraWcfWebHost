' NOTE: You can use the "Rename" command on the context menu to change the class name "MpService" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select MpService.svc or MpService.svc.vb at the Solution Explorer and start debugging.
Imports XtraWcfWebHost

Public Class MpService
    Implements IMpService

    Private Function MachinePakageControl(MCNo As String, PackageName As String) As Boolean
        Dim ap As New DbxDataSetTableAdapters.QueriesTableAdapter
        Dim RowCountChecking As Integer = ap.MachinePackageChecking(PackageName, MCNo)
        If RowCountChecking <> 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub GetSetting(Package As String, McType As String, ByRef MpSettingClass As MpSetting)
        Dim SettingDataTable As New DbxDataSet.MpParameterDataTable
        Dim SettingAp As New DbxDataSetTableAdapters.MpParameterTableAdapter
        MpSettingClass.IsPassParameter = False
        SettingDataTable = SettingAp.GetData(Package, McType)
        If SettingDataTable.Count <> 0 Then
            For Each DataRowaa As DbxDataSet.MpParameterRow In SettingDataTable.Rows
                If DataRowaa.IsSTDShotNull = False Then
                    MpSettingClass.StdShot = DataRowaa.STDShot
                End If

                If DataRowaa.IsSTDShotAutomotiveNull = False Then
                    MpSettingClass.StdShotAutomotive = DataRowaa.STDShotAutomotive
                End If

                If DataRowaa.IsProductionTimeNull = False Then
                    MpSettingClass.ProductionTime = DataRowaa.ProductionTime
                End If

                If DataRowaa.IsSTDLotQtyNull = False Then
                    MpSettingClass.StdLotQty = DataRowaa.STDLotQty
                End If

                If DataRowaa.IsPcsPerShotNull = False Then
                    MpSettingClass.PcsShot = DataRowaa.PcsPerShot
                End If

                If DataRowaa.IsStopLongTimeNull = False Then
                    MpSettingClass.StopLongTime = DataRowaa.StopLongTime
                End If

            Next

            MpSettingClass.IsPassParameter = True

        End If

    End Sub

    Public Function MpCondition(McNo As String, Package As String, McType As String) As MpSetting Implements IMpService.MpCondition
        Dim mpSettingClass As New MpSetting
        mpSettingClass.IsPassMachinePackageControl = MachinePakageControl(McNo, Package)

        GetSetting(Package, McType, mpSettingClass)
        Return mpSettingClass
    End Function
End Class
