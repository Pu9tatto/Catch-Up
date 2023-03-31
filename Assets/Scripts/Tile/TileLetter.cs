using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TileLetter : MonoBehaviour
{
    private TMP_Text _textLetter;

    private void Awake()
    {
        _textLetter = GetComponent<TMP_Text>();
    }

    public void WriteLetter(string letter)
    {
        _textLetter.text = letter;
    }

}
