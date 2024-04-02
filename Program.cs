/*
You have a text that some of the words in reverse order.
The text also contains some words in the correct order, and they are wrapped in parenthesis.
Write a function fixes all of the words and,
remove the parenthesis that is used for marking the correct words.

Your function should return the same text defined in the constant correctAnswer, please keep in mind
that shortest way possible will get you extra points.
*/

var inputText = "nhoJ (Griffith) nodnoL saw (an) (American) ,tsilevon ,tsilanruoj (and) laicos .tsivitca ((A) reenoip (of) laicremmoc noitcif (and) naciremA ,senizagam (he) saw eno (of) (the) tsrif (American) srohtua (to) emoceb (an) lanoitanretni ytirbelec (and) nrae a egral enutrof (from) ).gnitirw";
var correctAnswer = "John Griffith London was an American novelist, journalist, and social activist. (A pioneer of commercial fiction and American magazines, he was one of the first American authors to become an international celebrity and earn a large fortune from writing.)";

// Function to reverse text according to certain rules.
// Belirli kurallara göre metni tersine çeviren bir fonksiyon.
string ReverseText(string input)
{
    // Split the input text into an array of words.
    // Giriş metnini kelimelerin bir dizisine ayırır.
    string[] splitList = input.Split(' ');

    // Initialize an empty string to store the result.
    // Sonucu saklamak için boş bir dizeyi başlatır.
    string result = "";

    // Iterate through each word in the splitList.
    // splitList'teki her kelime üzerinden geçer.
    foreach (var split in splitList)
    {
        // Check if the word contains parentheses.
        // Kelimenin parantez içerip içermediğini kontrol eder.
        if (split.Contains("("))
        {
            // If it contains parentheses, extract the substring within parentheses and append it to the result.
            // Parantez içeriyorsa, parantez içindeki alt dizeyi çıkarır ve sonuca ekler.
            string substring = split.Substring(1, split.Length - 2);
            result += substring + " ";
        }
        else
        {
            // If it does not contain parentheses, reverse the word and append it to the result.
            // Parantez içermiyorsa, kelimeyi tersine çevirir ve sonuca ekler.
            char[] chars = split.ToCharArray();
            Array.Reverse(chars);
            result += new string(chars) + " ";
        }
    }
    // Trim any leading or trailing spaces and return the result.
    // Önde veya arkada boşluk varsa kaldırır ve sonucu döndürür.
    return result.Trim();
}

// Check if the reversed text matches the correct answer and print the result.
// Tersine çevrilen metnin doğru cevaba eşit olup olmadığını kontrol eder ve sonucu yazdırır.
Console.WriteLine(ReverseText(inputText) == correctAnswer ? "Correct !!!" : "Wrong answer...!");
Console.ReadLine();