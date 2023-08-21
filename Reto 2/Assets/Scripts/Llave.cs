using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave : MonoBehaviour
{
    public GameObject llave;
    public GameObject ColliderPuerta;
    public GameObject naveA ;
    public GameObject naveP ;
    public GameObject ayuda ;



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
            ColliderPuerta.GetComponent<Collider2D>().isTrigger = true;
            naveA.SetActive(false);
            naveP.SetActive(true);
            ayuda.SetActive(false);
            Destroy(llave);
        }
    }
}
