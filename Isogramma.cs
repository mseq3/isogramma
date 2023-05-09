using System;
using System.Linq;

public static class Isogramma
{
    public static bool Verifica(string word)
    {
        word = word.ToLower();
        for(int i = 0; i < word.Length; i++)
        for(int j = 0; j < word.Length; j++)
        if((word[i] == word[j]) && (i != j) && (word[i] !=' ') && (word[i]!= '-'))
        return false;
        
        return true;
    }

}
