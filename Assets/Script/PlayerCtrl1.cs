using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl1 : MonoBehaviour
{
    [SerializeField]
    int _power = 10;

    Rigidbody2D _rigidbody2D;

    bool _isGround = true;
    Animator _anim;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        _anim.SetBool("isRun", true);
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space) && _isGround)
        {
            _anim.SetBool("isRun", false);
            _anim.SetBool("isJump", true);
            _isGround = false;
            _rigidbody2D.AddForce(new Vector3(0, _power, 0));// ForceMode2D.Impulse);
        }

        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            _anim.SetBool("isJump", false);
            _anim.SetBool("isRun", true);
            _isGround = true;
        }
    }
}
