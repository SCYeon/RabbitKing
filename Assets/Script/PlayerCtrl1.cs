using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl1 : MonoBehaviour
{
    [SerializeField]
    int _power = 10;

    Rigidbody2D _rigidbody2D;

    bool _isJump = false;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space)&&!_isJump)
        {
            _isJump = true;
            _rigidbody2D.AddForce(new Vector3(0, _power, 0), ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            _isJump = false;
        }
    }
}
