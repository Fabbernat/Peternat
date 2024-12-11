# Kisállat Nyilvántartó Rendszer

Ez egy ASP.NET Core MVC webalkalmazás, amely egy kisállat nyilvántartó rendszert valósít meg. Az alkalmazás SQLite adatbázist használ, Entity Framework Core Code-First megközelítéssel.

**Funkciók:**

* Kisállatok és kategóriák kezelése (CRUD műveletek)
* Kategóriákhoz kisállatok hozzárendelése
* Kisállatok adatainak megtekintése, szerkesztése és törlése
* Új kisállatok és kategóriák hozzáadása
* Alapvető input validáció

**Modellek:**

* **Kategória:**
    * Id
    * Nev
    * Leiras
* **Kisállat:**
    * Id
    * Nev
    * Nem
    * Eletkor
    * Suly
    * FotoUrl
    * CategoryId (a kategória azonosítója)

**Telepítés:**

1. Klónozd a repository-t.
2. Telepítsd a .NET 8 SDK-t.
3. Állítsd be az adatbázis kapcsolatot az `appsettings.json` fájlban.
4. Futtassd a `dotnet run` parancsot a projekt mappában.

**Használat:**

Az alkalmazás elindítása után a böngészőben a következő útvonalakon érheted el a funkciókat:

* `/`: Főoldal
* `/Categories`: Kategóriák listázása
* `/Categories/Create`: Új kategória hozzáadása
* `/Categories/Details/{id}`: Kategória adatainak megtekintése
* `/Categories/Edit/{id}`: Kategória adatainak szerkesztése
* `/Categories/Delete/{id}`: Kategória törlése
* `/Pets`: Kisállatok listázása
* `/Pets/Create`: Új kisállat hozzáadása
* `/Pets/Details/{id}`: Kisállat adatainak megtekintése
* `/Pets/Edit/{id}`: Kisállat adatainak szerkesztése
* `/Pets/Delete/{id}`: Kisállat törlése

**Megjegyzések:**

* A program a .NET 8-as verzióját használja.
* Az alkalmazás a dotnet run paranccsal futtatható.
* A program tartalmaz alapvető input validációt, de további validációkat is érdemes lehet hozzáadni.
* A program kinézetét a CSS fájlban lehet módosítani.

# Pet Registry Application

This is an ASP.NET Core MVC web application that implements a pet registry system. The application uses an SQLite database with an Entity Framework Core Code-First approach.

**Features:**

* Management of pets and categories (CRUD operations)
* Assigning pets to categories
* Viewing, editing, and deleting pet data
* Adding new pets and categories
* Basic input validation

**Models:**

* **Category:**
    * Id
    * Nev (Name)
    * Leiras (Description)
* **Pet:**
    * Id
    * Nev (Name)
    * Nem (Gender)
    * Eletkor (Age)
    * Suly (Weight)
    * FotoUrl (Photo URL)
    * CategoryId (Category ID)

**Installation:**

1. Clone the repository.
2. Install the .NET 8 SDK.
3. Configure the database connection in the `appsettings.json` file.
4. Run the `dotnet run` command in the project directory.

**Usage:**

After starting the application, you can access the features in the browser at the following routes:

* `/`: Home page
* `/Categories`: List categories
* `/Categories/Create`: Add a new category
* `/Categories/Details/{id}`: View category details
* `/Categories/Edit/{id}`: Edit category details
* `/Categories/Delete/{id}`: Delete a category
* `/Pets`: List pets
* `/Pets/Create`: Add a new pet
* `/Pets/Details/{id}`: View pet details
* `/Pets/Edit/{id}`: Edit pet details
* `/Pets/Delete/{id}`: Delete a pet

**Remarks:**

* The program uses .NET version 8.
* The application can be run with the dotnet run command.
* The program contains basic input validation, but it may be worth adding further validation.
* The appearance of the program can be modified in the CSS file.
