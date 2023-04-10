using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Game2UI : MonoBehaviour
{
    [SerializeField]
    GameObject _panel;
    [SerializeField]
    TextMeshProUGUI _clear;
    [SerializeField]
    TextMeshProUGUI _over;
    [SerializeField]
    TextMeshProUGUI _gold;

    bool _getCoin = false;

    HPUI _hpManager;
    CharacterData _characterData;

    void Awake()
    {
        Time.timeScale = 1.0f;
        _hpManager = GameObject.Find("Main Camera").GetComponent<HPUI>();
        _characterData = GameObject.Find("Data").GetComponent<CharacterData>();
        _panel.SetActive(false);
    }

    public void Result(int num)
    {
        _panel.SetActive(true);
        switch (num)
        {
            case 0:
                _clear.gameObject.SetActive(true);
                _gold.text = "Reward 50 Gold !";
                if (!_getCoin)
                    _characterData.AddCoin(50);
                break;
            case 1:
                _clear.gameObject.SetActive(true);
                _gold.text = "Reward 30 Gold !";
                if (!_getCoin)
                    _characterData.AddCoin(30);
                break;
            case 2:
                _over.gameObject.SetActive(true);
                _gold.text = "Reward 10 Gold...";
                if (!_getCoin)
                    _characterData.AddCoin(10);
                break;
        }
        Time.timeScale = 0.0f;
        _getCoin = true;
    }
    //Button Event
    public void ClickBack() { SceneManager.LoadScene("MainScene"); }
}
