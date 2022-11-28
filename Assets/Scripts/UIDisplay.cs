using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;

public class UIDisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    Health health;
    ScoreKeeper scoreKeeper;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        health = FindObjectOfType<Health>();
        scoreKeeper = FindObjectOfType<ScoreKeeper>();



        slider.maxValue = health.GetHealth();
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = health.GetHealth();
        scoreText.text = scoreKeeper.GetScore().ToString("000000000000");
    }
}
