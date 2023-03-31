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

    public void AssignLetter(string letter)
    {
        _letter = letter;
        _textLetter.WriteLetter(letter);
    }

    public bool WithPlayer { get; private set; } = false;

    public void PlayerEnter() => WithPlayer = true;

    public void PlayerExit() => WithPlayer = false;
}
