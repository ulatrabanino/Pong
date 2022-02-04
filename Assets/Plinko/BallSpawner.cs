using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform[] spawnTransforms;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transform randoTransform = spawnTransforms[Random.Range(0, spawnTransforms.Length)];
            GameObject instance = Instantiate(ballPrefab);
            // instance.GetComponent<Transform>().position = randoTransform.position;
            instance.transform.position = randoTransform.position;
        } 
    }
}
