using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Game1UI : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI _timer;
    [SerializeField]
    GameObject _panel;
    [SerializeField]
    TextMeshProUGUI _clear;
    [SerializeField]
    TextMeshProUGUI _over;
    [SerializeField]
    TextMeshProUGUI _gold;
    float _setTime = 30;

    private void Awake()
    {
        _panel.SetActive(false);
    }
    private void Update()
    {
        _setTime -= Time.deltaTime;

        if (_setTime < 60 && _setTime >= 0)
            _timer.text = _setTime.ToString("F0");
        else
        {
            _panel.SetActive(true);
            _clear.gameObject.SetActive(true);
        }
            
    }
    //Button Event
    public void ClickBack() { SceneManager.LoadScene("MainScene"); }
}
