using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    HPUI _hpManager;
    Game2Manager _gameManager;

    Collider2D _collider;
    private void Awake()
    {
        _hpManager = GameObject.Find("Main Camera").GetComponent<HPUI>();
        _gameManager = GameObject.Find("Main Camera").GetComponent<Game2Manager>();
        _collider = GetComponent<Collider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(this.CompareTag("Finish"))
                _gameManager.ResultCalc();
            else
            {
                _hpManager.DecreaseHPUI();
                _collider.isTrigger = true;
            }
        }
    }
}
