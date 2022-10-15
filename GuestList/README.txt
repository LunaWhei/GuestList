Backend funkcjonalności

2 modele
Guest

Guid Id
string name
string lastName
int age
datetime creationDate

Party

Guid Id 
string name
string localization
datetime creationDate
datetine partyDate
list<guest> guestList



API

Guests

Pobieranie wszystkich gości
Pobieranie pojedyńczego gościa

Dodawanie gościa
Usuwanie Gościa


Party

Pobranie listy wszystkich przyjęć
Pobieranie informacji o pojedyńczym przyjęciu


Dodawanie przyjęcia 
Usuwanie Przyjęcia

Dodawanie gościa do przyjęcia
Usuwanie gościa z przyjęcia




Guest API documentation

url/api/Guest/Metoda()

Metody
//Return single guest by id (id is a list index)
GetGuest(int id)

returns all users in list
ReturnAllGuests()

add new guests (require new guest object)
AddNewGuest(Guest guest)

delete user by its id in list (id is a list index)
DeleteUser(int id)