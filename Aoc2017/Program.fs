// Learn more about F# at http://fsharp.org

namespace Aoc2017

module Aoc =
    open System

    [<EntryPoint>]
    let main argv =
        let day1_input = readFile "Day1_input.txt"
        stdout.WriteLine day1_input
        ignore <| stdin.ReadLine()
        0
