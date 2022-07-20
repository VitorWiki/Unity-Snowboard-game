using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
   
   [SerializeField] float tempoDelayChamadaReload = 0.5f;
   [SerializeField] ParticleSystem finishLine;
   bool sound = true;
   void OnTriggerEnter2D(Collider2D other)
   {
       if(other.tag == "Player" && sound)
       {
            FindObjectOfType<PlayerController>().DisableControls();
            finishLine.Play();
            GetComponent<AudioSource>().Play();
            sound = false;
            Invoke("ReloadScene", tempoDelayChamadaReload);
            
       }
       
   }

   void ReloadScene()
   {
       SceneManager.LoadScene(0);
   }
}
