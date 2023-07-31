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
            Debug.Log("enemigo");
            health.efectoDamage(new Vector2(transform.position.x,transform.position.y), transform.localScale.x);
        }
        if(other.CompareTag("Box")){
            Destroy(gameObject);
        }
    }


}

