using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traps : MonoBehaviour
{
    public int damageTraps;
    public Health health;
    
    private void OnTriggerStay2D(Collider2D other){
        if(other.CompareTag("Player")){
            other.GetComponent<Health>().RestarVida(damageTraps);
        }
    }

}


