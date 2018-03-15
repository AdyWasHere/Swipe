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
            desiredPosition += Vector2.right*2.5f;
        }

        if (swipeControls.SwipeLeft)
        {
            desiredPosition += Vector2.left * 2.5f;
        }

        if (swipeControls.SwipeUp)
        {
            desiredPosition += Vector2.up * 2.5f;
        }

        if (swipeControls.SwipeDown)
        {
            desiredPosition += Vector2.down * 2.5f;
        }

        player.transform.position = Vector2.MoveTowards(player.transform.position, desiredPosition,8f * Time.deltaTime);

    }
}
