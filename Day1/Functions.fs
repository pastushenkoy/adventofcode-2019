module Day1.Functions

    let countFuel x = (System.Math.Floor ((x)/3.0)) - 2.0

    let rec countTotalFuel mass =
        let fuelMass = countFuel mass
        if fuelMass > 0.0 
        then fuelMass + countTotalFuel fuelMass
        else 0.0