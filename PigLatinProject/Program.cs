Console.WriteLine("Welcome to Pig Latin Translator!");

while (true)
{
    Console.WriteLine("Enter a word to be translated:");

    string input = Console.ReadLine();
    string news = "";

    //Convert word to a lowercase before translating
    string input2 = input.ToLower();

    //If word starts with vowel, add "way" onto the ending a, e, i, o, u
    //consonant move then add "ay"


    string[] words = input2.Split(' '); //new varialbe that will store my input2 into an array
     foreach(string w in words) //this variable will store each words into the varriable 'w'
     {
         string str = pigLatin(w);
         news += str + " ";
        
     }
    Console.WriteLine(news);

    Console.WriteLine("Translate another line? " + "(y/n)");
    string again = Console.ReadLine().ToLower();

    if (again == "y")
    {
        continue;
    }
    else
    {
        break;
    }
}



static bool Vowel(char c)
{
    return (c == 'A' || c == 'E' ||
            c == 'I' || c == 'O' ||
            c == 'U' || c == 'a' ||
            c == 'e' || c == 'i' ||
            c == 'o' || c == 'u');
}

static string pigLatin(string s)
{
    int len = s.Length; //Gets the number of characters in the string
    int index = -1; //Sets a variable 
    for (int i = 0; i < len; i++)
    {
        if (Vowel(s[i])) //parameter of all of my vowels
        {
            index = i; //starts on the first word and will find the first vowel
            break;
        }
    }
    if (index == 0) //words starts with vowel
    {
        return s + "way";
    }
    else if (index == -1)
    {
        return s;
    }
    else
    {
        return s.Substring(index) + s.Substring(0, index) + "ay";
        //graphic index 'aphic' + (0, index) 'gr' 

    }
        
}




/*  char first = input[0];
    char[] letterBank = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

    if (letterBank.Contains(first))
    {
        Console.WriteLine(input2 + "way");
    }
    else
        pigLatin(input2);
    Console.WriteLine(pigLatin(input2));
*/