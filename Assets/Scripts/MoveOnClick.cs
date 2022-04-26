using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnClick : MonoBehaviour
{
    public float speed = 5f;
    Vector2 lastClickedPos;
    bool isMoving;



    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            isMoving = true;
        }

        if (isMoving && (Vector2)transform.position != lastClickedPos)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, lastClickedPos, step);
            
        }
        else
        {
            isMoving = false;
        }
        
    }
}