using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
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