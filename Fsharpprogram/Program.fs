open System //it requires for system.io
printfn "hello world"
printfn "This my first program in f#"
let id = 10
let str = "F#"
let mutable id1 = 10
//values
let numbers = [20; 30; 40]

let Processor = ["intel", 10; "Amd", 40; "NViDIA", 100]
//charecter array

let Subjects = [|"Math"; "Physics"; "Chem"|]

let Multiplication = List.map (fun x -> x * 2) numbers
// Print it as a value.
printfn "%A" id

// Use some surrounding text.
printfn "The ID is %A." id 

// Modify the id variable and print it again.
id1 <- 20
printfn "%A" id


//For loop example
for v in Subjects do
    printfn "%A" v

// print list 
printfn "%A" numbers
printfn "%A" Processor


//multiply numbers
printfn "%A" Multiplication

Console.ReadKey() |> ignore