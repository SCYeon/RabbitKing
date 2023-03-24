using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class HPUI : MonoBehaviour
{
    [SerializeField]
    GameObject[] _hp = new GameObject[5];

    int _count = 0;
    int _index = 4;

    CharacterData _dataManager;

    private void Awake()
    {
        _dataManager = GameObject.Find("Data").GetComponent<CharacterData>();
        SetHPUI();
        _index = _count;
    }

    public void DecreaseHPUI()
    {
        --_index;
        if (_index >= 0)
        {
            _hp[_index].SetActive(false);
        }
    }

    public int GetIndex() { return _index; }
    public void SetHPUI()
    {
        _count = _dataManager.GetHP();

        for (int i = 0; i < _count; ++i)
        {
            _hp[i].SetActive(true);            
        }
    }
}
