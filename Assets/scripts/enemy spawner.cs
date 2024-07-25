using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    public Transform enemySpawnPoint;
    public GameObject enemyPrefab;
    private float _currentTime;
    public float spawnTime1 = 5f;
    void Start()
    {

        StartCoroutine(CountdownTime());
    }

    private IEnumerator CountdownTime()
    {
        while (true)
        {
            var enemy = Instantiate(enemyPrefab, enemySpawnPoint.position, enemySpawnPoint.rotation);

            yield return new WaitForSeconds((float)spawnTime1);
        }
        yield return null;
    }
}
