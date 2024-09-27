using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject Pipe;
    public float SpawnRate = 2f;
    private float timer = 0f;
    public float heightOffset = 10f;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < SpawnRate)
        {
            timer = timer + Time.deltaTime; // This will add a number that counts up every frame regardless of FPS.
        }

        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    private void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(Pipe,new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint), 0), transform.rotation); // This will spawn Pipe at the position of spawner and at same rotation as the spawner.
    }
}