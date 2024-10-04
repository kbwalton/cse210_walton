using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> wordsToHide = _words.Where(word => !word.IsHidden()).ToList();
        
        for (int i = 0; i < numberToHide && wordsToHide.Count > 0; i++)
        {
            int index = random.Next(wordsToHide.Count);
            wordsToHide[index].Hide();
            wordsToHide.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} {string.Join(" ", _words.Select(w => w.GetDisplayText()))}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
