using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPUI : MonoBehaviour
{
    [SerializeField]
    GameObject _hpPrefab;

    CharacterData _dataManager;
    private void Awake()
    {
        _dataManager = GameObject.Find("Data").GetComponent<CharacterData>();
        SetHPUI();
    }
    public void ResetHPUI()
    {
        int count = _dataManager.GetHP();

        for (int i = 0; i < count; ++i)
            Destroy(GameObject.Find(_hpPrefab.name + "(Clone)"));
    }
    public void SetHPUI()
    {
        Vector3 startPos = new Vector3(-8.0f, 4.0f, 0.0f);

        int count = _dataManager.GetHP();

        for (int i = 0; i < count; ++i)
        {
            GameObject hpPrefab = Instantiate(_hpPrefab);
            hpPrefab.transform.position = startPos;
            startPos += new Vector3(0.7f, 0.0f, 0.0f);
        }
    }
}
