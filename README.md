# Spec Chat

## Tartalomjegyzék
- [Spec Chat](#spec-chat)
  - [Tartalomjegyzék](#tartalomjegyzék)
  - [Csapatbeosztás](#csapatbeosztás)
  - [User manual](#user-manual)
    - [Beüzemelés](#beüzemelés)
      - [Backend beüzemelése](#backend-beüzemelése)
      - [Frontend beüzemelése](#frontend-beüzemelése)
    - [Használat](#használat)
      - [API endpoint-ok](#api-endpoint-ok)
      - [Felhasználói felület](#felhasználói-felület)
- [Probléma jegyzőkönyv](#probléma-jegyzőkönyv)

## Csapatbeosztás
- Gyöngyösi Dávid – Frontend
- Hargita Benjamin – Frontend + TeamLead
- Molnár Ákos Benedek – Backend
- Szalai István Dávid – Backend 

## User manual
### Beüzemelés
#### Backend beüzemelése
A `specchat.API` mappában lévő `specchat.API.sln` solution file-t meg kell nyitni Visual Studio-ban. Ezt követően meg kell nyitni a `Package Manager Console`-t (Tools > NuGet Package Manager > Package Manager Console). Ide be kell írni a következő parancsot:
```sh
Update-Database
```
Ez után futtatható a `specchat.API` projekt.
#### Frontend beüzemelése
Ehhez előre telepítve kell, hogy legyen a [NodeJS](https://nodejs.org/en/download).
A `specchat.UI` mappát Visual Studio Code-ban kell megnyitni. Itt Terminál parancsként a következőt kell kiadni:
```
npm install
ng serve
```
Ezek után elérhető localhost-on.
### Használat
#### API endpoint-ok

- /Auth
  - /Login
post, leellenőrzi a megadott credential-t és helyes felhasználónév, jelszó
  - /InsertUser
  put, a megkapott felhasználói adatok alapján létrehoz egy újat
  - /GetUserInfos
  get, visszaadja a saját adatainkat
  - /DeleteMyself
  delete, törli az adott felhasználót
  - /Update
  post, frissíti a felhasználó adatait
  - /GetById/id
  get, visszaad az adott id-jű felhasználó adatait
  - /GetUsers
  get, visszaadja az összes felhasználót
- /Chat
  - post
  létrehoz egy chat-et a body-ban küldött adatok alapján
  - delete
  `/id` törli az adott id-jű chat-et
  - get
  visszaadja az összes chat-et
  - get
  `/id` visszaadja egy chat tulajdonságait
  - get
  `/UploadFile/id` visszaadja az elmentett file elérési útvonalát
  - put
    felülírja egy cshat tulajdonságait
- /ChatUser
  - /Chat/id
  get, visszaadja adott id-jű felhasználó, melyik chat-ekben van benne
  - /id/addUser/userid
  post, hozzáadja az adott id-jű user-t az adott id-jű chat-hez
  - delete
  kiveszi az adott id-jű user-t az adott id-jű chat-ből
  - /User/id
  visszaadja a chat-hez tartozó összes felhasználót
- /api/Emoji
  - post
  hozzáad egy emojit egy message-hez
  - delete
  elvesz egy emojit egy message-től
  - get
  visszaadja az összes emojit
  - get
  `/id` visszaad egy emojit
  - put
  frissíti egy emoji tulajdonságait
- /api/Message
  - post
  hozzáad egy új üzenetet
  - delete
  `/id` töröl egy üzenetet
  - get
  visszaadja az összes üzenetet
  - get
  `/id` visszaad egy üzenetet
  - put
  frissíti egy üzenet tulajdonságait
#### Felhasználói felület
Login
!(login)[/images/login.png]
Itt tud belépni a felhasználó
!(dashboard)[/images/dashboard.png]
Az admin itt tudja hozzáadni a felhasználókat a chat-ekhez. Illetve azokat létrehozni, törölni és exportálni.
!(chat)[/images/chat.png]
Itt tudnak közlekedni a chat-ek között és üzeneteket írni bele.

# Probléma jegyzőkönyv
1 Autorizáció kezelés
  - leváltottuk az eredeti projekt típust és külön szedtük a backendet és a frontendet
2 Backenddel való kommunikáció
  - Cors policy beállítása
3 model binding komponensek között
  - @input és @output változók (cukrok) bevezetése
4 Emojik megjelenítése textarea-ban
  - külső library bevonása
5 QR kód megjelenítése
  - külső library bevonása