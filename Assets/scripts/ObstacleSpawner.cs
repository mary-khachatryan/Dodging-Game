using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;

    public float spawnRate;
    public float maxXpos;

	private void Start()
	{
        StartSpawning();
	}

	void Spawn()
    {

		float randomX = Random.Range(-maxXpos, maxXpos);
		Vector2 spawnPos = new Vector2(randomX, transform.position.y);

		Instantiate(obstacle, spawnPos, Quaternion.identity);


	}

    void StartSpawning() 
    {
        InvokeRepeating("Spawn", 0.5f, spawnRate);

    }
    public void StopSpawning()
    {

        CancelInvoke("Spawn");
    }
}
