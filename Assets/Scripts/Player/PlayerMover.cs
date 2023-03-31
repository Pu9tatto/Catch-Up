using TMPro;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _delta;
    [SerializeField] private Raycaster _rayPoint;

    private Vector3 _target;

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            _target = GetTarget(Input.inputString);
            Move(_target);
            Debug.Log(Input.inputString);
        }
    }

    private void Move(Vector3 target)
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(target.x, target.y, transform.position.z), _delta);
    }

    private Vector3 GetTarget(Vector3 direction)
    {
        Tile targetTile = _rayPoint.GetTileTo(direction);
        if (targetTile)
            return targetTile.transform.position;
        else 
            return transform.position;

    }
    private Vector3 GetTarget(string letter)
    {
        Tile targetTile = _rayPoint.GetTileWithLetter(letter);
        if (targetTile)
            return targetTile.transform.position;
        else
            return transform.position;

    }
}
