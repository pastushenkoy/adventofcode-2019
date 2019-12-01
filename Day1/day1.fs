open System

let countFuel x =  (Math.Floor ((x)/3.0)) - 2.0

let input = IO.File.ReadAllLines "./Day1/input.txt" |> Seq.map double

let res1 = input |> Seq.sumBy countFuel |> int
printfn "Task #1: %d" res1

let rec countTotalFuel mass =
    if mass > 0.0 
    then 
        let fuelMass = countFuel mass
        fuelMass + countTotalFuel fuelMass
    else 0.0

let res2 = input |> Seq.sumBy countTotalFuel |> int 
printfn "Task #2: %d" res2


