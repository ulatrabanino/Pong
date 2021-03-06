using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SlowUp : MonoBehaviour
{
    public Ball ball;
    public TMP_Text slowmsg;
    float x;
    float y;
    float z;
    Vector3 pos;

    void Start()
    {
        x = Random.Range(-72, 72);
        y = Random.Range(-38,38);
        z = 266.5f;
        pos = new Vector3(x, y, z);
        transform.position = pos;
    }

    void OnTriggerEnter(Collider other)
    {
        // We speed up the player and then tell to stop after a few seconds
        this.slowmsg.text = "Slow down!";
        this.ball.ballspeed = 100f;
        Debug.Log("its slow");
        this.ball.removePower();
        Destroy(gameObject);

    }
}
