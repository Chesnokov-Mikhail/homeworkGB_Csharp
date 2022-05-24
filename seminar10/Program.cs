Console.Clear();

void PrintString(ref string[] words)
{
    Console.Write("{");
    for(int i = 0; i < words.Length - 1; i++)
        Console.Write(words[i] + ", ");
    Console.Write(words[words.Length - 1]);
    Console.Write("}");
}

// Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве,
// начинающихся на гласную букву.
/*
int CountWordStart(ref string[] words, ref char[] vowels)
{
    int count = 0;
    for(int i = 0; i < words.Length; i++)
    {
        foreach(char vowel in vowels)
        {
            if(char.ToUpper(words[i][0]) == char.ToUpper(vowel))
            {
                count++;
                break;
            }
        }
    }
    return count;
}

string lirics ="There's a lady who's sure all that glitters is gold, and she's buying a stairway to heaven When she gets there she knows, if the stores are all closed, with a word she can get what she came for.";
// массив гласных букв
char[] wordVowel = {'a','e','i','o','u','y'};
string[] words = lirics.Split(" ");
PrintString(ref words);
Console.Write(" -> {0}",CountWordStart(ref words, ref wordVowel));
*/
// Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив,
// объединяя элементы исходного массива попарно.

string[] ItemsPairUp(ref string[] words)
{
    int size = words.Length / 2;
    string[] wordsPair = new string[size];
    for(int i = 0, j = 0; i < wordsPair.Length; i++, j +=2)
    {
        wordsPair[i] = words[j] + words[j+1];
    }
    return wordsPair;
}

string lirics ="There's a lady who's sure all that glitters is gold, and she's buying a stairway to heaven When she gets there she knows, if the stores are all closed, with a word she can get what she came for.";
// массив гласных букв
string[] words = lirics.Split(" ");
PrintString(ref words);
string[] wordsPair = ItemsPairUp(ref words);
Console.Write(" -> ");
PrintString(ref wordsPair);
