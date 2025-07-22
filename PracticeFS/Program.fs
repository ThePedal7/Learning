open System
type Calculator() =
    member this.Calculate() =
        let mutable running = true

        while running do
            printfn "Enter first number:"
            let num1 = Convert.ToInt32(Console.ReadLine())

            printfn "Enter second number:"
            let num2 = Convert.ToInt32(Console.ReadLine())

            printfn "Enter operation:"
            let op = Convert.ToChar(Console.ReadLine())

            let result =
                match op with
                | '+' -> num1 + num2
                | '-' -> num1 - num2
                | '*' -> num1 * num2
                | '/' when num2 <> 0 -> num1 / num2
                | '%' when num2 <> 0 -> num1 % num2
                | _   -> failwith "Invalid operation or divide by zero"

            printfn "Result: %d" result

            printfn "Continue? (y/n):"
            let answer = Console.ReadLine().ToLower()
            if answer = "n" then
                running <- false
    
[<EntryPoint>]
let main args =
    let calc = Calculator()
    calc.Calculate()
    0