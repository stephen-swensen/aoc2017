module Day1
    open System
    open System.IO

    let part1_a () =
        let text = File.ReadAllText "Day1_input.txt"
        let nums = text.ToCharArray() |> Array.map (string>>Int32.Parse)
        let mutable sum = 0
        for i in 0 .. (nums.Length - 1) do
            if nums.[i] = nums.[if (i+1) = nums.Length then 0 else (i+1)] then
                sum <- sum + nums.[i]
                printfn "sum=%i, nums.[i]=%i" sum (nums.[i])
        sum

    let getNums () =
        let text = File.ReadAllText "Day1_input.txt"
        let input = text.ToCharArray() |> Array.map (string>>Int32.Parse)
        //infinte sequence that yields the input sequence round and round
        let rec nums = seq { yield! input; yield! nums }
        input, nums |> Seq.cache

    let part1_b () =
        let input, nums = getNums ()
        nums
        |> Seq.take (input.Length + 1)
        |> Seq.pairwise
        |> Seq.filter (fun (x,y) -> x = y)
        |> Seq.sumBy fst

    let part2_a () =
        let input, nums = getNums ()
        let nums' = nums |> Seq.skip (input.Length / 2)
        Seq.zip nums nums'
        |> Seq.take input.Length
        |> Seq.filter (fun (x,y) -> x = y)
        |> Seq.sumBy fst

