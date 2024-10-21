Imports System

Module Program
    Sub Main(args As String())
        Dim numero As Integer
        Dim esPrimo As Boolean

        ' Solicita al usuario un número
        Console.Write("Introduce un número para verificar si es primo: ")
        numero = Convert.ToInt32(Console.ReadLine())

        ' Asume que el número es primo a menos que se pruebe lo contrario
        esPrimo = True

        ' Solo los números mayores que 1 pueden ser primos
        If numero <= 1 Then
            esPrimo = False
        Else
            ' Recorre desde 2 hasta la raíz cuadrada del número para verificar divisibilidad
            For i As Integer = 2 To Math.Sqrt(numero)
                If numero Mod i = 0 Then
                    esPrimo = False
                    Exit For ' Si se encuentra un divisor, no es necesario seguir verificando
                End If
            Next
        End If

        ' Muestra el resultado
        If esPrimo Then
            Console.WriteLine("El número " & numero & " es primo.")
        Else
            Console.WriteLine("El número " & numero & " no es primo.")
        End If

        Console.ReadKey() ' Pausa antes de cerrar el programa
    End Sub
End Module
