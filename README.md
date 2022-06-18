## auto.bus (Ticket Office) – manage, search and buy bus tickets online

- C#, Microsoft.EntityFrameworkCore, Razor Pages

### Installation

1. Compile the project (`[~]$ dotnet build -c Release` or in IDE)
2. Copy ~/TicketOffice/wwwroot to the root directory of compiled project (clean database can be found in ~/wwwroot/db)
3. Launch

### Database update

1. `[~/TicketOffice]$ dotnet-ef database drop` then confirm database deletion
2. `[~/TicketOffice]$ dotnet-ef database update`

### Available routes

#### № 027

- Сватове -> Красноріченське -> Кремінна -> Рубіжне -> Сєвєродонецьк -> Лисичанськ -> Сєвєродонецьк -> Рубіжне -> Кремінна -> Красноріченське -> Сватове 
- (Date: date of the first launch of project with clean database)

#### № 013

- Кремінна -> Рубіжне -> Сєвєродонецьк -> Станиця Луганська -> Сєвєродонецьк -> Рубіжне -> Кремінна 
- (Date: date of the first launch of project with clean database)

### Test accounts

#### User

- e-mail: user
- password: user

#### Admin

- e-mail: admin
- password: admin
