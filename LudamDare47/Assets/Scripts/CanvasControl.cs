using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CanvasControl : MonoBehaviour
{
    // Start is called before the first frame update
    public RobotMovement movement;
    public GameObject PausePanel, gameOverPanel,levelPanel;
    //public HeroMovement hero;
    public bool gamePaused;
    void Start()
    {
        // hero= GameObject.FindWithTag("Player").GetComponent<HeroMovement>();
        gamePaused = false;
        // PausePanel.SetActive(false);
        // gameOverPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!movement.playerDead)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (!gamePaused)
                {

                    pause();
                    //hero.gameControls = false;
                    //hero.alive = false;
                }
                else
                {
                    //hero.alive = true;
                    resume();
                    //hero.gameControls = true;
                }
            }
        }
        else
        {
            Invoke("GameOver", 1f);
        }
    }
    public void pause()
    {
      //  Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
        gamePaused = true;
        PausePanel.SetActive(true);
        levelPanel.SetActive(false);
    }
    public void resume()
    {
       // Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
        gamePaused = false;
        // hero.gameControls = true;
        levelPanel.SetActive(true);
        PausePanel.SetActive(false);
    }

    public void quitGame()
    {
        Application.Quit();
    }
    public void restart()
    {
        Time.timeScale = 1f;
        gamePaused = false;
       // hero.gameControls = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void GameOver()
    {
       // Cursor.lockState = CursorLockMode.None;
        gameOverPanel.SetActive(true);
        levelPanel.SetActive(false);
    }
}
