using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    
    
    public void LoadNextLevel(int x)
    {
        SceneManager.LoadScene(x);
        
    }
    
    public void LoadLevel01()
    {
        SceneManager.LoadScene("Level01");
    }
    public void LoadStartScene()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void LoadGameOverScene()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}