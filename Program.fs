// For more information see https://aka.ms/fsharp-console-apps
open System

let Rand = Random()

let st = seq { 
    let Rand = new Random()
    while true do
        let c = Rand.Next(-3, 3)
        yield c
}

let fu a b =
    if a > b then
        a
    else
        b

let rec funk acc1 acc2 n a =
    if n <> (Seq.length a) then
        let elem = Seq.item 0 a
        printf $"{elem} "
        if elem = 0 then
            funk (acc1+1) (fu (acc1 + 1) acc2) (n + 1) a
        else
            funk 0 acc2 (n+1) a
    else
        printfn ""
        printf $"{acc2}"

let se = Seq.take 15 st
funk 0 0 0 se