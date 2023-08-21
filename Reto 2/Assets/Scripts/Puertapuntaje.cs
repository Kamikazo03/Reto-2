using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puertapuntaje : MonoBehaviour
{
    private float puntos ;
    public float abierto ;
    public GameObject pEntrada ;
    public GameObject pSalida ;
    public GameObject Lapuerta;
    public int Escena;


    public void SumarPuntos(float puntosEntrada)
    {
        puntos += puntosEntrada;

        if(puntos > abierto ){
            Lapuerta.GetComponent<Collider2D>().isTrigger = true;
            pEntrada.SetActive(false);
            pSalida.SetActive(true);
            AudioManager.Instance.PlaySFX("PuertaFinal");
          }
        
    }

    private void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("Player") || (other.CompareTag("Box"))) {
            AudioManager.Instance.musicSource.Stop();
            AudioManager.Instance.PlaySFX("Final");
            SceneManager.LoadScene(Escena);
    }
    }
}
