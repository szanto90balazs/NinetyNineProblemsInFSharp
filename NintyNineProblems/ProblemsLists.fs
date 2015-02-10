namespace NintyNineProblems
open System

type Lists(list: int list) =

    member private this.doGetLast _list = 
        match _list with
            | [] -> failwith "Empty list doesn't have a last item"
            | [x] -> x
            | head::tail -> this.doGetLast tail

    member this.GetLast =
        this.doGetLast list