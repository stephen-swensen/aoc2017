// Learn more about F# at http://fsharp.org

namespace Aoc2017

module Aoc =
    open System

    [<EntryPoint>]
    let main argv =
        printfn "%i" <| Day1.part1 ()
        ignore <| stdin.ReadLine()
        0
