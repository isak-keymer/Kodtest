# Onlinebutik API

## Instruktioner:

1. Klona ner detta repo till din lokala utvecklingsmaskin
2. Skapa upp en ny tom databas med valfritt namn, välj själv om du använder localdb eller kör på db-server.
3. Spara undan connectionstring till din databas
4. Uppdatera appsettings.json, ConnectionStrings -> RetailDb: {din connectionstring}
5. Kör via valfri CLI, typ Developer command prompt i VS2022
    - Navigera (cd) till din mapp där du har KodtestMio.csproj filen.
    - Kör kommandot: dotnet ef database update