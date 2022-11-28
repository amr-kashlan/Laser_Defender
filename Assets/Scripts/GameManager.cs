using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    ScoreKeeper scoreKeeper;
    private void Start()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
        scoreKeeper.ResetScore();
    }

    public void LoadGameOver()
    {
        StartCoroutine(OnGameOver());
    }
    public void Quit()
    {
        {
            Application.Quit();
        }
    }
    public IEnumerator OnGameOver()
    {
        yield return new WaitForSecondsRealtime(1);
        SceneManager.LoadScene(2);
        yield return new WaitForSecondsRealtime(1);

    }
}
