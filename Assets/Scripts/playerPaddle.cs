using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerPaddle : Paddle
{
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            direction = Vector2.up;
        }else if (Input.GetKey(KeyCode.S))
        {
            direction = Vector2.down;
        }else
        {
            direction = Vector2.zero;
        }
    }

    void FixedUpdate()
    {
        if(direction.sqrMagnitude != 0)
        {
            rig.AddForce(direction * this.speed);
        }
    }
}
