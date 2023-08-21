using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cofres : MonoBehaviour
{
    public GameObject cofre;
    public float cantidadPuntos;
    public Puntaje puntaje;
    public Puertapuntaje puertapuntaje;

    private void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("Player"))
        {
            //Instantiate(efecto, transform.position, Quaternion.identity);
            puntaje.SumarPuntos(cantidadPuntos);
            puertapuntaje.SumarPuntos(cantidadPuntos);
            AudioManager.Instance.PlaySFX("Tesoro");
        }
    }
    
    private void OnTriggerExit2D(Collider2D other){
        Debug.Log("sirve");
        cofre.GetComponent<BoxCollider2D>().enabled = false;
        Debug.Log("completo");

    }

}

