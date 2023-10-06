Module Module1

    Sub Main()
        Const MaxSize As Integer = 5 ' Tamaño máximo de la pila
        Dim stack(MaxSize - 1) As Integer
        Dim top As Integer = -1 ' Inicialmente, la pila está vacía

        While True
            Console.WriteLine("Menú:")
            Console.WriteLine("1. Push (Insertar elemento)")
            Console.WriteLine("2. Pop (Eliminar elemento)")
            Console.WriteLine("3. Mostrar la pila")
            Console.WriteLine("4. Salir")
            Console.Write("Selecciona una opción: ")

            Dim choice As Integer = Integer.Parse(Console.ReadLine())

            Select Case choice
                Case 1
                    If top < MaxSize - 1 Then
                        Console.Write("Ingresa un valor para agregar a la pila: ")
                        Dim value As Integer = Integer.Parse(Console.ReadLine())
                        top += 1
                        stack(top) = value
                        Console.WriteLine($"Elemento {value} agregado a la pila.")
                    Else
                        Console.WriteLine("La pila está llena. No se puede agregar más elementos.")
                    End If
                Case 2
                    If top >= 0 Then
                        Dim removedItem As Integer = stack(top)
                        top -= 1
                        Console.WriteLine($"Elemento {removedItem} eliminado de la pila.")
                    Else
                        Console.WriteLine("La pila está vacía. No se puede eliminar ningún elemento.")
                    End If
                Case 3
                    Console.WriteLine("Elementos en la pila:")
                    For i As Integer = top To 0 Step -1
                        Console.WriteLine(stack(i))
                    Next
                Case 4
                    Environment.Exit(0)
                Case Else
                    Console.WriteLine("Opción no válida. Por favor, selecciona una opción válida.")
            End Select
        End While
    End Sub

End Module
