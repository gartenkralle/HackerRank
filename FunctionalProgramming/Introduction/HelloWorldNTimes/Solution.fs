open System

[<EntryPoint>]
let main arg =
  let a = Console.ReadLine() |> int
  for i = 1 to a do
    printf "Hello World\n"
  0
  
