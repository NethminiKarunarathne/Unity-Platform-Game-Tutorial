using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenueFunction : MonoBehaviour
{
    public AudioSource buttonPress;
    public int bestScore;
    public GameObject bestScoreDisplay;

    void Start()
    {
       
        bestScore = PlayerPrefs.GetInt("levelScore");
        bestScoreDisplay.GetComponent<Text>().text = "Best: " + bestScore;
    }

    public void PlayGame()
    {
        buttonPress.Play();
        RedirectToLevel.redirectToLevel = 3;
        SceneManager.LoadScene(2);
    }
    public void QuitGame()
    {
        buttonPress.Play();
        Application.Quit();

    }
    public void PlayCredits()
    {
        buttonPress.Play();
        SceneManager.LoadScene(4);
    }
    public void resetBest()
    {
        PlayerPrefs.SetInt("levelScore", 0);
        PlayerPrefs.SetInt("levelScore5", 0);
        bestScoreDisplay.GetComponent<Text>().text = "Best: " + bestScore;
    }
}
