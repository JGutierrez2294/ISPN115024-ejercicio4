Imports System

Module Program
    Sub Main(args As String())
        Dim numero As Integer
        Dim esPrimo As Boolean

        ' Solicita al usuario un n�mero
        Console.Write("Introduce un n�mero para verificar si es primo: ")
        numero = Convert.ToInt32(Console.ReadLine())

        ' Asume que el n�mero es primo a menos que se pruebe lo contrario
        esPrimo = True

        ' Solo los n�meros mayores que 1 pueden ser primos
        If numero <= 1 Then
            esPrimo = False
        Else
            ' Recorre desde 2 hasta la ra�z cuadrada del n�mero para verificar divisibilidad
            For i As Integer = 2 To Math.Sqrt(numero)
                If numero Mod i = 0 Then
                    esPrimo = False
                    Exit For ' Si se encuentra un divisor, no es necesario seguir verificando
                End If
            Next
        End If

        ' Muestra el resultado
        If esPrimo Then
            Console.WriteLine("El n�mero " & numero & " es primo.")
        Else
            Console.WriteLine("El n�mero " & numero & " no es primo.")
        End If

        Console.ReadKey() ' Pausa antes de cerrar el programa
    End Sub
End Module
