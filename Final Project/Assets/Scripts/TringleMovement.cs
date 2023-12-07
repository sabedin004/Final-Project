using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TringleMovement : MonoBehaviour
{
    //variable for speed

    public float xSpeed = 0; //variable for x speed
    private bool horizontal;
    private float border = 6.1f;   


    void Start()
    {
        xSpeed = 0.01f;
        horizontal = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (horizontal==true)
        {
            transform.position = new Vector2(transform.position.x + xSpeed, transform.position.y);
        }
        if (horizontal==false)
        {
            transform.position = new Vector2(transform.position.x - xSpeed, transform.position.y);
        }

        if(transform.position.x<-border)
        {
            horizontal = true;
        }
        if (transform.position.x > border)
        {
            horizontal = false;
        }

    }
}
