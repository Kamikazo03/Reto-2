using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave : MonoBehaviour
{
    public GameObject llave;
    public GameObject ColliderPuerta;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
            ColliderPuerta.GetComponent<Collider2D>().isTrigger = true;
            Destroy(llave);
        }
    }
}
