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
        
        Destroy(gameObject);

        StartCoroutine(StopSlowUp(3));
        StartCoroutine(noText(3));

    }

    IEnumerator noText(float time)
    {
        yield return new WaitForSeconds(time);
        this.slowmsg.text = "";
        Debug.Log("no slow");
    }
    IEnumerator StopSlowUp(float time)
    {
        yield return new WaitForSeconds(time); // the number corresponds to the number of seconds the speed up will be applied
        this.ball.ballspeed = 600.0f; // back to normal !
    }
}
