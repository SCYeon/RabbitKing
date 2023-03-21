using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainUI : MonoBehaviour
{
    [SerializeField]
    GameObject _hpPrefab;
    
    Vector3 startPos = new Vector3(-8.0f, 4.0f, 0.0f);

    CharacterData _dataManager;
    private void Awake()
    {
        _dataManager = GameObject.Find("Data").GetComponent<CharacterData>();
        SetHPUI();
    }
    void SetHPUI() 
    {
        int count = _dataManager.GetHP();

        for (int i = 0; i < count; ++i)
        {
            GameObject hpPrefab = Instantiate(_hpPrefab);
            hpPrefab.transform.position = startPos;
            startPos += new Vector3(0.7f, 0.0f, 0.0f);
        }
    }
    
    //Button Event
    public void ClickStore()
    {
        SceneManager.LoadScene("StoreScene");
    }
    public void ClickGame(int num) 
    {
        if (num == 1)
            SceneManager.LoadScene("Game1Scene");
        else if(num == 2)
            SceneManager.LoadScene("Game2Scene");
        else if(num == 3)
            SceneManager.LoadScene("Game3Scene");
    }
}   
