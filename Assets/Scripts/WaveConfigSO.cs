using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "wave config", fileName = "New Wave")]
public class WaveConfigSO : ScriptableObject
{
    public List<GameObject> enemyPrefabs;
    [SerializeField] Transform pathPrefab;
    [SerializeField] float moveSpeed = 5f;
    public float betweenSpawn = 1f;
    public float spawnVariance = 0f;
    public float minimumTime = 0.2f;

    public Transform GetStartingWaypoint()
    {
        return pathPrefab.GetChild(0);
    }

    public List<Transform> GetWaypoints()
    {
        List<Transform> waypoints = new List<Transform>();
        foreach (Transform child in pathPrefab)
        {
            waypoints.Add(child);
        }
        return waypoints;
    }
    public int GetEnemys()
    {

        return enemyPrefabs.Count;
    }
    public GameObject GetEnemyPrefab(int index)
    {
        return enemyPrefabs[index];
    }


    public float GetMoveSpeed()
    {
        return moveSpeed;
    }

    public float GetRandomSpawnTime()
    {
        float spawnTime = Random.Range(betweenSpawn - spawnVariance, betweenSpawn + spawnVariance);
        return Mathf.Clamp(spawnTime, minimumTime, float.MaxValue);
    }

}
