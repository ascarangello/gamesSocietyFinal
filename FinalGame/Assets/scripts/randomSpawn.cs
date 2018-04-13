using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSpawn : MonoBehaviour {
    public float max = 10;
    public float min = 5;
    public float minX = -10;
    public float minY = -2.5f;
    private float currTime;
    private float spawnTime;
    public GameObject toBeSpawned;
   

    // Use this for initialization
    void Start () {
        SetRandomTime();
        currTime = min;
	}
	
	// Update is called once per frame
	void Update () {
        currTime += Time.deltaTime;
        if(currTime >= spawnTime)
        {
            SpawnObject();
            SetRandomTime();
        }

	}

    void SpawnObject()
    {
        currTime = 0;
        Instantiate(toBeSpawned, new Vector2(Random.Range(minX, -minX), Random.Range(minY, 0)), toBeSpawned.transform.rotation);
    }

    void SetRandomTime()
    {
        spawnTime = Random.Range(min, max);
    }
}
