using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Map _map;

    void Awake()
    {
        Vector2 startPos = _map.StartPos;
        transform.position = new Vector3(startPos.x, startPos.y, transform.position.z);
    }
}
