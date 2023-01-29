using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
    // Create and choose random prompt from prompts list
    static string[] prompts = {"What miracles did you see today?", "What was your favorite thing that happened today?", "What are you excited about this week?", 
    "What was your most interesting interaction today?", "What was the best part of your day?"
    };
    static Random _rnd = new Random();
    static List<string> _promptsRange = new List<string>(prompts);
    int r = _rnd.Next(_promptsRange.Count);
    static DateTime _theCurrentTime = DateTime.Now;
    string _date = _theCurrentTime.ToShortDateString();
    public void Display()
    {
        _entries.AddRange(_loadEntries);
        System.Console.WriteLine("Entry--------");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void AddEntry()
    {
        System.Console.Write($"Date: {_date},");
        string date = _date;

        System.Console.Write($"Prompt: {(string)_promptsRange[r]},");
        string prompt = (string)_promptsRange[r];

        System.Console.Write($"Enter Response: ");
        string response = System.Console.ReadLine();

        Entry newEntry = new Entry();
        newEntry._date = date;
        newEntry._prompt = prompt;
        newEntry._response = response;

        _entries.Add(newEntry);
    }

    
    public void Save()
    {
        System.Console.WriteLine("Enter a name for your file: ");
        string fileName = System.Console.ReadLine();
        using (StreamWriter _outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                _outputFile.Write($"Date: {entry._date}");
                _outputFile.Write($"{entry._prompt}");
                _outputFile.Write($"{entry._response}");
            }
        }
    }

    public List<Entry> Load()
    {
        System.Console.WriteLine("Enter file name: ");
        string fileName = System.Console.ReadLine();

        public List<Entry> _loadEntries = new List<Entry>();

        string[] lines = System.IO.File.ReadAllLines(fileName);


        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];
            Entry loadedEntry = new Entry();
            loadedEntry._date=date;
            loadedEntry._prompt=prompt;
            loadedEntry._response=response;

            _loadEntries.Add(loadedEntry)
        }
        return _loadEntries;
    }

}