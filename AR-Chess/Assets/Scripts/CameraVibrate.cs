using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraVibrate : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
     {
         Debug.Log("----------------------------------------------------------------------------------------------------------------------HOLA");
         Handheld.Vibrate();
     }

      void OnTriggerStay(Collider other)
     {
         Debug.Log("----------------------------------------------------------------------------------------------------------------------HOLA");
         Handheld.Vibrate();
     }
}
