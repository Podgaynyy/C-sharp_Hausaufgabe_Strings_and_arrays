//Git Zeichenkette an, das lateinische Buchstabei in beiden Register hat
//Die groß in klein Umschreiben.

string strings = "cDsDLnwn"; //Provisorische Zeichenkette
void smallLetters(string strings) //Method
{
    string finalString = strings.ToLower(); //Google gibt diese Variante als Vorschlag,
                                            //So kann man ohne Iteration arbeiten
    Console.WriteLine(finalString); // Bildschirm Ausgabe,
                                    // Weil VOID
}

smallLetters(strings); //Funktionsaufruf
