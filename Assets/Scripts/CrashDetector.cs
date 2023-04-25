using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float deley = 0.3f;
    [SerializeField] ParticleSystem crashEfect;
    [SerializeField] AudioClip crashSFX;


    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground")
        {
            Debug.Log("You Lost");
            FindObjectOfType<PlayerController>().DisableControls();
            crashEfect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", deley);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
