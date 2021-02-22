# carrent-2021
Das Projekt läuft mit einer MySql Datenbank. Im appsettings.json ist der Connectionstring hinterlegt. Diesen bitte als allererstes anpassen. Danach bitte in der Paket-Manager-Konsole den Befehl 'update-Database' eingeben
damit per Migration-File die Datenbank erstellt wird. Danach bitte die beiden .csv Fiels aus dem Ordner 'DBFiles' importieren. Diese beinhalten alle Gmeinden der Schweiz und ihre postleitzahl sowie die 3 Klassen der Autos.
Wennd as alles geklappt hat, sollte die API laufen. Default ist swagger als launchURL drin. Somit kann man direkt loslegen.
