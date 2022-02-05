using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class player2Paddle : Paddle
{
    private Vector2 direction2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction2 = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            direction2 = Vector2.down;
        }
        else
        {
            direction2 = Vector2.zero;
        }
    }

    void FixedUpdate()
    {
        if (direction2.sqrMagnitude != 0)
        {
            rig.AddForce(direction2 * this.speed);
        }
    }
}
