using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class Map : MonoBehaviour
{
    [SerializeField] private Tile _tilePrefab;
    [SerializeField] private Vector2 _startPosMap;
    [SerializeField] private int _heightMap;
    [SerializeField] private int _widthMap;
    [SerializeField] private string _letters;

    public Vector2 StartPos { get { return _startPosMap; } }
    private List<char> _lettersForMove = new List<char>();

    private void Awake()
    {
        CreateMap(_startPosMap, _heightMap, _widthMap);       
    }

    private void CreateMap(Vector2 startPos, int height, int width)
    {
        for(int i = 0; i < width; i++)
            for(int j = 0; j < height; j++)
            {
                Instantiate(_tilePrefab, new Vector2(startPos.x + i, startPos.y + j), Quaternion.identity, transform);
            }
    }
    public void AssingLettersForTiles(List<Tile> tiles)
    {
        int tilesCount = tiles.Count;
        CreateRandomLetters(tilesCount);
        for(int i = 0;i < tilesCount;i++)
        {
            tiles[i].AssignLetter(_lettersForMove[i]);
        }
    }
    public void CleareLettersForTiles(List<Tile> tiles)
    {
        foreach (Tile tile in tiles)
        {
            tile.ClearLetter();
        }
    }

    private void CreateRandomLetters(int listCount)
    {
        _lettersForMove.Clear();
        char newChar;
        while(_lettersForMove.Count < listCount)
        {
            newChar = _letters[Random.Range(0, _letters.Length)];
            if (!_lettersForMove.Contains(newChar))
                _lettersForMove.Add(newChar);
        }
    }
}
