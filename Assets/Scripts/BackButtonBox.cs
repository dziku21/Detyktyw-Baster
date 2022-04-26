using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackButtonBox : MonoBehaviour, IClicked
{
    public void OnClickAction()
    {
        SceneManager.LoadScene("GraffityWall");
    }
}
