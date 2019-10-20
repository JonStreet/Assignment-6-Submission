using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] private float velocity = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            LaunchBall(velocity);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(gameObject.name + " has collided with " + collision.gameObject.name);
    }

    private void LaunchBall(float v)
    {
        Rigidbody2D myRigidBody2D = GetComponent<Rigidbody2D>();

        myRigidBody2D.velocity = new Vector2(0, v);
    }
}
