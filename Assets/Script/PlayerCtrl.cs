using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    [SerializeField]
    int _speed = 10;
    Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        PlayerMove();
    }
    void PlayerMove()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(_speed * Time.deltaTime, 0, 0));
            transform.localScale = new Vector3(2, 2, 2);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-_speed * Time.deltaTime, 0, 0));
            transform.localScale = new Vector3(-2, 2, 2);
        }
    }
}
