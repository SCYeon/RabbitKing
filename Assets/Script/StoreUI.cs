using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Linq;

public class StoreUI : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI _coinCount;

    [SerializeField]
    ToggleGroup _toggleGroup;

    [SerializeField]
    TextMeshProUGUI _messageText; 

    CharacterData _dataManager;
    void Awake()
    {
        _dataManager = GameObject.Find("Data").GetComponent<CharacterData>();
        _coinCount.text = _dataManager.GetCoin().ToString();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            _dataManager.AddCoin(1000);
            _coinCount.text = _dataManager.GetCoin().ToString();
        }
    }

    void ItemSet(string item)
    {
        switch (item)
        {
            case "Toggle - HP":
                if(CompareCoin(100))
                    _dataManager.AddHP();
                break;
            case "Toggle - Lotto":
                if (CompareCoin(50))
                {
                    int coin = Random.Range(0, 100);
                    _dataManager.AddCoin(coin);
                    _coinCount.text = _dataManager.GetCoin().ToString();
                }
                break;
            case "Toggle - Stage2":
                if (CompareCoin(50))
                    _dataManager.BuyStage(2);
                break;
            case "Toggle - Stage3":
                if (CompareCoin(200))
                    _dataManager.BuyStage(3);
                break;
            case "Toggle - Crwon":
                if (CompareCoin(500))
                    _dataManager.BuyCrwon();
                break;
        }
    }
    bool CompareCoin(int coin)
    {
        int pre_coin = _dataManager.GetCoin();

        if(pre_coin.CompareTo(coin) < 0)
        {
            _messageText.fontSize = 24;
            _messageText.text = "Not enough \nMoney";
            return false;
        }
        else
        {
            _dataManager.UseCoin(coin);
            _coinCount.text = _dataManager.GetCoin().ToString();
            _messageText.fontSize = 36;
            _messageText.text = "Thanks";
            return true;
        }
    }

    //Button Event
    public void ClickBack() { SceneManager.LoadScene("MainScene"); }
    public void ClickBuy()
    {
        Toggle theActiveToggle = _toggleGroup.ActiveToggles().FirstOrDefault();
        ItemSet(theActiveToggle.name);
    }
}
