Module Module1

    Sub Main()

        Dim areaCalculator As New Reectangle(10, 2)
        areaCalculator.Length = 10
        areaCalculator.Width = 10

        Dim area As Double = areaCalculator.CalculateArea()

        Console.WriteLine($"area is {area.ToString()}")
        Console.ReadLine()

    End Sub

End Module
