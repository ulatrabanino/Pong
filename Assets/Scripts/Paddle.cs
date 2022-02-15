using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Paddle : MonoBehaviour
{
    public float speed = 100;
    protected Rigidbody rig;

    private void Awake()
    {
        rig = GetComponent<Rigidbody>();
    }

    public void ResetPosition()
    {
        rig.position = new Vector2(rig.position.x, 0.0f);
        rig.velocity = Vector2.zero;
    }
}
