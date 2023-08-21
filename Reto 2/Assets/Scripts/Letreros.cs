using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letreros : MonoBehaviour
{
    public GameObject canvas;

    private void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("Player") || (other.CompareTag("Box"))) {
             canvas.SetActive(true);
    }
    }

    private void OnTriggerExit2D(Collider2D other) {

        if(other.CompareTag("Player") || (other.CompareTag("Box")))
        {
            canvas.SetActive(false);

        }
    }

}

