Public Class MpSetting
    Private _StdShot As Integer
    Public Property StdShot() As Integer
        Get
            Return _StdShot
        End Get
        Set(ByVal value As Integer)
            _StdShot = value
        End Set
    End Property
    Private _StdShotAutomotive As Integer
    Public Property StdShotAutomotive() As Integer
        Get
            Return _StdShotAutomotive
        End Get
        Set(ByVal value As Integer)
            _StdShotAutomotive = value
        End Set
    End Property
    Private _StdLotQty As Integer
    Public Property StdLotQty() As Integer
        Get
            Return _StdLotQty
        End Get
        Set(ByVal value As Integer)
            _StdLotQty = value
        End Set
    End Property
    Private _ProductionTime As Double
    Public Property ProductionTime() As Double
        Get
            Return _ProductionTime
        End Get
        Set(ByVal value As Double)
            _ProductionTime = value
        End Set
    End Property

    Private _stopLongTime As Integer
    Public Property StopLongTime() As Integer
        Get
            Return _stopLongTime
        End Get
        Set(ByVal value As Integer)
            _stopLongTime = value
        End Set
    End Property

    Private _PcsShot As Integer
    Public Property PcsShot() As Integer
        Get
            Return _PcsShot
        End Get
        Set(ByVal value As Integer)
            _PcsShot = value
        End Set
    End Property

    Private _IsPassMachinePackageControl As Boolean
    Public Property IsPassMachinePackageControl() As Boolean
        Get
            Return _IsPassMachinePackageControl
        End Get
        Set(ByVal value As Boolean)
            _IsPassMachinePackageControl = value
        End Set
    End Property

    Private _IsPassParameter As Boolean
    Public Property IsPassParameter() As Boolean
        Get
            Return _IsPassParameter
        End Get
        Set(ByVal value As Boolean)
            _IsPassParameter = value
        End Set
    End Property
End Class
