// Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
/* char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
var wordList = new List<string>();

var exit = false;
Console.WriteLine("Write words to add to list. When u are finished, press enter...");
while (!exit) {
    var word = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(word)) exit = true;
    else wordList.Add(word.Trim());
}

if (!wordList.Any()) {
    Console.WriteLine("List does not contain any words");
    return;
}

Console.WriteLine("Words beginning with vowel is marked with green color: ");
foreach (var word in wordList) {
    if (vowels.Contains(word.ToLowerInvariant().ToCharArray().ElementAt(0))) {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"{word} ");
        Console.ResetColor();
    }

    else Console.Write($"{word} ");
}
*/

// Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.

List<string> GetConcatList(List<string> wordList) {
    var newList = new List<string>();

    for(var i = 0; i < wordList.Count; i += 2) {
        if (i + 1 < wordList.Count) newList.Add(wordList[i] + wordList[i+1]);
        else newList.Add(wordList[i]);
    }

    return newList;
}

var wordList = new List<string>();

var exit = false;
Console.WriteLine("Write words to add to list. When u are finished, press enter...");
while (!exit) {
    var word = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(word)) exit = true;
    else wordList.Add(word);
}

if (!wordList.Any()) {
    Console.WriteLine("List does not contain any words");
    return;
}

else if (wordList.Count == 1) {
    Console.WriteLine("List does only contain one element");
    return;
}

var concatList = GetConcatList(wordList);
Console.WriteLine("Concat list: ");
foreach(var word in concatList) Console.Write($"{word} ");
