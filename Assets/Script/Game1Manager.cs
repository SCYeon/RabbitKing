using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game1Manager : MonoBehaviour
{
    [SerializeField]
    GameObject _rainPrefab;

    float _time = 0.0f;

    private void Awake()
    {
        StartCoroutine(Rainy());
    }

    private void Update()
    {
        _time += Time.deltaTime;
    }

    IEnumerator Rainy()
    {
        do
        {
            GameObject go = Instantiate(_rainPrefab);
            go.transform.position = new Vector3(Random.Range(-8.0f, 8.0f), 5.5f, 0f);
            yield return new WaitForSeconds(Random.Range(0, 2));
        } while (_time <= 30);
    }
}
