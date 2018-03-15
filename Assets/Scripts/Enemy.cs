using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public Transform[] SpawnPoints;
    public GameObject nEnemy;
    private int i;

	void Start () {
        // GetRandomSpawnPoint();
        StartCoroutine(Spawner());
	}
	
	
	void Update () {
		
	}

    void GetRandomSpawnPoint()
    {
        
        i = Random.Range(0, SpawnPoints.Length);
        Instantiate(nEnemy, SpawnPoints[i].position, Quaternion.identity);

    }

    public int SendSpawnPoint()
    {
        
        return i;
    }

    IEnumerator Spawner()
    {
        GetRandomSpawnPoint();
        yield return new WaitForSeconds(0.8f);
        StartCoroutine(Spawner());
    }
}
