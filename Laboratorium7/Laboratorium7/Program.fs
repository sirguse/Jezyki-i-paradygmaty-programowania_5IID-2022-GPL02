open System

//Zadanie 1

//type Book(title: string, author: string, pages: int) =
//    member this.Title = title
//    member this.Author = author
//    member this.Pages = pages
//    member this.GetInfo() = $"Title: {title}, Author: {author}, Pages: {pages}"


//type User(name: string) =
//    let mutable borrowedBooks = [] : Book list

//    member this.Name = name

//    member this.BorrowBook(book: Book, library: Library) =
//        if library.RemoveBook(book) then
//            borrowedBooks <- book :: borrowedBooks
//            printfn "%s borrowed '%s'." name book.Title
//        else
//            printfn "'%s' is not available in the library." book.Title

//    member this.ReturnBook(book: Book, library: Library) =
//        if List.contains book borrowedBooks then
//            borrowedBooks <- List.filter ((<>) book) borrowedBooks
//            library.AddBook(book)
//            printfn "%s returned '%s'." name book.Title
//        else
//            printfn "%s does not have '%s'." name book.Title

//    member this.ListBorrowedBooks() =
//        if borrowedBooks.IsEmpty then
//            printfn "%s has no borrowed books." name
//        else
//            printfn "%s's borrowed books:" name
//            borrowedBooks |> List.iter (fun book -> printfn " - %s" (book.GetInfo()))



//and Library() =
//    let mutable books = [] : Book list

//    member this.AddBook(book: Book) =
//        books <- book :: books
//        printfn "Added '%s' to the library." book.Title

//    member this.RemoveBook(book: Book) =
//        if List.contains book books then
//            books <- List.filter ((<>) book) books
//            true
//        else
//            false

//    member this.ListBooks() =
//        if books.IsEmpty then
//            printfn "The library has no books."
//        else
//            printfn "Books in the library:"
//            books |> List.iter (fun book -> printfn " - %s" (book.GetInfo()))

//// Program główny
//do
//    let library = Library()
//    let user = User("Alice")

//    // Dodajemy książki do biblioteki
//    let book1 = Book("The Hobbit", "J.R.R. Tolkien", 310)
//    let book2 = Book("1984", "George Orwell", 328)
//    let book3 = Book("To Kill a Mockingbird", "Harper Lee", 281)

//    library.AddBook(book1)
//    library.AddBook(book2)
//    library.AddBook(book3)

//    // Wyświetlamy książki w bibliotece
//    library.ListBooks()

//    // Użytkownik wypożycza książkę
//    user.BorrowBook(book1, library)

//    // Wyświetlamy aktualny stan biblioteki
//    library.ListBooks()

//    // Użytkownik zwraca książkę
//    user.ReturnBook(book1, library)

//    // Wyświetlamy aktualny stan biblioteki
//    library.ListBooks()

//    // Użytkownik wypożycza książkę, która nie istnieje
//    let book4 = Book("Nonexistent Book", "Unknown Author", 0)
//    user.BorrowBook(book4, library)

//    // Wyświetlamy książki wypożyczone przez użytkownika
//    user.ListBorrowedBooks()






//Zadanie 2

//type BankAccount(accountNumber: string, initialBalance: decimal) =
//    let mutable balance = initialBalance

//    member this.AccountNumber = accountNumber
//    member this.Balance = balance

//    member this.Deposit(amount: decimal) =
//        if amount <= 0m then
//            printfn "Deposit amount must be greater than zero."
//        else
//            balance <- balance + amount
//            printfn "Deposited %.2f to account %s. New balance: %.2f" amount accountNumber balance

//    member this.Withdraw(amount: decimal) =
//        if amount <= 0m then
//            printfn "Withdrawal amount must be greater than zero."
//        elif amount > balance then
//            printfn "Insufficient funds in account %s. Current balance: %.2f" accountNumber balance
//        else
//            balance <- balance - amount
//            printfn "Withdrew %.2f from account %s. New balance: %.2f" amount accountNumber balance


//type Bank() =
//    let mutable accounts = Map.empty<string, BankAccount>

//    member this.CreateAccount(accountNumber: string, initialBalance: decimal) =
//        if accounts.ContainsKey(accountNumber) then
//            printfn "Account with number %s already exists." accountNumber
//        else
//            let account = BankAccount(accountNumber, initialBalance)
//            accounts <- accounts.Add(accountNumber, account)
//            printfn "Account %s created with initial balance: %.2f" accountNumber initialBalance

//    member this.GetAccount(accountNumber: string) =
//        match accounts.TryFind(accountNumber) with
//        | Some(account) -> Some(account)
//        | None -> 
//            printfn "Account with number %s not found." accountNumber
//            None

//    member this.UpdateAccount(accountNumber: string, action: BankAccount -> unit) =
//        match accounts.TryFind(accountNumber) with
//        | Some(account) -> action(account)
//        | None -> printfn "Account with number %s not found." accountNumber

//    member this.DeleteAccount(accountNumber: string) =
//        if accounts.ContainsKey(accountNumber) then
//            accounts <- accounts.Remove(accountNumber)
//            printfn "Account %s deleted." accountNumber
//        else
//            printfn "Account with number %s not found." accountNumber

//    member this.ListAccounts() =
//        if accounts.IsEmpty then
//            printfn "No accounts in the bank."
//        else
//            printfn "Accounts in the bank:"
//            accounts |> Map.iter (fun key account -> printfn " - %s: Balance %.2f" key account.Balance)


//do
//    let bank = Bank()

//    // Tworzenie kont
//    bank.CreateAccount("123456", 1000m)
//    bank.CreateAccount("789012", 500m)

//    // Wyświetlanie listy kont
//    bank.ListAccounts()

//    // Wpłata na konto
//    bank.UpdateAccount("123456", fun account -> account.Deposit(200m))

//    // Wypłata z konta
//    bank.UpdateAccount("123456", fun account -> account.Withdraw(150m))

//    // Próba wypłaty z niewystarczającymi środkami
//    bank.UpdateAccount("123456", fun account -> account.Withdraw(2000m))

//    // Próba operacji na nieistniejącym koncie
//    bank.UpdateAccount("999999", fun account -> account.Deposit(100m))

//    // Usuwanie konta
//    bank.DeleteAccount("789012")

//    // Wyświetlanie listy kont po usunięciu
//    bank.ListAccounts()
