using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Here are all the Loadscene commands for every button
    public void Startgame()
    {
        SceneManager.LoadScene("Difficultyselection");
    }
    
    public void Easy()
    {
        SceneManager.LoadScene("Easy");
    }
    
    public void Normal()
    {
        SceneManager.LoadScene("Normal");
    }
    
    public void Hard()
    {
        SceneManager.LoadScene("Hard");
    }
    
    public void Impossible()
    {
        SceneManager.LoadScene("Impossible");
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Menu");
    }
    
    public void Victory()
    {
        SceneManager.LoadScene("Menu");
    }
}
