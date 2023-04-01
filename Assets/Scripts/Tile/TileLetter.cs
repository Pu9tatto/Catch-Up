using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TileLetter : MonoBehaviour
{
    public TMP_Text TextLetter{get; private set;}

    private void Awake()
    {
        TextLetter = GetComponent<TMP_Text>();
    }

    public void WriteLetter(string letter)
    {
        TextLetter.text = letter;
    }

}
