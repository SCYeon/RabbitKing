using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainUI : MonoBehaviour
{
    CharacterData _dataManager;
    private void Awake()
    {
        _dataManager = GameObject.Find("Data").GetComponent<CharacterData>();
    }
    //Button Event
    public void ClickStore()
    {
        SceneManager.LoadScene("StoreScene");
    }
    public void ClickGame(int num) 
    {
        if (num == 1)
        {
            SceneManager.LoadScene("Game1Scene");
        }
        else if(num == 2)
        {
            if (_dataManager.CheckStage() == 1 || _dataManager.CheckStage() == 3)
                SceneManager.LoadScene("Game2Scene");
            else
                Debug.Log("Stage2 �̱���");
        }
        else if(num == 3)
        {
            if(_dataManager.CheckStage() == 2 || _dataManager.CheckStage() == 3)
                SceneManager.LoadScene("Game3Scene");
            else
                Debug.Log("Stage3 �̱���");
        }
    }
}   
