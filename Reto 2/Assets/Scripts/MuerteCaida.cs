using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuerteCaida : MonoBehaviour
{
    private Health health;
    public float nivelPiso;
    //public float cantidadDano;
    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < nivelPiso){
            health.RestarVida(health.health);
        } 
    }
}
