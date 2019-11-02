using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] private float upVelocity = 10f;
    [SerializeField] private float sideVelocity = 3f;
    public AudioClip Clip;
    float paddleMinX = 3f;
    float paddleMaxX = 12.3f;
    float screenWidthInUnits;

    bool isStarted;

    // Start is called before the first frame update
    void Start()
    {
        screenWidthInUnits = 16;
        isStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isStarted == false)
        {
            preGameStart();
        }

        paddleLocked();
    }

    private void paddleLocked()
    {
        if (Input.GetMouseButtonDown(0) == true && isStarted == false)
        {
            isStarted = true;
            LaunchBall(upVelocity, sideVelocity);
        }
    }

    private void preGameStart()
    {
        Vector2 pos = new Vector2(transform.position.x, transform.position.y);

        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;

        pos.x = Mathf.Clamp(mousePosInUnits, paddleMinX, paddleMaxX);
        transform.position = pos;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(gameObject.name + " has collided with " + collision.gameObject.name);

        AudioSource.PlayClipAtPoint(Clip, Camera.main.transform.position, 1);
    }

    private void LaunchBall(float uV, float sV)
    {
        Rigidbody2D myRigidBody2D = GetComponent<Rigidbody2D>();

        myRigidBody2D.velocity = new Vector2(sV, uV);
    }
}
