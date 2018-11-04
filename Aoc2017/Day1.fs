module Day1
    open System
    open System.IO

    let part1 () =
        let text = File.ReadAllText "Day1_input.txt"
        let nums = text.ToCharArray() |> Array.map (string>>Int32.Parse)
        let mutable sum = 0
        for i in 0 .. (nums.Length - 1) do
            if nums.[i] = nums.[if (i+1) = nums.Length then 0 else (i+1)] then
                sum <- sum + nums.[i]
                printfn "sum=%i, nums.[i]=%i" sum (nums.[i])
        sum

