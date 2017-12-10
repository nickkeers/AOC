namespace PuzzleInput

module Input =
    let read (filename : string) : Option<string> =
        try 
            Some <| System.IO.File.ReadAllText filename
        with
            | Failure _ -> None