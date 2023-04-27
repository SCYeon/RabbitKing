using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGoalManager : MonoBehaviour
{
    CharacterData _dataManager;

    bool _isUp = true;

    float _move = 0;

    private void Awake()
    {
        _dataManager = GameObject.Find("Data").GetComponent<CharacterData>();
    }

    private void Update()
    {
        if(_move >= 50 && _isUp)
        {
            _isUp = false;
        }
        else if (_move <= -50 && !_isUp)
        {
            _isUp = true;
        }
        
        if(_isUp)
        {
            _move += Time.timeScale;
        }
        else if (!_isUp)
        {
            _move -= Time.timeScale;
        }

        transform.position = new Vector3(transform.position.x, transform.position.y + (_move * 0.0005f), transform.position.z);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && _dataManager.CheckCrwon())
        {
            Debug.Log("Happy Ending");
        }
        else
        {
            Debug.Log("Nomal Ending");
        }
    }
}
