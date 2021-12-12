using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int curScore;
    public bool gamePaused;
     //instance
     public static GameManager instance;

     void Awake()
     {
         //set the intance to this script
         instance = this;
     }

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            TogglePauseGame();
        } 
    }

    public void TogglePauseGame()
    {
        gamePaused =!gamePaused;
        Time.timeScale =gamePaused == true ? 0.0f :1.0f;

        //Toggle the pause menu cursor
        GameUI.instance.TogglePauseMenu(gamePaused);
    }

    public void WinGame()
    {
        //Show win screen
        GameUI.instance.SetEndGameScreen(true, curScore);
    }
    public void LoseGame()
    {
        //Load and set end game screen
        GameUI.instance.SetEndGameScreen(false, curScore);
         Time.timeScale = 0.0f;
        gamePaused = true;
    }
}
