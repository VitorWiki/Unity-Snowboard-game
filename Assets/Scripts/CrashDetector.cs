using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{

    [SerializeField] float tempoDelayChamadaReload = 2f;
    [SerializeField] ParticleSystem crashPoint;
    [SerializeField] AudioClip crashSFX;
    bool effects = true;

    void OnTriggerEnter2D(Collider2D other)
   {
       if(other.tag == "Floor" && effects)
       {
            effects = false;
            FindObjectOfType<PlayerController>().DisableControls();
            crashPoint.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", tempoDelayChamadaReload);
       }
   }

   void ReloadScene()
   {
       SceneManager.LoadScene(0);
   }
}
