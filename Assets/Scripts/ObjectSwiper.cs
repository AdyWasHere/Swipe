using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSwiper : MonoBehaviour {

    public Swipe swipeControls;
    public Transform player;
    private Vector2 desiredPosition;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (swipeControls.SwipeRight)
        {
            desiredPosition += Vector2.right;
        }

        if (swipeControls.SwipeLeft)
        {
            desiredPosition += Vector2.left;
        }

        if (swipeControls.SwipeUp)
        {
            desiredPosition += Vector2.up;
        }

        if (swipeControls.SwipeDown)
        {
            desiredPosition += Vector2.down;
        }

        player.transform.position = Vector2.MoveTowards(player.transform.position, desiredPosition, 3f * Time.deltaTime);

    }
}
