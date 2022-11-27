using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] List<WaveConfigSO> waveConfig;
    public float timeBetweenWaves = 0;
    WaveConfigSO currentWave;
    public bool isLooping = true;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemys());
    }
    public WaveConfigSO GetWaveConfig()
    {
        return currentWave;
    }
    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator SpawnEnemys()
    {
        do
        {

            foreach (WaveConfigSO wave in waveConfig)
            {

                currentWave = wave;
                for (int i = 0; i < currentWave.GetEnemys(); i++)
                {
                    Instantiate(currentWave.GetEnemyPrefab(i), currentWave.GetStartingWaypoint().position, Quaternion.identity, transform);
                    yield return new WaitForSeconds(currentWave.GetRandomSpawnTime());
                }
                yield return new WaitForSeconds(timeBetweenWaves);
            }
        } while (isLooping);
    }
}
