using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainUI : MonoBehaviour
{
    CharacterData _dataManager;

    [SerializeField]
    Image[] _lock = new Image [2];

    private void Awake()
    {
        _dataManager = GameObject.Find("Data").GetComponent<CharacterData>();
        HaveStage();
    }
    //Button Event
    public void ClickStore()
    {
        SceneManager.LoadScene("StoreScene");
    }

    void HaveStage()
    {
        if (_dataManager.CheckStage() == 1 || _dataManager.CheckStage() == 3)
            _lock[0].gameObject.SetActive(false);
        if (_dataManager.CheckStage() == 2 || _dataManager.CheckStage() == 3)
            _lock[1].gameObject.SetActive(false);
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
                Debug.Log("Stage2 미구매");
        }
        else if(num == 3)
        {
            if(_dataManager.CheckStage() == 2 || _dataManager.CheckStage() == 3)
                SceneManager.LoadScene("Game3Scene");
            else
                Debug.Log("Stage3 미구매");
        }
    }
}   
