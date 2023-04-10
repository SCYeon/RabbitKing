using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game3Manager : MonoBehaviour
{
    [SerializeField]
    Transform _playerTransf;

    HPUI _hpManager;
    void Awake()
    {
        _hpManager = GetComponent<HPUI>();
    }

    void Update()
    {
        if (_playerTransf.position.y <= -9.8f)
        {
            _hpManager.DecreaseHPUI();
            _playerTransf.position = new Vector3(0, -3.68f, 0);
        }

    }
}
