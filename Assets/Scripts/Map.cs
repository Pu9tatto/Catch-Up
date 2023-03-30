using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    [SerializeField] private Tile _tile;
    [SerializeField] private Vector2 _startPosMap;
    [SerializeField] private int _heightMap;
    [SerializeField] private int _widthMap;


    private void Start()
    {
        CreateMap(_startPosMap, _heightMap, _widthMap);
    }

    private void CreateMap(Vector2 startPos, int height, int width)
    {
        for(int i = 0; i < width; i++)
            for(int j = 0; j < height; j++)
                Instantiate(_tile, new Vector2(startPos.x + i, startPos.y + j), Quaternion.identity, transform);
    }
}
