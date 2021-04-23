using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public GameObject[] AIs;
    public GameObject[] Spawners;
	public static int targetAIType = 0;

    public GameObject[] PocketObjects;
    public GameObject[] PocketSpawns;

	private void Awake()
	{
		// Set the AI type that will have the Passport
		targetAIType = Random.Range(0, AIs.Length);
        for (int i = 0; i < 60; i++)
        {
            SpawnAi();
        }

    }

    private void Start()
    {
       
    }

    void SpawnAi()
    {
        //Instantiate the Ai from the array
        Instantiate(AIs[Random.Range(0, AIs.Length)], Spawners[Random.Range(0, Spawners.Length)].transform.position, Quaternion.Euler(0, 0, 0));
    }
    void SpawnCollectable()
    {
        PocketSpawns = GameObject.FindGameObjectsWithTag("Pocket");
        Instantiate(PocketObjects[Random.Range(0, PocketObjects.Length)], PocketSpawns[Random.Range(0, PocketSpawns.Length)].transform.position, Quaternion.Euler(0, 0, 0));
    }
}

