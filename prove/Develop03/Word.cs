using System;
using System.Collections.Generic;
using System.Text;

class Word
{
    private string _text = "";
    private bool _hidden = false;

    public Word()
    {

    }

    public Word(string text)
    {
        _text = text;
    }

    public void Display()
    {
        if (_hidden)
        {
            foreach (char c in _text)
            {
                Console.Write('_');
            }
        }
        else
        {
            System.Console.Write(_text);
        }    
    }

    public void Hide()
    {
        _hidden = true;
    }

    public bool IsHidden()
    {
        if (_hidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    
}