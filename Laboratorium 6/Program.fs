//Zadanie 1

//open System

//let wordCount (text: string) = 
//    text.Split([|' '; '.';','; '\n'|], System.StringSplitOptions.RemoveEmptyEntries).Length

//let char (text:string) =
//    text |> Seq.filter (fun c -> not (Char.IsWhiteSpace(c))) |> Seq.length


//[<EntryPoint>]
//let main argv = 
//    printf "Podaj tekst"
//    let input = Console.ReadLine()
//    let count = wordCount input
//    let charCount = char input
//    printfn "Liczba slow: %d" count
//    printfn "Liczba znakow bez spacji: %d" charCount
//    0



//Zadanie 2

//open System

//let isPalindrome (text:string) =
//    let cleanedText = text.Replace(" ","").ToLower()
//    let reversedText = new string(cleanedText.ToCharArray() |> Array.rev)
//    cleanedText = reversedText

//[<EntryPoint>]
//let main argv =
//    printfn "Podaj ciag znakow"
//    let input = Console.ReadLine()

//    if isPalindrome input then
//        printfn "Podany ciag jest palindromem"

//    else 
//        printfn "Podany ciag nie jest palindromem"

//    0

//Zadanie 3 
//open System


//let removeDuplicates (words: string list) =
//    words |> List.distinct


//[<EntryPoint>]
//let main argv =
//    printfn "Wprowadź słowa oddzielone spacjami:"
//    let input = Console.ReadLine()
//    match input with
//    | null -> printfn "Nie podano żadnych danych."
//    | _ ->
//        let words = input.Split([|' '|], StringSplitOptions.RemoveEmptyEntries) |> List.ofArray
//        let uniqueWords = removeDuplicates words
//        printfn "Lista unikalnych słów: %A" uniqueWords
//    0 


//Zadanie 4

//open System


//let transformEntry (entry: string) =
//    let parts = entry.Split(';') 
//    if parts.Length = 3 then
//        let imie = parts.[0].Trim() 
//        let nazwisko = parts.[1].Trim() 
//        let wiek = parts.[2].Trim() 
//        nazwisko + ", " + imie + " (" + wiek + " lat)" 
//    else
//        "Błędny format: " + entry 


//[<EntryPoint>]
//let main argv =
//    printfn "Wpisz dane w formacie \"imię;nazwisko;wiek\" oddzielone przecinkami:"
//    let input = Console.ReadLine() 
//    if input <> null then
//        let entries = input.Split(',') 
//        for entry in entries do
//            let result = transformEntry entry
//            printfn "%s" result 
//    else
//        printfn "Nie podano żadnych danych."
//    0 


//Zadanie 5

//open System


//let findLongestWord (text: string) =
//    let words = text.Split([|' '; '\t'; '\n'|], StringSplitOptions.RemoveEmptyEntries) 
//    let longestWord = words |> Array.maxBy (fun word -> word.Length) 
//    longestWord, longestWord.Length 


//[<EntryPoint>]
//let main argv =
//    printfn "Wpisz dowolny tekst:"
//    let input = Console.ReadLine() 
//    if input <> null then
//        let longestWord, length = findLongestWord input
//        printfn "Najdłuższe słowo: %s" longestWord
//        printfn "Długość najdłuższego słowa: %d" length
//    else
//        printfn "Nie podano żadnych danych."
//    0


//Zadanie 6

//open System


//let replaceWord (text: string) (wordToFind: string) (wordToReplace: string) =
//    text.Replace(wordToFind, wordToReplace) 


//[<EntryPoint>]
//let main argv =
//    printfn "Wpisz tekst, w którym chcesz wyszukać i zamienić słowo:"
//    let text = Console.ReadLine() 

//    if not (String.IsNullOrWhiteSpace(text)) then
//        printfn "Wpisz słowo, które chcesz znaleźć:"
//        let wordToFind = Console.ReadLine() 

//        printfn "Wpisz słowo, na które chcesz je zamienić:"
//        let wordToReplace = Console.ReadLine() 

//        if not (String.IsNullOrWhiteSpace(wordToFind)) && not (String.IsNullOrWhiteSpace(wordToReplace)) then
//            let modifiedText = replaceWord text wordToFind wordToReplace
//            printfn "Zmodyfikowany tekst:\n%s" modifiedText
//        else
//            printfn "Nie podano słowa do wyszukania lub zamiany."
//    else
//        printfn "Nie podano żadnego tekstu."
    
//    0 
