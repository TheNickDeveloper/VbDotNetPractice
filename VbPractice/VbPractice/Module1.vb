Module Module1

    Public Sub Main()

        Dim areaCalculator As New Reectangle(10, 2)
        areaCalculator.Length = 10
        areaCalculator.Width = 10

        Dim area As Double = areaCalculator.CalculateArea()

        Dim k = GetBasicInfoList(Of BasicInfo)()
        Console.WriteLine($"area is {area.ToString()}")
        Console.ReadLine()

    End Sub

    Private Function GetBasicInfoList(Of T)() As List(Of T)
        Dim resultList As New List(Of T)
        Dim type = GetType(T)
        Dim properties = type.GetProperties()

        For index = 1 To 10
            Dim ob = Activator.CreateInstance(Of T)

            For Each prop In properties
                prop.SetValue(ob, index.ToString())
            Next

            resultList.Add(ob)
        Next

        Return resultList
    End Function
End Module
