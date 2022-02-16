using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    public float ballspeed = 600.0f;
    //float constantSpeed = 100f;
    private Rigidbody ballrig;
    public TMP_Text slowmsg;

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

    public void removePower()
    {
        StartCoroutine(StopSlowUp(6));
        StartCoroutine(noText(6));
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
        ballspeed = 600.0f; // back to normal !
    }

}
