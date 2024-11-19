open System

//Zadanie 1
//let rec fibRec n=
//    if n <= 0 then 0
//    elif n = 1 then 1
//    else fibRec (n-1) + fibRec (n-2)

//let wynik = fibRec 10
//printfn "fib 10 = %d " wynik

//let rec fibTailRec n=
//    let rec aux n a b=
//        if n<=0 then a
//        elif n = 1 then b
//        else aux (n-1) b (a+b)

//    aux n 0 1


//Zadanie 2
//type BinaryTreec<'T> =
//    | Empty
//    | Node of 'T * BinaryTreec<'T> * BinaryTreec<'T>


//let myTree =
//    Node(10,
//        Node(5,Node(2,Empty,Empty), Node(7,Empty,Empty)),
//        Node(15,Node(12,Empty,Empty), Node(20,Empty,Empty)))

//let rec searchTreeValue tree value =
//    match tree with
//    | Empty -> false
//    | Node(v, left, right) ->
//        if v = value then true
//        elif searchTreeValue left value then true
//        else searchTreeValue right value

//let found = searchTreeValue myTree 12
//printf "Czy znaleziono element 30? %b" found

//let rec searchTreeValueIter tree value =
//    let rec loop stack =
//        match stack with
//        | [] -> false
//        | Empty :: rest -> loop rest
//        | Node(v, left, right) :: rest ->
//            if v = value then true
//            else loop (left :: right :: rest)
//    loop [tree]

//let foundIter = searchTreeValueIter myTree 12
//printf "Czy znaleziono element 12 iteracyjnie? %b\n" foundIter



//Zadanie 3
//let rec permutacje lista =
//    match lista with
//    | [] -> [[]] 
//    | _ ->
//        lista
//        |> List.collect (fun x ->
//            let pozostale = List.filter ((<>) x) lista
//            let permutacjePozostale = permutacje pozostale
//            permutacjePozostale |> List.map (fun p -> x :: p))

//// Test
//let lista = [1; 2; 3]
//let wynik = permutacje lista
//printfn "Permutacje listy %A to: %A" lista wynik

//Zadanie 4
//let rec hanoi n start aux target =
//    if n = 1 then
       
//        printfn "Przenieś dysk z %c do %c" start target
//    else
    
//        hanoi (n - 1) start target aux
  
//        printfn "Przenieś dysk z %c do %c" start target
       
//        hanoi (n - 1) aux start target


//hanoi 3 'A' 'B' 'C'

//let hanoiIter n start aux target =
 
//    let totalMoves = pown 2 n - 1

    
//    let moveNumber (moveIndex: int) : (char * char) =
//        if moveIndex % 3 = 1 then (start, target)
//        elif moveIndex % 3 = 2 then (start, aux)  
//        else (aux, target)                       

  
//    for move in 1 .. totalMoves do
//        let (fromPole, toPole) = moveNumber move
//        printfn "Ruch %d: Przenieś dysk z %c do %c" move fromPole toPole


//hanoiIter 3 'A' 'B' 'C'


//Zadanie 5
//let rec quickSort list =
//    match list with
//    | [] -> [] 
//    | pivot :: tail ->
//        let smallerOrEqual = List.filter (fun x -> x <= pivot) tail
//        let greater = List.filter (fun x -> x > pivot) tail
//        quickSort smallerOrEqual @ [pivot] @ quickSort greater 


//let unsortedList = [3; 7; 1; 9; 2; 8; 5]
//let sortedList = quickSort unsortedList
//printfn "Lista przed posortowaniem: %A" unsortedList
//printfn "Lista po posortowaniu (rekurencyjnie): %A" sortedList
