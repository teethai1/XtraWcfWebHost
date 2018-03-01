Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMpService" in both code and config file together.
<ServiceContract()>
Public Interface IMpService

    <OperationContract()>
    Function MpCondition(McNo As String, Package As String, McType As String) As MpSetting

End Interface
