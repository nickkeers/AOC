open System
open PuzzleInput

let rec processTxt2 (txt : string list) (lastchar : string) (sum : int) : int =
    match txt with
    | [] -> sum
    | first::rest ->
        if first = lastchar then
            processTxt2 rest lastchar (sum + System.Int32.Parse(first))
        else
            processTxt2 rest first sum

let processTxt (txt : Option<string>) : int =
    match txt with
    | None -> 0
    | Some txtO ->
        let txtList = List.ofSeq txtO |> List.map string
        match txtList with
        | hd::tl ->
            processTxt2 (List.append tl [hd]) hd 0
        | _ -> 0

[<EntryPoint>]
let main argv =
    let solution = Input.read "1.txt" |> processTxt
    printfn "sum: %d" solution
    System.Console.ReadLine() |> ignore
    0