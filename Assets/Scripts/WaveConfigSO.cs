using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "wave config", fileName = "New Wave")]
public class WaveConfigSO : ScriptableObject
{
    public List<GameObject> enemyPrefabs;
    [SerializeField] Transform pathPrefab;
    [SerializeField] float moveSpeed = 5f;

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



}
