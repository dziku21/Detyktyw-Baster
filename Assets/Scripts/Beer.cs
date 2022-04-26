using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Beer : MonoBehaviour, IClicked
{
   public void OnClickAction()
   {
      Destroy(gameObject);
   }
}
