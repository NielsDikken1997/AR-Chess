using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraVibrate : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
     {
         Handheld.Vibrate();
     }

      void OnTriggerStay(Collider other)
     {
         Handheld.Vibrate();
     }
}
