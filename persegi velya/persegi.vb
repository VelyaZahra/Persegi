Public Class persegi
    Private _panjang As Single
    Private _lebar As Single
    Private _luas As Single
    Private _keliling As Single

    Public Property Panjang() As Integer
        Get
            Return _panjang
        End Get
        Set(ByVal value As Integer)
            _panjang = value
        End Set
    End Property

    Public Property Lebar() As Integer
        Get
            Return _lebar
        End Get
        Set(ByVal value As Integer)
            _lebar = value
        End Set
    End Property

    Public Function Luas() As Single
        _luas = _panjang * _lebar
        Return _luas
    End Function

    Public Function Keliling() As Single
        _keliling = (2 * _panjang) + (2 * _lebar)
        Return _keliling
    End Function
End Class
