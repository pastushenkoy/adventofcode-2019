namespace Day1

module Program = 

    open Functions
    
    [<EntryPoint>]
    let main argv =
        let input = System.IO.File.ReadAllLines "input.txt" |> Seq.map double

        let res1 = input |> Seq.sumBy countFuel |> int
        printfn "Task #1: %d" res1    

        let res2 = input |> Seq.sumBy countTotalFuel |> int
        printfn "Task #2: %d" res2

        0
