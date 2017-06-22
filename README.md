# Bookshop
Mini księgarnia internetowa stworzona w technologiach ASP.NET Web Api oraz Angular.
## 1. Minimalne wymagania
* NodeJS v6.11 
* Net Framework 4.6.1
* SQL Server
* Angular-Cli (w przypadku modyfikowania projektu Angular)
## 2. Instrukcja uruchomieniowa
<b>2.1. Instalacja modułów node dla projektu Angular-Cli</b>

Przed uruchomianiem aplikacji należy zainstalować moduły node dla projektu Angular-Cli.
W tym celu z poziomu konsoli należy przejść do lokalizacji <b>Shop.Web/www</b> a następnie wpisać polecenie:

    npm install

<b>2.2. Uruchomienie projektu</b>

W celu uruchomienia projektu należy otworzyć plik Bookshop.sln w Visual Studio a następnie uruchomić aplikację. Baza danych powinna zostać utworzona wraz z przykładowymi danymi podczas pierwszego uruchomienia programu.

* W przypadku nie utworzenia przykładowych danych należy wpisać w konsoli menadżera pakietów (<b>Package Manager Console</b>) polecenie <b>Update-Database</b>. Jako domyślny projekt w  konsoli menadżera pakietów należy ustawić <b>Shop.DAL</b>.

* W sytuacji uruchomienia programu lecz nie załadowania aplikacji wykonanej w frameworku angular (ciągle widoczny tekst Trwa ładowanie...) patrz punkt 2.5.  

* W sytuacji występowania błędów z brakiem modułów node dla frameworka Angular pomimo ich wcześniejszego zainstalowania lub innych bibliotek/plików należy przebudować projekt (Rebuild solution).

<b>2.3. Ustawienie połączenia z bazą danych</b> 

Parametry połączenia bazy danych znajdują się w connectionString w pliku Web.config (Projekt Shop.Web). 

<b>2.4. Uruchomienie testów</b>

W celu uruchomienia testów jednostkowych należy przejść do Test > Run > All Tests

<b>2.5. Przeprowadzenie zmian w projekcie Angular</b>

W celu potwierdzenia zmian wprowadzonych w aplikacji tworzonej przy pomocy frameworka Angular należy w lokalizacji <b>Shop.Web/www</b> wpisać polecenie:

    ng build
   
<b>Uwaga</b>: Dla danego polecenia wymagany jest zainstalowany Angular-Cli

    npm install -g @angular/cli

## 3. Opis Web API

W celu testowania API projektu dodano Swagger'a. Dostęp do niego można uzyskać poprzez przejscie pod adres {host}/swagger.

<b>3.1 Opis API dla metod zaimplementowanych w ramach etapu V.</b>

Nazwa metody| Url| Parametry| Format zwracanych danych| Opis|
 --- | --- | --- | --- | ---
GetAll | /api/books | Brak | Punkt 3.4 | Pobranie wszystkich rekordów księgozbioru
GetAllByTitle | /api/books/title?title={title} | <b>title</b> - nazwa książki | Punkt 3.4 | Pobranie rekordów księgozbioru zawierających w nazwie wyraz podany w parametrze
GetAllByPublisher | /api/publishers/{publisher}/books | <b>publisher</b> - nazwa wydawcy | Punkt 3.4 | Pobranie rekordów księgozbioru dla danego wydawcy podanego w parametrze
GetAllByType | /api/{type}/books | <b>type</b> - typ książki (E-Book albo Audiobook) | Punkt 3.4 | Pobranie rekordów księgozbioru dla danego typu ksiażki podanego w parametrze

<b>3.2 Opis API dla metod zaimplementowanych w ramach wcześniejszych etapów.</b>

Poniższe metody nie licząc <b>GetCarriers</b> umożliwiają pobranie rekordów księgozbioru zawierających w nazwie lub imieniu i nazwisku autora wyraz podany jako parametr <b>query</b>. Ponadto dają wybór sposobu sortowania poprzez parametr <b>orderBy</b>. Możliwe wartości sortowania podano w punkcie 3.3. Poniżej znajduję się wzorzec ścieżki z parametrami uri dla poniższych metod na przykładzie Resta /api/books/all.

    /api/books/all?query={wartość}&orderBy={wartość}
  
Parametry sa opcjonalne.

Nazwa metody| Bazowy Url| Format zwracanych danych| Opis|
 --- | --- | --- | --- 
GetAllBooks | /api/books/all | Punkt 3.4 | Pobranie rekordów księgozbioru przefiltrowanych i posortowanych wobec parametrów
GetAudiobooks | /api/books/audiobooks | Punkt 3.4 | Pobranie rekordów księgozbioru (wyłącznie aubiobooków) przefiltrowanych i posortowanych wobec parametrów
GetEbooks | /api/books/ebooks | Punkt 3.4 | Pobranie rekordów księgozbioru (wyłącznie ebooków) przefiltrowanych i posortowanych wobec parametrów
GetNovelties | /api/books/novelties | Punkt 3.4 | Pobranie rekordów księgozbioru (książki wydane w ciągu ostatnich 14 dni) przefiltrowanych i posortowanych wobec parametrów
GetPreviews | /api/books/previews | Punkt 3.4 | Pobranie rekordów księgozbioru (książki które zostaną  wydane w ciągu najbliższych 14 dni) przefiltrowanych i posortowanych wobec parametrów
GetSuperBargains | /api/books/super-bargains | Punkt 3.4 | Pobranie rekordów księgozbioru (książki które sa oznaczone jako "super okazje") przefiltrowanych i posortowanych wobec parametrów
GetCarriers | /api/carriers/ | Punkt 3.5 | Pobranie nośników

<b>3.3 Możliwe wartości sortowania</b>
```javascript
 releaseDate      
 releaseDate_desc  
 price                              
 price_desc
 author
 author_desc
 publisher
 publisher_desc
 title
 title_desc
                
```

<b>3.4 Przykładowe dane zwracane dla kontrolerów pod ścieżką /api/books/* </b>

```javascript

[
  {
    "BookId": 19,
    "Title": "13 powodów",
    "Price": 34.49,
    "ReleaseDate": "2017-06-18T23:16:40.277",
    "Publisher": "Insignis",
    "Author": "Jay Asher",
    "Type": "Audiobook",
    "SuperBargain": true
  },
  {
    "BookId": 14,
    "Title": "Anioły i demony",
    "Price": 31.49,
    "ReleaseDate": "2014-01-21T00:00:00",
    "Publisher": "Insignis",
    "Author": "Dan Brown",
    "Type": "Audiobook",
    "SuperBargain": false
  }
]  
```
<b>3.5 Przykładowe dane zwracane dla kontrolera pod ścieżką /api/carriers/ </b>

```javascript
[
  {
    "Name": "PenDrive"
  },
  {
    "Name": "płyta CD"
  },
  {
    "Name": "płyta DVD"
  }
]
```


## 4. Technologie i wzorce wykorzystane w projekcie
Technologia/Wzorzec| Miejsce wykorzystania w projekcie|  
 --- | ---
ASP.NET Web Api | Projekt Shop.Web
Entity Framework | Przestrzeń nazw Shop.DAL.Repositories.Impl (klasa Repository)
Angular | Projekt Shop.Web > katalog www
Autofac IoC Container | Przstrzeń nazw Shop.Web.App_Start (klasa IoCConfig)
Wzorzec repozytorium | Przestrzeń nazw Shop.DAL.Repositories
Wzorzec DTO | Przestrzeń nazw Shop.BLL.DTOs, mapowane przez AutoMappera
Testy jednostkowe NUnit | Projekt Shop.Web.Tests


