using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDectection : MonoBehaviour {

    public DeathManager End;
	
	void Start () {
		
	}
	
	
	void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "enemy")
        {
            
            End.GameOver();
            //Debug.Log("Hit!");
        }

    }
}
