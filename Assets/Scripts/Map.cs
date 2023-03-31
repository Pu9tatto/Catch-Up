using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class Map : MonoBehaviour
{
    [SerializeField] private Tile _tile;
    [SerializeField] private Vector2 _startPosMap;
    [SerializeField] private int _heightMap;
    [SerializeField] private int _widthMap;
    [SerializeField] private List<string> _letters;

    public Vector2 StartPos { get { return _startPosMap; } }
    private void Awake()
    {
        CreateMap(_startPosMap, _heightMap, _widthMap);       
    }

    private void CreateMap(Vector2 startPos, int height, int width)
    {
        for(int i = 0; i < width; i++)
            for(int j = 0; j < height; j++)
            {
                Tile newTile = Instantiate(_tile, new Vector2(startPos.x + i, startPos.y + j), Quaternion.identity, transform);
                newTile.AssignLetter(_letters[Random.Range(0, _letters.Count)]);
            }
    }
}
