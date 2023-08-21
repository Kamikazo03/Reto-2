using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CofresCueva : MonoBehaviour
{
    public GameObject cofre ;
    public GameObject cofreCerrado ;
    public GameObject cofreAbierto ;
    public GameObject plataformasubible ;
    public GameObject terreno ;
    public GameObject plataformasubible21 ;
    public GameObject plataformasubible22 ;

    public float cantidadPuntos;
    public Puntaje puntaje;
    public Puertapuntaje puertapuntaje;   


    private void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("Player") || (other.CompareTag("Box"))) {
             Debug.Log("si sirvio");
            cofreCerrado.SetActive(false);
            cofreAbierto.SetActive(true);
            plataformasubible.SetActive(true);
            plataformasubible21.SetActive(false);
            plataformasubible22.SetActive(true);
            terreno.SetActive(true);
            cofre.GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("completo");
            AudioManager.Instance.PlaySFX("Tesoro");


            puntaje.SumarPuntos(cantidadPuntos);
            puertapuntaje.SumarPuntos(cantidadPuntos);

    }
    }
}


