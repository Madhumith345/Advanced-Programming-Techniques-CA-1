# CA One - Advanced Programming Techniques

## Folder Structure

```
coding_assigment/
    Que1/
        ChurrosApp/         <- C# console app (Task 1)
            Churros.cs
            Order.cs
            Program.cs
            Que1.csproj
        ChurrosTests/       <- Unit tests for Task 1
            TestOrder.cs
            ChurrosTests.csproj
    Que2/                   <- C# Periodic Table (Task 2)
        Element.cs
        Program.cs
        Que2.csproj
    Que3/                   <- Python TCP Client-Server (Task 3)
        Que3_server.py
        Que3_client.py
        easydrive.db        <- created on first server run
    Que4/                   <- Python Web Scraper (Task 4)
        Que4.py
        books.csv           <- created after running Que4.py
    README.md
```

---

## Requirements

### C# (Task 1 and Task 2)
- .NET SDK 8.0 or later
- Verify install: `dotnet --version`

### Python (Task 3 and Task 4)
- Python 3.10 or later
- Install dependencies:

```
pip install requests beautifulsoup4
```

---

## Task 1 - Churros Food Truck

### Run the console app
```
cd Que1\ChurrosApp
dotnet run
```

### Run the unit tests (pay_bill method)
```
cd Que1\ChurrosTests
dotnet test
```

---

## Task 2 - Periodic Table

```
cd Que2
dotnet run
```

Enter an atomic number between 1 and 30 when prompted.  
Enter `n` when asked to stop.

---

## Task 3 - EasyDrive TCP Client-Server

Open **two separate terminals**.

**Terminal 1 - Start the server first:**
```
cd Que3
python Que3_server.py
```

**Terminal 2 - Run the client:**
```
cd Que3
python Que3_client.py
```

The client collects customer details (Name, Address, PPS Number, Driving Licence),  
sends them to the server, and receives a unique registration number back.  
The server stores all records in `easydrive.db` (SQLite database).

---

## Task 4 - Web Scraper (books.toscrape.com)

```
cd Que4
python Que4.py
```

Scrapes the Travel books page, saves data to `books.csv`, then reads and prints the CSV.
