using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject puerta;
    public GameObject cofreCerrado ;
    public GameObject cofreAbierto ;

    private void OnTriggerStay2D(Collider2D other){
        if(other.CompareTag("Player") || other.gameObject.CompareTag("Box")){
        cofreCerrado.SetActive(false);
        cofreAbierto.SetActive(true);
        puerta.GetComponent<Collider2D>().isTrigger = true;
        transform.position = new Vector3(-1.99437f, 4.5f, 1.0f);
        } 
    }

     private void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("Player") || other.gameObject.CompareTag("Box"))
        {
            AudioManager.Instance.PlaySFX("Placa");
        }
    }




    private void OnTriggerExit2D(Collider2D other){
        if(other.CompareTag("Player") || other.gameObject.CompareTag("Box")){
        puerta.GetComponent<Collider2D>().isTrigger = false;
        cofreCerrado.SetActive(true);
        cofreAbierto.SetActive(false);
        transform.position = new Vector3(-1.99437f, 4.762132f, 1.0f);
        } 
    }

}
