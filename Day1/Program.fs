open System
    
let countFuel x =  (Math.Floor ((x)/3.0)) - 2.0

let rec countTotalFuel mass =
    let fuelMass = countFuel mass
    if fuelMass > 0.0 
    then fuelMass + countTotalFuel fuelMass
    else 0.0

let testCase expected actual = 
    if expected <> actual
    then printfn "FAILED!!! Expected '%s' but was '%s'" (string expected) (string actual)
    
let test = 
    testCase 2.0 (countTotalFuel 14.0)
    testCase 966.0 (countTotalFuel 1969.0)


[<EntryPoint>]
let main argv =
    if argv |> Seq.contains "test" 
    then 
        test
    else
        let input = System.IO.File.ReadAllLines "input.txt" |> Seq.map double

        let res1 = input |> Seq.sumBy countFuel |> int
        printfn "Task #1: %d" res1    

        let res2 = input |> Seq.sumBy countTotalFuel |> int
        printfn "Task #2: %d" res2
    
    0
