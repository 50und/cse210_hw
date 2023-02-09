using System;
using System.Collections.Generic;

class Entry
{
    public string _date = "";
    public string _prompt = "";
    public string _response = "";


    public void Display()
    {
        System.Console.WriteLine($"Date: {_date}");
        System.Console.WriteLine($"Prompt: {_prompt}");
        System.Console.WriteLine($"Response: {_response}");
    }

 
}