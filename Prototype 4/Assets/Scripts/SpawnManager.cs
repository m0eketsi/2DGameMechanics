using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public float XRange = 6.5f;
    public float YRange = 2.5f;
    public int EnemyCount = 0;
    public int WaveCount = 1;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(WaveCount);
    }

    // Update is called once per frame
    void Update()
    {
        EnemyCount = FindObjectsOfType<Enemy>().Length;

        if(EnemyCount == 0)
        {
            WaveCount++;
            SpawnEnemyWave(WaveCount);
        }
    }
    private Vector2 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-XRange, XRange);
        float spawnPosY = Random.Range(-YRange, YRange);
        Vector2 randomPos = new Vector2(spawnPosX, spawnPosY);
        return randomPos;
    }
    private void SpawnEnemyWave(int enemiesToSpawn)
    {
        for(int i = 0; i < enemiesToSpawn; i++)
        {
        Instantiate(EnemyPrefab, GenerateSpawnPosition(), EnemyPrefab.transform.rotation);
        }
    }
}
