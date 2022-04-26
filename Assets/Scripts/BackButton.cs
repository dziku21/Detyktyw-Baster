using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackButton : MonoBehaviour, IClicked
{
    public Renderer button;
    public Transform player;
    
    public void Start () {
        button = GetComponent<Renderer>();
    }
    
    
    public void Update ()
    {
        if(player.transform.position.x < 0f)
        {
          button.enabled = true;
        }
        else button.enabled = false;
    }
    
    public void OnClickAction()
    {
        SceneManager.LoadScene("GraffityWall");
    }
    
}
