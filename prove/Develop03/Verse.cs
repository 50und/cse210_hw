using System;
using System.Collections.Generic;

class Verse
{
    private List<Word> _words;

    public Verse()
    {

    }
    public Verse(string text)
    {
        _words = new List<Word>();

        char[] delimiter = {' ', ',', '.', '?', '"', ';', ':'};
        string[] words = text.Split(delimiter);
        foreach(string wordStr in words)
        {
            Word word = new Word(wordStr);
            _words.Add(word);

        }
    }
    public void Display()
    {
        foreach (Word word in _words)
        {
            word.Display();
            System.Console.Write(" ");
        }
        System.Console.WriteLine();
    }

    public bool IsAllHidden()
    {
        // ask each word if it is hidden
        // if all are hidden return true, else return false
        // create count, if the count of true is less than the 
        // num in list, return false

        List<bool> hidden = new List<bool>();
        foreach (Word word in _words)
        {
            hidden.Add(word.IsHidden());
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

    public bool HideWord()
    {
        // ask a random word to hide itself
        // if word is already hidden, pick a different word
        // if all are hidden return true
        if (!IsAllHidden())
        {
            // pick a new random index until a word is hidden
            Random random = new Random();
            int index = random.Next(0, _words.Count);
            while (_words[index].IsHidden())
            {
                index = random.Next(0, _words.Count);
            }
            _words[index].Hide();

            if (IsAllHidden())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return true;
        }
    }
}