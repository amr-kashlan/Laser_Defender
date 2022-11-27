using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] WaveConfigSO waveConfig;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemys();
    }
    public WaveConfigSO GetWaveConfig()
    {
        return waveConfig;
    }
    // Update is called once per frame
    void Update()
    {

    }
    void SpawnEnemys()
    {
        for (int i = 0; i < waveConfig.GetEnemys(); i++)
        {

            Instantiate(waveConfig.GetEnemyPrefab(i), waveConfig.GetStartingWaypoint().position, Quaternion.identity, transform);
        }
    }
}
