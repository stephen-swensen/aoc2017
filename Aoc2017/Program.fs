// Learn more about F# at http://fsharp.org

namespace Aoc2017

module Aoc =
    open System

    [<EntryPoint>]
    let main argv =
        //printfn "%i" <| Day1.part1_a ()
        //printfn "%i" <| Day1.part1_b ()
        printfn "%i" <| Day1.part2_a ()
        ignore <| stdin.ReadLine()
        0
