using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    // Properties
    private string _reference;
    private List<Word> _words;

    // Constructor
    public Scripture(string reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split text into words and initialize Word objects
        string[] textWords = text.Split(' ');
        foreach (string word in textWords)
        {
            _words.Add(new Word(word));
        }
    }

    // Method to hide a specific number of random words
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(0, visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    // Method to get the display text of the scripture
    public string GetDisplayText()
    {
        string visibleText = $"{_reference}\n";
        foreach (Word word in _words)
        {
            // If word is hidden, show underscores, otherwise show the word
            visibleText += (word.IsHidden() ? "_____" : word.GetDisplayText()) + " ";
        }
        return visibleText.Trim();
    }

    // Method to check if all words are hidden
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}