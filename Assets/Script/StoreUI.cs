using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StoreUI : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI _coinCount;

    CharacterData _dataManager;
    void Awake()
    {
        _dataManager = GameObject.Find("Data").GetComponent<CharacterData>();
        _coinCount.text = _dataManager.GetCoin().ToString();
    }

    void ItemSet(string item, int price)
    {
        switch (item)
        {
            case "HP":
                _dataManager.AddHP();
                break;
            case "Lotto":
                int coin = Random.Range(0, 1000);
                _dataManager.AddCoin(coin);
                break;
            case "Stage2":
                _dataManager.BuyStage(2);
                break;
            case "Stage3":
                _dataManager.BuyStage(3);
                break;
            case "Crwon":
                _dataManager.BuyCrwon();
                break;
        }
    }

    //Button Event
    public void ClickBack() { SceneManager.LoadScene("MainScene"); }
    public void ClickBuy() {  }
}
