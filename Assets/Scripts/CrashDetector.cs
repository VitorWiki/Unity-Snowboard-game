using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{

    [SerializeField] float tempoDelayChamadaReload = 2f;
    [SerializeField] ParticleSystem crashPoint;

    void OnTriggerEnter2D(Collider2D other)
   {
       if(other.tag == "Floor")
       {
            crashPoint.Play();
            Invoke("ReloadScene", tempoDelayChamadaReload);
       }
   }

   void ReloadScene()
   {
       SceneManager.LoadScene(0);
   }
}
