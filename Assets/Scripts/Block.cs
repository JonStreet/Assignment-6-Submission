using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    
    public AudioClip Clip;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(gameObject.name + " has collided with " + collision.gameObject.name);
        Destroy(gameObject);
        AudioSource.PlayClipAtPoint(Clip, Camera.main.transform.position, 1);

    }
}
