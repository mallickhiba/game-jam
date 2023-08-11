using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    List<Transform> _spawnPoints;
    public Transform spawnUp;
    public Transform spawnDown;
    public Transform spawnLeft;
    public Transform spawnRight;
    public GameObject enemy;

    void Start() {
       _spawnPoints.Add(spawnUp);
       _spawnPoints.Add(spawnDown);
       _spawnPoints.Add(spawnLeft);
       _spawnPoints.Add(spawnRight);
    }

    public void Spawn() {
        int index = UnityEngine.Random.Range(0, 4);

        Transform randomSpawnPoint = _spawnPoints[index];

        Instantiate(enemy.transform, randomSpawnPoint.position, randomSpawnPoint.rotation);


    }

    

}