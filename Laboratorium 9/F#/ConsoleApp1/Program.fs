
//Zadanie 1 Suma ciągu podanej liczby np. 1+2+3+4 
//let sum n = 
//    if n < 1 then 0
//    else n * (n+1) / 2 //Nie dawac w nawias

//let result = sum 10
//printfn "Wynik to %d " result



////Zadanie 2 Sprawdzanie czy podana liczba, jest liczbą pierwszą
//let jestPierwsza n = 
//    if n <= 1 then false
//    else
//    let upperBound = int (sqrt (float n))
//    let rec sprawdzaniePierwszej pierwsza = 
//        if pierwsza > upperBound then true
//        elif n % pierwsza = 0 then false
//        else sprawdzaniePierwszej (pierwsza + 1)
//    sprawdzaniePierwszej 2

//let number = 17
//let result jestPierwsza number




//Zadanie 3 Utwórz program, który wczytuje dane o uczniach i ich ocenach, a następnie generuje raport z ocenami.
open System

//// Prosty typ ucznia z imieniem i listą ocen
//type Student = {
//    Name: string
//    Grades: int list
//}

//// Funkcja wczytująca dane ucznia w formacie: Imię, Ocena1, Ocena2, ...
//let readStudent () =
//    printf "Podaj dane ucznia w formacie 'Imię, Ocena1, Ocena2,...': "
//    let input = Console.ReadLine()
//    let parts = input.Split(',')
//    if parts.Length > 1 then
//        let name = parts.[0].Trim()
//        let grades =
//            parts.[1..]
//            |> Array.map (fun g -> g.Trim() |> int)
//            |> List.ofArray
//        Some { Name = name; Grades = grades }
//    else
//        None

//// Funkcja generująca raport dla ucznia
//let generateReport (student: Student) =
//    let average =
//        if student.Grades.Length > 0 then
//            (List.sum student.Grades |> float) / float student.Grades.Length
//        else 0.0
//    printfn "Uczeń: %s" student.Name
//    printfn "Oceny: %A" student.Grades
//    printfn "Średnia ocen: %.2f\n" average

//// Program główny
//let main () =
//    let mutable students = [] // Lista uczniów
//    let mutable continueInput = true

//    while continueInput do
//        match readStudent () with
//        | Some student -> students <- student :: students
//        | None -> printfn "Niepoprawny format danych. Spróbuj ponownie."
        
//        printf "Czy chcesz dodać kolejnego ucznia? (tak/nie): "
//        let response = Console.ReadLine()
//        continueInput <- response.Trim().ToLower() = "tak"

//    printfn "\n=== Raport z ocen ==="
//    for student in List.rev students do
//        generateReport student

//// Uruchomienie programu
//main ()



//Zadanie 4 Napisz funkcję, która sortuje listę liczb rosnąco bez użycia wbudowanej funkcji sortującej.

//let bubbleSort (inputList: int list) =
//    let rec sortHelper (lst: int list) (sortedList: int list) =
//        match lst with
//        | [] -> sortedList
//        | _ ->
//            let rec bubble (unsorted: int list) (acc: int list) =
//                match unsorted with
//                | [] -> List.rev acc
//                | [x] -> List.rev (x :: acc)
//                | x :: y :: rest ->
//                    if x > y then
//                        bubble (x :: rest) (y :: acc)
//                    else
//                        bubble (y :: rest) (x :: acc)
//            let bubbled = bubble lst []
//            match List.rev bubbled with
//            | [] -> sortedList
//            | x :: rest -> sortHelper rest (x :: sortedList)
//    sortHelper inputList []

//// Przykład użycia
//let unsortedList = [4; 2; 9; 1; 5; 6]
//let sortedList = bubbleSort unsortedList
//printfn "Posortowana lista: %A" sortedList


//Zadanie 5 Opracuj program do analizy plików tekstowych, który zlicza liczbę wystąpień poszczególnych
//słów i generuje raport.

//open System
//open System.IO
//open System.Text.RegularExpressions

//// Funkcja wczytująca zawartość pliku
//let readFile (filePath: string) =
//    if File.Exists(filePath) then
//        Some (File.ReadAllText(filePath))
//    else
//        printfn "Plik o ścieżce '%s' nie istnieje." filePath
//        None

//// Funkcja do zliczania słów w tekście
//let countWords (text: string) =
//    // Usunięcie znaków specjalnych i podział na słowa
//    let words = 
//        Regex.Split(text.ToLower(), @"\W+")
//        |> Array.filter (fun word -> word <> "") // Usunięcie pustych elementów
//    // Grupowanie słów i ich zliczanie
//    words
//    |> Array.countBy id
//    |> Array.sortByDescending snd // Sortowanie według liczby wystąpień

//// Funkcja generująca raport
//let generateReport (wordCounts: (string * int)[]) =
//    printfn "=== Raport wystąpień słów ==="
//    for (word, count) in wordCounts do
//        printfn "%s: %d" word count

//// Program główny
//let main () =
//    printf "Podaj ścieżkę do pliku tekstowego: "
//    let filePath = Console.ReadLine()
//    match readFile filePath with
//    | Some text ->
//        let wordCounts = countWords text
//        generateReport wordCounts
//    | None -> printfn "Nie można przetworzyć pliku."

//// Uruchomienie programu
//main ()
