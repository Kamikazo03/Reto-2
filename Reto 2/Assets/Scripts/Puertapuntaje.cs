using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puertapuntaje : MonoBehaviour
{
    private float puntos ;
    public float abierto ;
    public GameObject pEntrada ;
    public GameObject pSalida ;
    public GameObject Lapuerta;


    public void SumarPuntos(float puntosEntrada)
    {
        puntos += puntosEntrada;

        if(puntos > abierto ){
            Lapuerta.GetComponent<Collider2D>().isTrigger = true;
          }
        
    }

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
