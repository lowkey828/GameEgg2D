using System.Collections;
using UnityEngine;

public class SpawnEgg : MonoBehaviour
{
    public GameObject EggPrefabs;
    public float minX = -2.5f, maxX = 2.5f, maxY = 6f;
    public float maxSpawnTime = 4f;
    public float minSpawnTime = 0.5f;
    public float spawnTimeDown = 0.2f;

    void Start()
    {
        StartCoroutine(HandleEgg());
    }

    void Update()
    {
        maxSpawnTime = maxSpawnTime - (spawnTimeDown * Time.deltaTime);

        if (maxSpawnTime < minSpawnTime)
        {
            maxSpawnTime = minSpawnTime;
        }
    }

    IEnumerator HandleEgg()
    {
        while (true)
        {
            float randomX = Random.Range(minX, maxX);
            Vector2 spawnPosition = new Vector2(randomX, maxY);

            Instantiate(EggPrefabs, spawnPosition, Quaternion.identity);

            yield return new WaitForSeconds(maxSpawnTime);
        }
    }
}
