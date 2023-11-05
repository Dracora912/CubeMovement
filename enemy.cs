using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{ 
    public float speed =5f;
    public float spawnTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world!");
        Invoke("SpawnEnemy" , spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    void SpawnEnemy()
    {
        transform.position = new Vector3(-10f, 0f, 0f);
    }
}

