using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BonusPoints : MonoBehaviour
{
    public Ball ball;
    public TMP_Text bomsg;
    float x;
    float y;
    float z;
    Vector3 pos;

    public bool giveBonus = false;

    void Start()
    {
        x = Random.Range(-72, 72);
        y = Random.Range(-38, 38);
        z = 266.5f;
        pos = new Vector3(x, y, z);
        transform.position = pos;
    }

    void OnTriggerEnter(Collider other)
    {
        giveBonus = true;
        this.bomsg.text = "Bonus on Score!";
        Destroy(gameObject);

    }
}
