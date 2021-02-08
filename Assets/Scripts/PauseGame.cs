using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public bool gamePause =false;
    public AudioSource levelMusic;
    public GameObject pauseMenue;
    public AudioSource pauseJingle;

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (gamePause == false)
            {
                pauseJingle.Play();
                pauseMenue.SetActive(true);
                Time.timeScale = 0;
                Cursor.visible = true;
                gamePause = true;
                levelMusic.Pause();
            }
            else
            {
                pauseMenue.SetActive(false);
                levelMusic.UnPause();
                Cursor.visible = false;
                gamePause = false;
                Time.timeScale = 1;
            }
        }

    }
    public void ResumeGame()
    {
        pauseMenue.SetActive(false);
        levelMusic.UnPause();
        Cursor.visible = false;
        gamePause = false;
        Time.timeScale = 1;
    }
    public void RestartGame()
    {
        pauseMenue.SetActive(false);
        levelMusic.UnPause();
        Cursor.visible = false;
        gamePause = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }
    public void QuitToMenue()
    {
        pauseMenue.SetActive(false);
        levelMusic.UnPause();
        Cursor.visible = true;
        gamePause = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
}
