using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Tile : MonoBehaviour
{
    private string _letter;
    private TileLetter _textLetter;

    private void Awake()
    {
        _textLetter = GetComponentInChildren<TileLetter>();
    }

    public string Letter() => _letter;

    public void AssignLetter(char letter)
    {
        string letterString = letter.ToString();
        _letter = letterString;
        _textLetter.WriteLetter(letterString);
    }

    public void ClearLetter()
    {
        _letter = string.Empty;
        _textLetter.WriteLetter("");
    }

    public bool WithPlayer { get; private set; } = false;

    public void PlayerEnter() => WithPlayer = true;

    public void PlayerExit() => WithPlayer = false;
}
