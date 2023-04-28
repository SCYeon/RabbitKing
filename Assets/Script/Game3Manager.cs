using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game3Manager : MonoBehaviour
{
    [SerializeField]
    Transform _playerTransf;

    string _currentStage;

    PlayerCtrl _playerMananger;
    HPUI _hpManager;
    void Awake()
    {
        Time.timeScale = 1.0f;
        _hpManager = GetComponent<HPUI>();
        _playerMananger = GameObject.Find("Capsule - Player").GetComponent<PlayerCtrl>();
        _playerMananger.PlayerScale(2);
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
