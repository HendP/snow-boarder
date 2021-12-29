using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
   [SerializeField] float loadDelay = 0.2f;
   void OnTriggerEnter2D(Collider2D other) {
       if(other.tag == "Ground"){
           Debug.Log("Ouch my head hit the ground!");
           Invoke("ReloadScene", loadDelay);
       }
   }

   void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
