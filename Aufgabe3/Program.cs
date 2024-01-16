//Geben Sie eine benutzerdefinierte Zeichenfolge ein. Finden Sie heraus, ob es sich um ein Palindrom handelt.


string sampleString(int length) //Lassen Sie uns eine Methode erstellen, die zurückgibt
                                //zufälliger String einer bestimmten Länge
{
    Random random = new Random(); //Wir werden zufällig Buchstaben auswählen
    string obrazecBukv = "abcdefghijklmnopqrstuvwxyz"; //Lass uns eine Linie erstellen,
                                                 //wo wir eine zufällige Auswahl treffen werden
    string randomString = "";

    for (int i = 0; i < length; i++) //Führen Sie die Aktion so oft aus, 
      //wie die Länge der Zeichenfolge angegeben ist
    {
        randomString = randomString+obrazecBukv[random.Next(obrazecBukv.Length)];
        //Erhöhe die Zeichenfolge jedes Mal um einen zufälligen Buchstaben
    }
    return randomString;
}

Boolean Polyndrom(string sampleString)// Lassen Sie uns eine rekursive Methode erstellen, die prüft
                                      // ob die Zeichenfolge ein Polydrom ist
{
    if (sampleString.Length <= 1) //wenn die Anzahl der Zeichen kleiner wird oder
                                  //gleich 1 oder wann anfangs 1 sein wird,
                                  //dann wird es ein Polydrom sein
    {
        return true;
    }
    else if (sampleString[0] == sampleString[sampleString.Length-1])
        //Wenn die äußersten Zeichen gleich sind, können wir mit den nächsten fortfahren
    {
        return Polyndrom(sampleString.Substring(1, sampleString.Length - 2));
        //Wir werden dies tun, indem wir unsere Methode noch einmal durchgehen, aber wir werden es nicht berücksichtigen
        //diese extremen Zeichen, die bereits überprüft wurden (entfernen)
    }
    else { return false; } //wenn irgendwo die Extremzeichen nicht gleich sind,
                           //Das ist kein Polydrom
}

Console.WriteLine(Polyndrom(sampleString(3))); //allerdings sogar mit 3 Werten pro Zeile
                                               //schwer zu fangendes Polydrom
