using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

public class AnagramFinder
{

    public List<string> words;
    public List<List<string>> anagramGroups;

    public AnagramFinder(string filename)
    {
        words = FileReader.GetWords();
        anagramGroups = new List<List<string>>();
        IdentifyAnagrams();
    }

    private void IdentifyAnagrams()
    {
        foreach (var curWord in words)
        {
            List<string> anagrams = new List<string>();
            foreach (var item in words)
            {
                if (IsAnagram(curWord, item))
                {
                    if (!IsIncluded(item))
                    {
                        anagrams.Add(item);
                    }
                }

            }
            if (anagrams.LongCount() > 1)
            {
                anagramGroups.Add(anagrams);
            }
        }
    }

    private bool IsIncluded(string word)
    {
        bool included = false;
        anagramGroups.ForEach(list =>
        {
            if (list.Contains(word))
            {
                included = true;
            }
        });
        return included;
    }

    private bool IsAnagram(string word, string word2)
    {
        if (word.Length != word2.Length)
        {
            return false;
        }

        int size = word.Length;
        int acum = 0;

        List<char> list = word.ToCharArray().ToList();
        for (int i = 0; i < list.LongCount(); i++)
        {
            char ch = list.ElementAt(i);
            if (HasChar(word2, ch))
            {
                acum++;
            }
        }
        return acum == size;
    }

    private bool HasChar(string s, char c)
    {
        bool has = false;
        s.ToCharArray().ToList().ForEach(ch =>
        {
            if (ch == c)
            {
                has = true;
            }
        });
        return has;
    }

    public List<List<string>> GetAnagramGroups()
    {
        return anagramGroups;
    }


}
