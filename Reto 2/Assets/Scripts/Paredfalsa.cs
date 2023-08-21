using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paredfalsa : MonoBehaviour
{
    public GameObject ParedVisible;
    public GameObject ParedInvisible;
    public GameObject Luz1;

    private void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("Player"))
            {
            Debug.Log("si sirvio");
            ParedVisible.SetActive(false);
            ParedInvisible.SetActive(true);
            Luz1.SetActive(true);
            }
    }

    private void OnTriggerExit2D(Collider2D other) {

        if(other.CompareTag("Player"))
        {
            Debug.Log("confirmo");
            ParedVisible.SetActive(true);
            ParedInvisible.SetActive(false);
            Luz1.SetActive(false);

        }
    }


}
