using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puertas : MonoBehaviour
{
    public GameObject pEntrada ;
    public GameObject pSalida ;


    private void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("Player")) {
             Debug.Log("si sirvio");
            pEntrada.SetActive(false);
            pSalida.SetActive(true);
    }
    }

    private void OnTriggerExit2D(Collider2D other){
        if(other.CompareTag("Player"))
        {
            Debug.Log("confirmo");
        pEntrada.SetActive(true);
        pSalida.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
