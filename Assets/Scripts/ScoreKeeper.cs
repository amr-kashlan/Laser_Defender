using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        ResetScore();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public int GetScore()
    {
        return score;
    }
    public void AddScore()
    {
        score += 100;
    }
    public void ResetScore()
    {
        score = 0;
    }
}
