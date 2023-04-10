using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    [SerializeField]
    GameObject[] _moveFloors = new GameObject[4];

    int _index = 0;
    float _time = 0.0f;

    private void Awake()
    {
        _index = _moveFloors.Length;
    }

    void Update()
    {
        _time += Time.deltaTime;
    }

    void RightMove()
    {

    }
    void LeftMove()
    {

    }
}
