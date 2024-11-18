open System


//Zadanie 1

//type UserData = {
//    Weight: float
//    Height: float
//}

//let calculateBmi weight height =
//    let heightM = height / 100.0
//    weight / (heightM * heightM)

//let determineBmiCategory bmi = 
//    match bmi with
//    | bmi when bmi < 18.5 -> "Niedowaga"
//    | bmi when bmi >= 18.5 && bmi < 24.9 -> "Waga prawidłowa"
//    | bmi when bmi >= 25.0 && bmi < 29.9 -> "Nadwaga"
//    | _ -> "Otyłość"


//let userData = {Weight = 70; Height = 170}
//let bmi = calculateBmi userData.Weight userData.Height
//let category = determineBmiCategory bmi

//printfn "Twoje bmi wynosi: %f" bmi
//printfn "Oraz twoja kategoria to: %s" category

//0


//Zadanie 2

//let exchangeRates = 
//    Map.ofList [
//        ("USD", "EUR"), 0.91
//        ("EUR", "USD"), 1.1
//        ("USD", "GBP"), 0.77
//        ("GBP", "USD"), 1.3
//        ("EUR", "GBP"), 0.85
//        ("GBP", "EUR"), 1.18
//        ("USD", "PLN"), 3.8
//        ("PLN", "USD"), 0.26
//        ("EUR", "PLN"), 4.5
//        ("PLN", "EUR"), 0.22
//    ]


//let convertCurrency amount sourceCurrency targetCurrency =
//    match exchangeRates.TryFind (sourceCurrency, targetCurrency) with
//    | Some rate -> Some (amount * rate)
//    | None -> None

//// Deklaracja zmiennych
//let amount = 3000.0
//let sourceCurrency = "EUR"
//let targetCurrency = "PLN"


//let wynik = convertCurrency amount sourceCurrency targetCurrency


//match wynik with
//| Some value -> printfn "Wynik to %.2f %s" value targetCurrency
//| None -> printfn "Błędna kombinacja walut"


//Zadanie 3

//open System
//[<EntryPoint>]
//let main argv =
//    let input = "Witam serdecznie wszystkich, witam"
//    let words = input.Split([| ' '; '\t'; '\n'; '\r' |], StringSplitOptions.RemoveEmptyEntries)

//    let wordCount = words.Length
//    let charCount = input.Replace(" ", "").Length

//    let mostFrequentWord =
//        words
//        |> Seq.groupBy id
//        |> Seq.maxBy (fun (_, group) -> Seq.length group)
//        |> fst

//    printfn "Liczba slow: %d" wordCount
//    printfn "Liczba znakow: %d" charCount
//    printfn "Najczesciej wystepujace slowo: %s" mostFrequentWord

//    0




//Zadanie 4

//type Konto = {
//    NumerKonta: int
//    Saldo: decimal
//}


//let stworzKonto (numerKonta: int) =
//    { NumerKonta = numerKonta; Saldo = 0m }


//let depozyt (konto: Konto) (kwota: decimal) =
//    if kwota > 0m then
//        { konto with Saldo = konto.Saldo + kwota }
//    else
//        printfn "Kwota depozytu musi być większa niż 0."
//        konto


//let wyplata (konto: Konto) (kwota: decimal) =
//    if kwota > 0m && konto.Saldo >= kwota then
//        { konto with Saldo = konto.Saldo - kwota }
//    elif kwota > konto.Saldo then
//        printfn "Brak wystarczających środków na koncie."
//        konto
//    else
//        printfn "Kwota wypłaty musi być większa niż 0."
//        konto


//let wyswietlSaldo (konto: Konto) =
//    printfn "Numer konta: %d, Saldo: %.2f" konto.NumerKonta konto.Saldo


//let rec menu (bank: Map<int, Konto>) =
//    printfn "\n--- Menu ---"
//    printfn "1. Stwórz nowe konto"
//    printfn "2. Depozytuj środki"
//    printfn "3. Wypłać środki"
//    printfn "4. Wyświetl saldo"
//    printfn "5. Wyjdź"

//    let wybor = Console.ReadLine()

//    match wybor with
//    | "1" ->
//        printf "Podaj numer konta: "
//        let numerKonta = int (Console.ReadLine())
//        if bank.ContainsKey numerKonta then
//            printfn "Konto z tym numerem już istnieje."
//            menu bank
//        else
//            let noweKonto = stworzKonto numerKonta
//            let nowyBank = bank.Add(numerKonta, noweKonto)
//            printfn "Konto zostało utworzone."
//            menu nowyBank

