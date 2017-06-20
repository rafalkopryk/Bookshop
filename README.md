# Bookshop
## 1. Minimalne wymagania
* NodeJS v6.11 
* Net Framework 4.6.2
* SQL Server
## 2. Instrukcja uruchomieniowa
<b>2.1. Instalacja modułów node dla projektu Angular-Cli</b>

Przed uruchomianiem aplikacji należy zainstalować moduły node dla projektu Angular-Cli.
W tym celu z poziomu konsoli należy przejść do lokalizacji <b>Shop.Web/www</b> a następnie wpisać polecenie:

    npm install

<b>2.2. Uruchomienie projektu</b>

W celu uruchomienia projektu należy otworzyć plik Bookshop.sln w Visual Studio a następnie uruchomić aplikację. Baza danych powinna zostać utworzona wraz z przykładowymi danymi podczas pierwszego uruchomienia programu. W przypadku nie utworzenia przykładowych danych należy wpisać w konsoli menadżera pakietów (<b>Package Manager Console</b>) polecenie <b>Update-Database</b>. Jako domyślny projekt w  konsoli menadżera pakietów należy ustawić <b>Shop.DAL</b>. W sytuacji uruchomienia programu lecz nie załadowania aplikacji wykonanej w frameworku angular (ciągle widoczny tekst Trwa ładowanie...) patrz punkt 2.5.  

<b>2.3. Ustawienie połączenia z bazą danych</b> 

Parametry połączenia bazy danych znajdują się w connectionString w pliku Web.config (Projekt Shop.Web). 

<b>2.4. Uruchomienie testów</b>

W celu uruchomienia testów jednostkowych należy przejść do Test > Run > All Tests

<b>2.5. Przeprowadzenie zmian w projekcie Angular</b>

W celu potwierdzenia zmian wprowadzonych w aplikacji tworzonej przy pomocy frameworka Angular należy w lokalizacji <b>Shop.Web/www</b> wpisać polecenie:

    ng build

## 3. Opis Web API

W celu testowania Rest API projektu dodano Swagger'a. Dostęp do niego można uzyskać pod adresem {host}/swagger.




## 4. Technologie i wzorce wykorzystane w projekcie
Technologia/Wzorzec| Miejsce wykorzystania w projekcie|  
 --- | ---
ASP.NET Web Api | Projekt Shop.Web
Entity Framework | Przestrzeń nazw Shop.DAL.Repositories.Impl (klasa Repository)
Angular | Projekt Shop.Web > katalog www
Autofac IoC Container | Przstrzeń nazw Shop.Web.App_Start (klasa IoCConfig)
Wzorzec repozytorium | Przestrzeń nazw Shop.DAL.Repositories
Testy jednostkowe NUnit | Projekt Shop.Web.Tests

## 5. Komentarze odnośnie zadania
