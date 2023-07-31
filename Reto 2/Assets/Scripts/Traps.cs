using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traps : MonoBehaviour
{
    public int damageTraps;
    public Health health;

    private void OnCollisionEnter2D(Collision2D other){

        if(other.gameObject.CompareTag("Player"))
        {
            health.RestarVida(damageTraps);
            health.efectoDamage(new Vector2(transform.position.x,transform.position.y), transform.localScale.x);
        }
    }
}