//    | "2" ->
//        printf "Podaj numer konta: "
//        let numerKonta = int (Console.ReadLine())
//        if bank.ContainsKey numerKonta then
//            printf "Podaj kwotę depozytu: "
//            let kwota = decimal (Console.ReadLine())
//            let konto = bank.[numerKonta]
//            let zaktualizowaneKonto = depozyt konto kwota
//            let nowyBank = bank.Add(numerKonta, zaktualizowaneKonto)
//            printfn "Depozyt został wykonany."
//            menu nowyBank
//        else
//            printfn "Konto z tym numerem nie istnieje."
//            menu bank

//    | "3" ->
//        printf "Podaj numer konta: "
//        let numerKonta = int (Console.ReadLine())
//        if bank.ContainsKey numerKonta then
//            printf "Podaj kwotę do wypłaty: "
//            let kwota = decimal (Console.ReadLine())
//            let konto = bank.[numerKonta]
//            let zaktualizowaneKonto = wyplata konto kwota
//            let nowyBank = bank.Add(numerKonta, zaktualizowaneKonto)
//            printfn "Wypłata została wykonana."
//            menu nowyBank
//        else
//            printfn "Konto z tym numerem nie istnieje."
//            menu bank

//    | "4" ->
//        printf "Podaj numer konta: "
//        let numerKonta = int (Console.ReadLine())
//        if bank.ContainsKey numerKonta then
//            let konto = bank.[numerKonta]
//            wyswietlSaldo konto
//            menu bank
//        else
//            printfn "Konto z tym numerem nie istnieje."
//            menu bank

//    | "5" ->
//        printfn "Dziękujemy za korzystanie z banku!"
//        ()

//    | _ ->
//        printfn "Nieprawidłowy wybór, spróbuj ponownie."
//        menu bank


//[<EntryPoint>]
//let main argv =
//    printfn "Witaj w banku!"
//    let bank: Map<int, Konto> = Map.empty 
//    menu bank
//    0




//Zadanie 5

//let displayBoard (board: string[]) =
//    printfn "\n %s | %s | %s" board.[0] board.[1] board.[2]
//    printfn "---|---|---"
//    printfn " %s | %s | %s" board.[3] board.[4] board.[5]
//    printfn "---|---|---"
//    printfn " %s | %s | %s" board.[6] board.[7] board.[8]


//let checkWinner (board: string[]) =
//    let winningCombinations = [
//        [0; 1; 2]; [3; 4; 5]; [6; 7; 8]; 
//        [0; 3; 6]; [1; 4; 7]; [2; 5; 8]; 
//        [0; 4; 8]; [2; 4; 6]             
//    ]
//    winningCombinations
//    |> List.tryFind (fun [a; b; c] -> board.[a] = board.[b] && board.[b] = board.[c] && board.[a] <> " ")
//    |> Option.map (fun [a; _; _] -> board.[a])


//let isBoardFull (board: string[]) =
//    not (Array.exists ((=) " ") board)


//let tryParseInt (input: string) =
//    match Int32.TryParse(input) with
//    | true, value -> Some value
//    | _ -> None

//let rec playGame (board: string[]) (currentPlayer: string) =
//    displayBoard board

    
//    printfn "\nPlayer %s, enter your move (1-9):" currentPlayer
//    let move =
//        match tryParseInt(Console.ReadLine()) with
//        | Some value when value >= 1 && value <= 9 && board.[value - 1] = " " -> value - 1
//        | _ ->
//            printfn "Invalid move. Try again."
//            playGame board currentPlayer
//            0 

   
//    board.[move] <- currentPlayer

   
//    match checkWinner board with
//    | Some winner ->
//        displayBoard board
//        printfn "\nPlayer %s wins!" winner
//    | None ->
        
//        if isBoardFull board then
//            displayBoard board
//            printfn "\nIt's a tie!"
//        else
            
//            let nextPlayer = if currentPlayer = "X" then "O" else "X"
//            playGame board nextPlayer
//            () 

//[<EntryPoint>]
//let main argv =
//    printfn "Welcome to Tic-Tac-Toe!"
//    let board = Array.create 9 " " 
//    playGame board "X" |> ignore
//    0
