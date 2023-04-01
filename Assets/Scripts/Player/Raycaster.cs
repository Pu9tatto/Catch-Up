using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    private Vector3[] _directions = { Vector3.up, Vector3.right, Vector3.down, Vector3.left };
    public Tile GetTileTo(Vector3 direction, float rayDistance)
    {
        RaycastHit[] rays = Physics.RaycastAll(transform.position, direction, rayDistance);
        foreach (RaycastHit ray in rays)
        {
            if (ray.collider.TryGetComponent(out Tile tile))
            {
                return tile;
            }
        }
        return null;
    }

    public List<Tile> GetTilesToDirection(Vector3 direction, float rayDistance)
    {
        List<Tile> result = new List<Tile>();
        RaycastHit[] rays = Physics.RaycastAll(transform.position, direction, rayDistance);
        foreach (RaycastHit ray in rays)
        {
            if (ray.collider.TryGetComponent(out Tile tile))
            {
                result.Add(tile);
            }
        }
        return result;
    }

    public List<Tile> GetTilesToDirections(float rayDistance)
    {
        List<Tile> result = new List<Tile>();
        foreach (Vector3 direction in _directions)
        {
            RaycastHit[] rays = Physics.RaycastAll(transform.position, direction, rayDistance);
            foreach (RaycastHit ray in rays)
            {
                if (ray.collider.TryGetComponent(out Tile tile))
                {
                    result.Add(tile);
                }
            }
        }
        return result;
    }

    public Tile GetTileWithLetter(string letter)
    {
        letter = letter.ToUpper();
        foreach(Vector3 direction in _directions)
        {

            Tile tile = GetTileTo(direction, 1f);
            if (tile == null) continue;
            if (tile.Letter() == letter)
            {
                return tile;
            }
        }
        return null;
    }
}
