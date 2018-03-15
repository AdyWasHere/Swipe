using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public GameObject Spawn;
    private float speed;
    private int i;

	void Start () {
        Spawn = GameObject.FindGameObjectWithTag("Spawn");

        speed = 0.1f;
        i = Spawn.GetComponent<Enemy>().SendSpawnPoint();
        
    }
	

	void Update () {
        
       
        if (i == 0 || i== 1 || i ==2)
        {

            transform.position += Vector3.down * speed;
        }

        if (i == 7 || i ==8 || i ==9)
        {

            transform.position += Vector3.up * speed;
        }

        if (i ==5 || i == 6)
        {

            transform.position += Vector3.right * speed;
        }

        if (i ==3 || i == 4)
        {

            transform.position += Vector3.left * speed;
        }
    }

   
}
