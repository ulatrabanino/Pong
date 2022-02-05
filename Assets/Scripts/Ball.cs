using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float ballspeed = 200.0f;
    //float constantSpeed = 100f;
    private Rigidbody ballrig;

    void Awake()
    {
        ballrig = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        ResetPosition();
        AddStartingForce();
    }

    public void ResetPosition()
    {
        Vector3 resetti = new Vector3(0, 1, 266.5f);
        ballrig.position = resetti;
        ballrig.velocity = Vector3.zero;
    }

    public void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        Vector2 direct = new Vector2(x, y);

        ballrig.AddForce(direct * this.ballspeed);
    }

    public void AddForce(Vector2 force)
    {
        ballrig.AddForce(force);
    }

    // Update is called once per frame
    void Update()
    {
       // ballrig.velocity = constantSpeed * (ballrig.velocity.normalized);
    }
}
