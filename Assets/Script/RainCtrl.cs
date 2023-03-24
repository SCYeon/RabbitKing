using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainCtrl : MonoBehaviour
{
    Rigidbody2D _rigidbody2D;

    HPUI _hpManager;
    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _hpManager = GameObject.Find("Main Camera").GetComponent<HPUI>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            _hpManager.DecreaseHPUI();
        }
    }

}
