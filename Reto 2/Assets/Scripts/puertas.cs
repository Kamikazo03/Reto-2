using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puertas : MonoBehaviour
{
    public GameObject pEntrada ;
    public GameObject pSalida ;


    private void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("Player") || (other.CompareTag("Box"))) {
             Debug.Log("si sirvio");
            pEntrada.SetActive(false);
            pSalida.SetActive(true);
    }
    }

    private void OnTriggerExit2D(Collider2D other) {

        if(other.CompareTag("Player") || (other.CompareTag("Box")))
        {
            Debug.Log("confirmo");
        pEntrada.SetActive(true);
        pSalida.SetActive(false);
        }
    }

}
