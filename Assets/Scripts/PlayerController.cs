using System;
using UnityEngine;
using System.Collections;
 
public class PlayerController : MonoBehaviour {
   
    public Vector2 targetPosition;

    public Transform player;
    // Update is called once per frame
    public void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
        targetPosition = player.transform.position;
    }

    void Update () {
        if (targetPosition.y > -2f || targetPosition.y < -2f)
            targetPosition.y = -2f;
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        transform.position = Vector2.Lerp(transform.position, targetPosition, Time.deltaTime * 2);
        
    }
}