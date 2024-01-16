//Gib massiv aus Symbolen ein (typ char [,]).
//Mach ein String daraus.


char[] letters = { 'a', 'b', 'c', 'd' }; //Erstellung Tupel
string str = ""; //neue Zeichenkette
for (int i = 0; i < letters.Length; i++) 
{
    str += letters[i]; //übertragen Symbole in Zeichenkette
}
