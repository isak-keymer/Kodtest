# Onlinebutik API

## Instruktioner:

1. Klona ner detta repo till din lokala utvecklingsmaskin
2. Skapa upp en ny tom databas med valfritt namn, v�lj sj�lv om du anv�nder localdb eller k�r p� db-server.
3. Spara undan connectionstring till din databas
4. Uppdatera appsettings.json, ConnectionStrings -> RetailDb: {din connectionstring}
5. K�r via valfri CLI, typ Developer command prompt i VS2022
    - Navigera (cd) till din mapp d�r du har KodtestMio.csproj filen.
    - K�r kommandot: dotnet ef database update