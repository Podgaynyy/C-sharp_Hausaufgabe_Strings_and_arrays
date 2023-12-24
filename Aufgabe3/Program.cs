//Задайте произвольную строку. Выясните, является ли она палиндромом.


string sampleString(int length) //создадим метод, который вернёт
                                //случайную строку заданной длины
{
    Random random = new Random(); //будем рандомно выбирать буквы
    string obrazecBukv = "abcdefghijklmnopqrstuvwxyz"; //создадим строку,
                                                 //откуда будем делать рандомный выбор
    string randomString = "";

    for (int i = 0; i < length; i++) //выполним действие столько раз,
                                     //какая длина строки задана 
    {
        randomString = randomString+obrazecBukv[random.Next(obrazecBukv.Length)];
        //каждый раз приращаем строку на случайную букву
    }
    return randomString;
}

Boolean Polyndrom(string sampleString)// создадим рекурсивный метод, который проверить,
                                      // является ли строка полиндромом
{
    if (sampleString.Length <= 1) //когда количество символов станет меньше или
                                  //равно 1 или когда их будет 1 изначально,
                                  //то это будет полиндром
    {
        return true;
    }
    else if (sampleString[0] == sampleString[sampleString.Length-1])
        //если крайние символы равны, то можем переходить к следующим
    {
        return Polyndrom(sampleString.Substring(1, sampleString.Length - 2));
        //это мы сделаем пройдясь ещё раз нашим методом, только не будем учитывать
        //те крайние символы, которые уже проверили (удалим их)
    }
    else { return false; } //если где-то крайние символы не будут равны,
                           //то это не полиндром
}

Console.WriteLine(Polyndrom(sampleString(3))); //однако даже с 3мя значениями в строке
                                               //тяжело поймать полиндром 