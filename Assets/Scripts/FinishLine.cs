using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float deley = 0.8f;

    [SerializeField] ParticleSystem finishEfect;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            finishEfect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", deley);
            
        }
        
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
