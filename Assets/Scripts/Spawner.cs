using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : PoolObjects
{
    [SerializeField] private GameObject[] _enemyTemplate;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _spawnTime;

    private float _elapsedTime;

    private void Start()
    {
        Initialize(_enemyTemplate);
    }
    private void Update()
    {
        _elapsedTime += Time.deltaTime;
        
        _spawnTime -= Time.deltaTime / 100;

       // Debug.Log("SpawnTime: "+ _spawnTime);
        
        if (_elapsedTime >= _spawnTime)
        {
            if (TryGetObject(out GameObject enemy))
            {
                _elapsedTime = 0;

                int _numberOfSpawnPoint = Random.Range(0, _spawnPoints.Length);

                SetEnemy(enemy, _spawnPoints[_numberOfSpawnPoint].position);
            }
        }
    }
    private void SetEnemy(GameObject enemy, Vector3 spawnPoint)
    {
        enemy.SetActive(true);
        enemy.transform.position = spawnPoint;
    }
}
