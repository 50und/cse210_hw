using System;
using System.Collections.Generic;

class Verse
{
    List<Word> _words = new List<Word>{};

    public Verse()
    {

    }
    public Verse(string text)
    {
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

    }

    public bool HideWord(int count)
    {
        return false;
    }
}