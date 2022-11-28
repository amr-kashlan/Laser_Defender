using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    ScoreKeeper scoreKeeper;


    // Start is called before the first frame update
    void Start()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score = " + scoreKeeper.GetScore();

    }
}
