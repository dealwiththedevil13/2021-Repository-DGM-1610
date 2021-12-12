using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    [Header("Pause Menu")]
    public GameObject pauseMenu;

    [Header("EndGame Screen")]
    public GameObject endGameScreen;
    public TextMeshProUGUI endGameHeaderText;
    
    //instance/Singleton
    public static GameUI instance;
    void awake()
    {
        //Set Instance to this script
        instance = this;
    }
    public void TogglePauseMenu(bool paused)
    {
        pauseMenu.SetActive(paused);
    }
    public void SetEndGameScreen(bool won, int score)
    {
        endGameScreen.SetActive(true);
        endGameHeaderText.text = won == true ? "You win" : "You Lose";
        endGameHeaderText.color = won == true ? Color.green : Color.red;
    }

    public void OnResumeButton()
    {
        GameManager.instance.TogglePauseGame();
    }

    public void OnMenuButton()
    {
        SceneManager.LoadScene("Menu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
