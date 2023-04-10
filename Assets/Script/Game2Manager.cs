using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game2Manager : MonoBehaviour
{
    HPUI _hpManager;
    Game2UI _gameUI;

    public bool _isPlay = false;

    private void Awake()
    {
        _isPlay = true;
        _hpManager = GameObject.Find("Main Camera").GetComponent<HPUI>();
        _gameUI = GameObject.Find("Canvas").GetComponent<Game2UI>();
    }

    private void Update()
    {
        if(_hpManager.GetHP() <= 0)
        {
            _gameUI.Result(2);
            _isPlay = false;
        }
    }
    public void ResultCalc()
    {
        _isPlay = false;
        if (_hpManager.GetHP() >= 3)
            _gameUI.Result(0);
        else if (_hpManager.GetHP() > 0)
            _gameUI.Result(1);
    }
}
