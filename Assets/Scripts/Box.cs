using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Box : MonoBehaviour, IClicked
{
    public void OnClickAction()
    {
        SceneManager.LoadScene("InsideBox");
    }
}
