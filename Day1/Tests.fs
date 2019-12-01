module Day1.Tests

open Xunit
open Functions

[<Theory>]
[<InlineData(14, 2)>]
[<InlineData(1969, 966)>]
[<InlineData(100756, 50346)>]
let ``countTotalFuel`` (mass, result) =
    Assert.Equal(fuel, countTotalFuel mass)
