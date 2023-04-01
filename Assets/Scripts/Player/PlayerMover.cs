using TMPro;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _delta;
    [SerializeField] private Raycaster _rayPoint;
    [SerializeField] private Map _map;

    private Vector3 _target;
    private List<Tile> tilesForMove;
    private void Start()
    {
        tilesForMove = _rayPoint.GetTilesToDirections(1f);
        _map.AssingLettersForTiles(tilesForMove);
    }

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            _target = GetTarget(Input.inputString);           
            TryMove(_target);
            Debug.Log(Input.inputString);
        }
    }

    private void TryMove(Vector3 target)
    {
        if (target != transform.position)
        {
            _map.CleareLettersForTiles(tilesForMove);
            transform.position = Vector3.MoveTowards(transform.position, target, _delta);
            tilesForMove = _rayPoint.GetTilesToDirections(1f);
            _map.AssingLettersForTiles(tilesForMove);
        }
    }

    private Vector3 GetTarget(string letter)
    {
        Tile targetTile = _rayPoint.GetTileWithLetter(letter);
        if (targetTile)
            return new Vector3(targetTile.transform.position.x, targetTile.transform.position.y, transform.position.z);
        else
            return transform.position;

    }


    
}
