using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generarDanoS : MonoBehaviour
{
    public int takeDamage;
    public Health health;

    private void OnCollisionEnter2D(Collision2D other){

        if(other.gameObject.CompareTag("Player"))
        {
            health.RestarVida(takeDamage);
            health.efectoDamage(new Vector2(transform.position.x,transform.position.y), transform.localScale.x);
        }
    }
}
