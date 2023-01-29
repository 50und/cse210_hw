using System;
using System.Collections.Generic;

class Entry
{
    public string _date = "";
    public string _prompt = "";
    public string _response = "";


    public void Display()
    {
        System.Console.Write($"Date: {_date},");
        System.Console.Write($"Prompt: {_prompt},");
        System.Console.Write($"Response: {_response}");
    }

 
}