using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreator : MonoBehaviour
{
    [SerializeField] private List<GameObject> enemys;
    [SerializeField] private float delayТime;

    private float _timeBeforeCreation;

    // Start is called before the first frame update
    void Start()
    {
        _timeBeforeCreation = Random.Range(delayТime/2, delayТime * 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.fixedTime >= _timeBeforeCreation)
        {
            GameObject enemy = enemys[Random.Range(0, 4)];
            Instantiate(enemy, gameObject.transform.position, Quaternion.identity);
            _timeBeforeCreation = Time.fixedTime + Random.Range(delayТime / 2, delayТime * 1.5f);
        }
    }
}
