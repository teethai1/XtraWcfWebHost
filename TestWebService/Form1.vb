Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim aaa As New ServiceReference1.MpServiceClient
        Dim MPClass As New ServiceReference1.MpSetting
        MPClass = aaa.MpCondition(tbMcno.Text, tbPackage.Text, TextBox1.Text)


        MachinePass.Text = MPClass.IsPassMachinePackageControl.ToString
        ParameterPass.Text = MPClass.IsPassParameter.ToString


    End Sub
End Class
