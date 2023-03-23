using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainCtrl : MonoBehaviour
{
    Rigidbody2D _rigidbody2D;

    CharacterData _characterDataManager;
    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _characterDataManager = GameObject.Find("Data").GetComponent<CharacterData>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            // HP 감소
            _characterDataManager.DecreaseHP();
            Debug.Log("플레이어 충돌");
        }
    }

}
