Imports System

Module Program
    Sub Main(args As String())
        'Console.CursorVisible = False
        Dim soucet, cislo As Integer
        Dim vstup As String

        Nadpis("Součet čísel", 40, 5, ConsoleColor.Black, ConsoleColor.White)
        Nadpis($"Součet je {soucet}", 40, 15, ConsoleColor.Black, ConsoleColor.White)
        Nadpis("Zadej číslo:     ", 39, 10, ConsoleColor.Black, ConsoleColor.White)
        cislo = Zadavani(55, 11, ConsoleColor.White, ConsoleColor.Black)
        Console.ReadKey()
    End Sub

    Function Zadavani(left As Integer, top As Integer, textColor As ConsoleColor, backColor As ConsoleColor) As Integer
        Dim tempBackColor As ConsoleColor = Console.BackgroundColor
        Dim tempForeColor As ConsoleColor = Console.ForegroundColor

        Console.BackgroundColor = backColor
        Console.ForegroundColor = textColor
        Console.SetCursorPosition(left, top)
        Console.Write("    ")
        Console.SetCursorPosition(left + 3, top)
        Console.BackgroundColor = tempBackColor
        Console.ForegroundColor = tempForeColor
    End Function

    Sub Nadpis(text As String, left As Integer, top As Integer, textColor As ConsoleColor, backColor As ConsoleColor)
        Dim tempBackColor As ConsoleColor = Console.BackgroundColor
        Dim tempForeColor As ConsoleColor = Console.ForegroundColor
        Dim line As String = New String("─", text.Length)

        Console.BackgroundColor = backColor
        Console.ForegroundColor = textColor
        Console.SetCursorPosition(left, top)
        Console.Write($"┌──{line}──┐")
        Console.SetCursorPosition(left, top + 1)
        Console.Write($"│  {text}  │")
        Console.SetCursorPosition(left, top + 2)
        Console.Write($"└──{line}──┘")
        Console.BackgroundColor = tempBackColor
        Console.ForegroundColor = tempForeColor
    End Sub
End Module
