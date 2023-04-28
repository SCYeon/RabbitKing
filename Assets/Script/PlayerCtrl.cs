using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    [SerializeField]
    int _speed = 10;

    int _size = 1;
    Rigidbody2D _rigidbody2D;

    Transform[] _children = null;
    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _children = new Transform[transform.childCount];
        int i = 0;
        foreach(Transform T in transform) { _children[i++] = T; }
    }
    void Update()
    {
        PlayerMove();
    }
    public void PlayerScale(int size) { _size = size; }
    void PlayerMove()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(_speed * Time.deltaTime, 0, 0));
            transform.DetachChildren();
            transform.localScale = new Vector3(_size, _size, _size);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-_speed * Time.deltaTime, 0, 0));
            transform.DetachChildren();
            transform.localScale = new Vector3(-_size, _size, _size);

        }
        foreach (Transform T in _children)
            T.parent = transform;
    }
}
