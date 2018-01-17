'Program:   Coffe Hut Sales
'Programmer:    Ryan Roque
'Date: 3/24/2017
'Purpose:   Gather sales for a 5 day week. Compute and display taxes and total receipts.

Module Module1

    Sub Main()

        Const dblSTATE_TAX_RATE As Double = 0.035
        Const dblCOUNTY_TAX_RATE As Double = 0.05
        Const dblCITY_TAX_RATE As Double = 0.0125

        Dim decWeeklySales As Decimal = 0
        Dim decStateTax As Decimal = 0
        Dim decCountyTax As Decimal = 0
        Dim decCityTax As Decimal = 0
        Dim decTotalReceipts As Decimal = 0
        Dim intDay As Integer = 0

        For intDay = 1 To 5
            getSales(intDay, decWeeklySales)
        Next

        calculateTax(decWeeklySales, dblSTATE_TAX_RATE, decStateTax)
        calculateTax(decWeeklySales, dblCOUNTY_TAX_RATE, decCountyTax)
        calculateTax(decWeeklySales, dblCITY_TAX_RATE, decCityTax)

        calculateTotal(decWeeklySales, decStateTax, decCountyTax, decCityTax, decTotalReceipts)

        displayReceipts(decWeeklySales, decStateTax, decCountyTax, decCityTax, decTotalReceipts)
        terminateProgram()

    End Sub

    Private Sub getSales(ByVal intDayCount As Integer, ByRef decWeeklyTotal As Decimal)

        Dim decDailySales As Decimal = 0
        Console.WriteLine("Sales for day " & intDayCount & ": ")
        decDailySales = CDec(Console.ReadLine())
        decWeeklyTotal = decWeeklyTotal + decDailySales

    End Sub

    Private Sub calculateTax(ByVal decTotal As Decimal, ByRef dblRate As Double, ByRef decTax As Decimal)

        decTax = decTotal * CDec(dblRate)
        decTax = decTax * 100
        decTax = Math.Ceiling(decTax)
        decTax = decTax / 100

    End Sub

    Private Sub calculateTotal(ByVal decTotal As Decimal, ByVal decState As Decimal, ByVal decCounty As Decimal,
                               ByVal decCity As Decimal, ByRef decReceipts As Decimal)

        decReceipts = decTotal + decState + decCounty + decCity

    End Sub

    Private Sub displayReceipts(ByVal decTotal As Decimal, ByVal decState As Decimal, ByVal decCounty As Decimal,
                                ByVal decCity As Decimal, ByVal decReceipts As Decimal)

        Console.Clear()
        Console.WriteLine("Total Sales: " & decTotal.ToString("C"))
        Console.WriteLine("State Tax: " & decState.ToString("C"))
        Console.WriteLine("County Tax: " & decCounty.ToString("C"))
        Console.WriteLine("City Tax: " & decCity.ToString("C"))
        Console.WriteLine("Total Receipts: " & decReceipts.ToString("C"))

    End Sub

    Private Sub terminateProgram()

        Console.WriteLine()
        Console.WriteLine("Press the enter key to terminate the program.")
        Console.Read()

    End Sub

End Module