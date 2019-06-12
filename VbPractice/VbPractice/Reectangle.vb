Public Class Reectangle
    Implements IReectangle

    Private _length As Double
    Private _width As Double

    Public Sub New(length As Double, width As Double)
        _length = length
        _width = width
    End Sub

    Public Property Length() As Double Implements IReectangle.Length
        Get
            Return _length
        End Get
        Set(ByVal value As Double)
            _length = value
        End Set
    End Property

    Public Property Width() As Double Implements IReectangle.Width
        Get
            Return _width
        End Get
        Set(ByVal value As Double)
            _width = value
        End Set
    End Property

    Public Function CalculateArea() As Double Implements IReectangle.CalculateArea
        Return Length * Width
    End Function
End Class
