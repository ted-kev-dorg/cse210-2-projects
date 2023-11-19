using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private int _hiddenWordCount = 0;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWord()
    {
        if (_hiddenWordCount < _words.Count)
        {
            Random random = new Random();
            int randomIndex = random.Next(_words.Count);
            Word word = _words[randomIndex];
            if (!word.IsHidden())
            {
                word.Hide();
                _hiddenWordCount++;
            }
            else
            {
                // If the randomly selected word is already hidden, find another word to hide
                HideRandomWord();
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() ;
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.TrimEnd();
    }

    public bool IsCompletelyHidden()
    {
        return _hiddenWordCount == _words.Count;
    }
}