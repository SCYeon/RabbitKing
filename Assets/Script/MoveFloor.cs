using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    [SerializeField]
    GameObject[] _moveFloors = new GameObject[4];

    int _index = 0;
    bool _isLeft = false;
    [SerializeField]
    float _speed = 0.01f;

    private void Awake()
    {
        _index = _moveFloors.Length;
    }

    void Update()
    {
        if (_moveFloors[0].transform.position.x >= 46)
        {
            _isLeft = true;
        }
        else if (_moveFloors[0].transform.position.x <= 36)
        {
            _isLeft = false;
        }
        RightMove(_isLeft);
        LeftMove(_isLeft);
    }

    void RightMove(bool isLeft)
    {
        if(!isLeft)
        {
            _moveFloors[0].transform.position = new Vector3(_moveFloors[0].transform.position.x + _speed, _moveFloors[0].transform.position.y, _moveFloors[0].transform.position.z);
            _moveFloors[2].transform.position = new Vector3(_moveFloors[2].transform.position.x + _speed, _moveFloors[2].transform.position.y, _moveFloors[2].transform.position.z);
        }
        else
        {
            _moveFloors[1].transform.position = new Vector3(_moveFloors[1].transform.position.x + _speed, _moveFloors[1].transform.position.y, _moveFloors[1].transform.position.z);
            _moveFloors[3].transform.position = new Vector3(_moveFloors[3].transform.position.x + _speed, _moveFloors[3].transform.position.y, _moveFloors[3].transform.position.z);
        }
    }
    void LeftMove(bool isLeft)
    {
        if(!isLeft)
        {
            _moveFloors[1].transform.position = new Vector3(_moveFloors[1].transform.position.x - _speed, _moveFloors[1].transform.position.y, _moveFloors[1].transform.position.z);
            _moveFloors[3].transform.position = new Vector3(_moveFloors[3].transform.position.x - _speed, _moveFloors[3].transform.position.y, _moveFloors[3].transform.position.z);
        }
        else
        {
            _moveFloors[0].transform.position = new Vector3(_moveFloors[0].transform.position.x - _speed, _moveFloors[0].transform.position.y, _moveFloors[0].transform.position.z);
            _moveFloors[2].transform.position = new Vector3(_moveFloors[2].transform.position.x - _speed, _moveFloors[2].transform.position.y, _moveFloors[2].transform.position.z);
        }
    }
}
