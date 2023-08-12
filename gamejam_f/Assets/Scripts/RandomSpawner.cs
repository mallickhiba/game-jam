using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public int enemyCount;
    public float spawnDelay; // Delay between spawns in seconds

    List<GameObject> _spawnPoints;
    public GameObject spawnUp;
    public GameObject spawnDown;
    public GameObject spawnLeft;
    public GameObject spawnRight;

    public GameObject enemy;

    void Start()
    {
        _spawnPoints = new List<GameObject>();
        _spawnPoints.Add(spawnUp);
        _spawnPoints.Add(spawnDown);
        _spawnPoints.Add(spawnLeft);
        _spawnPoints.Add(spawnRight);

        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        for (int i = 0; i < enemyCount; i++)
        {
            Spawn();
            yield return new WaitForSeconds(spawnDelay);
        }
    }

    public void Spawn()
    {
        int index = UnityEngine.Random.Range(0, 4);
        Debug.Log("Random index: " + index);

        GameObject randomSpawnPoint = _spawnPoints[index];

        Instantiate(enemy, randomSpawnPoint.transform.position, randomSpawnPoint.transform.rotation);
        Debug.Log("Spawned enemy at: " + randomSpawnPoint.transform.position);
    }
}
