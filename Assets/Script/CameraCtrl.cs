using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour
{
    [SerializeField]
    GameObject _mainCamera;
    float _time = 0.0f;
    float _setTime = 30.0f;

    [SerializeField]
    float _speed = 0.005f;

    Game2Manager _gameManager;
    private void Awake()
    {
        Time.timeScale = 1.0f;
        _gameManager = GameObject.Find("Main Camera").GetComponent<Game2Manager>();
    }
    void Update()
    {
        if(_setTime >= _time && _gameManager._isPlay)
        {
            _time += Time.deltaTime;
            _mainCamera.transform.position = new Vector3(this.transform.position.x + (_time * _speed), this.transform.position.y, this.transform.position.z);
        }
    }
}
