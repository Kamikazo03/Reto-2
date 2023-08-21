using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class palancasubible : MonoBehaviour
{
    public GameObject palancaA ;
    public GameObject palancaB ;
    public GameObject plataforma1 ;
    public GameObject plataforma2 ;


    private void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("Player")) {
            palancaA.SetActive(false);
            palancaB.SetActive(true);
            plataforma1.SetActive(false);
            plataforma2.SetActive(true);
            AudioManager.Instance.PlaySFX("Palanca");
    }
    }

     private void OnTriggerExit2D(Collider2D other){

        if(other.CompareTag("Player")) {
            palancaA.SetActive(true);
            palancaB.SetActive(false);
    }
    }
}
