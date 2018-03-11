using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour {

    private bool tap, swipeUP, swipeLEFT, swipeDOWN, swipeRIGHT;
    private bool isDraging = false;
    private Vector2 startTouch, swipeDelta;
	

    public Vector2 SwipeDelta { get { return swipeDelta; } }
    public bool SwipeLeft { get { return swipeLEFT; } }
    public bool SwipeRight { get { return swipeRIGHT; } }
    public bool SwipeUp { get { return swipeUP; } }
    public bool SwipeDown { get { return swipeDOWN; } }

    void Update () {
        tap = swipeDOWN = swipeUP = swipeRIGHT = swipeLEFT = false;

        if(Input.GetMouseButtonDown(0))
        {
            isDraging = true;
            tap = true;
            startTouch = Input.mousePosition;

        }
        else if (Input.GetMouseButtonUp(0))
        {
            isDraging = false;
            Reset();
        }

        if(Input.touches.Length > 0)
        {
            if(Input.touches[0].phase == TouchPhase.Began)
            {
                isDraging = true;
                tap = true;
                startTouch = Input.touches[0].position;
            }
            else if(Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
            {
                isDraging = false;
                Reset();
            }
        }

        swipeDelta = Vector2.zero;
        if(isDraging)
        {
            if(Input.touches.Length > 0)
            {
                swipeDelta = Input.touches[0].position - startTouch;
            }
            else if(Input.GetMouseButton(0))
            {
                swipeDelta = (Vector2)Input.mousePosition - startTouch;
            }
        }

        if(swipeDelta.magnitude > 50)
        {

            float x = swipeDelta.x;
            float y = swipeDelta.y;
            if(Mathf.Abs(x) > Mathf.Abs(y))
            {
                if (x < 0)
                    swipeLEFT = true;
                else
                    swipeRIGHT = true;

            }
            else
            {
                if (y < 0)
                    swipeDOWN = true;
                else
                    swipeUP = true;
            }
            Reset();   
        }
	}
	
	
    private void Reset()
    {
        startTouch = swipeDelta = Vector2.zero;
        isDraging = false;
    }
}
