using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGoalManager : MonoBehaviour
{
    CharacterData _dataManager;
    private void Awake()
    {
        _dataManager = GameObject.Find("Data").GetComponent<CharacterData>();
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
