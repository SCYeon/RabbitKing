using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game1UI : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI _timer;

    float _setTime = 30;
    private void Update()
    {
        _setTime -= Time.deltaTime;

        if (_setTime < 60 && _setTime >= 0)
            _timer.text = _setTime.ToString("F0");
    }

}
