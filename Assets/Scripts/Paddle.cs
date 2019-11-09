using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    float screenWidthInUnits;
    float paddleMinX = -4.9f;
    float paddleMaxX = 4.7f;

    // Start is called before the first frame update
    void Start()
    {
        screenWidthInUnits = 16;   
    }

    // Update is called once per frame
    void Update()
    {
        this.MoveWithMouse();
    }

    public void MoveWithMouse()
    {
        Vector2 pos = new Vector2(transform.position.x, transform.position.y);

        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;

        pos.x = Mathf.Clamp(mousePosInUnits, paddleMinX, paddleMaxX);
        transform.position = pos;

    }
}
