using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{

    public int nextLevel;
    
    int bricksLeft;
    int tempBricksLeft;
    Text text;
    static int score;
    public AudioClip Clip;

    public int brickValues;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   
        void Update()
        {

            GameObject[] bricks = GameObject.FindGameObjectsWithTag("Brick");
            bricksLeft = bricks.Length;
            if (bricksLeft < tempBricksLeft)
        {
            score += brickValues;
        }
        GameObject canvas = GameObject.Find("SCORECANVAS");
        Text[] textValue = canvas.GetComponentsInChildren<Text>();
        textValue[0].text = ("Score:" + score);
        tempBricksLeft = bricksLeft;

         GameObject.FindGameObjectsWithTag("Score");
           

            if (bricksLeft == 0)
            {
            AudioSource.PlayClipAtPoint(Clip, Camera.main.transform.position, 1);
            SceneManager.LoadScene(nextLevel);
            }
        }

    public void LoadLevel01()
    {
        score = 0;
        SceneManager.LoadScene("Level01");
    }

}
