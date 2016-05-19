Module Program

    Sub Main()
        Console.WriteLine(Read.FromConfig("HelloWorld"))
        Console.WriteLine(Read.FromConfig("KeyOne"))
        Console.WriteLine(Read.FromConfig("KeyTwo"))
        Console.ReadKey()
    End Sub

End Module
