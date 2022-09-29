open System

type MilesYards = MilesYards of wholeMiles : int * yards : int
let create (milesPointYards : float) : MilesYards =
  let wholeMiles = milesPointYards |> floor |> int
  let fraction = milesPointYards - (wholeMiles |> float)
  if fraction > 0.1759 then
      raise <| ArgumentOutOfRangeException(nameof(milesPointYards),
                  "Fractional part must be <= 0.1759")
  let yards = fraction * 10_000. |> round |> int
  MilesYards(wholeMiles, yards)

let names = ["PangLian"; "DaWeiWang"; "XiaoBao"; "MaMa"; "XiaoHuiHui"]

let getMeow name = $"{name}: meow"

names
|> List.map getMeow
|> List.iter (fun meow -> printfn $"{meow}")
