using System;
using System.Collections.Generic;

class Scripture
{
    private List<Verse> _verses = new List<Verse>{};

    public Scripture()
    {
        
    }
    public Scripture(List<string> verses)
    {
        foreach (string verseStr in verses)
        {
            Verse verse = new Verse(verseStr);
            _verses.Add(verse);
        }
    }

    public void Display()
    {
        foreach (Verse v in _verses)
        {
            v.Display();
        }
    }

    public bool IsAllHidden()
    {
        // ask each word if it is hidden
        // if all are hidden return true, else return false
        // create count, if the count of true is less than the 
        // num in list, return false

        List<bool> hidden = new List<bool>();
        foreach (Verse verse in _verses)
        {
            hidden.Add(verse.IsAllHidden());
        }

        if (!hidden.Any(c=>c==false))
        {
            return true;
        }
        else
        {
            return false;
        }

    }


    public bool HideWords()
    {
        // hide n words
        // for n in range(0, n) ask a random verse 
        // to hide a word
        if (!IsAllHidden())
        {
            foreach (int n in Enumerable.Range(0,5))
            // pick a new random index until a word is hidden
            {
                Random random = new Random();
                int index = random.Next(0, _verses.Count);
                while (_verses[index].IsAllHidden())
                {
                    index = random.Next(0, _verses.Count);
                }
                _verses[index].HideWord();
                if (IsAllHidden())
                {
                    return true;
                }
            }
            return false;
        }
        else return true;
    }

}