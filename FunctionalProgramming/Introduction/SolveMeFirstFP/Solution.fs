open System

[<EntryPoint>]
let main argv = 
    let a = Console.ReadLine() |> int
    let b = Console.ReadLine() |> int
    printfn "%d" (a+b)
    0
