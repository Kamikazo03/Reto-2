using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class palanca : MonoBehaviour
{
    public GameObject palancaA ;
    public GameObject palancaB ;
    public GameObject plataforma ;


    private void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("Player")) {
            palancaA.SetActive(false);
            palancaB.SetActive(true);
            plataforma.SetActive(false);
    }
    }

}
