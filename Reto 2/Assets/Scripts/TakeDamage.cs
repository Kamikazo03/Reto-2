using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public int takeDamage;
    public Health health;
    
    private void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            other.GetComponent<Health>().RestarVida(takeDamage);
        }
    }

}

