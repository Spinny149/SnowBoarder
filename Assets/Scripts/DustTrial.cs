using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrial : MonoBehaviour
{
    [SerializeField] ParticleSystem touchEffect;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag=="Ground")
        {
           touchEffect.Play(); 
        }
    }

    void OnCollisionExit2D(Collision2D other) 
    {
        if(other.gameObject.tag=="Ground")
        {
           touchEffect.Stop(); 
        }
    }
}

