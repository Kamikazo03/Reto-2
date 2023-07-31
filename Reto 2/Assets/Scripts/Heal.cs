using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    public int heal;
    public Health health;

    private void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("Player"))
        {
            health.Heal(heal);
            //AudioManager.Instance.PlaySFX("heal");
            Destroy(gameObject);
        }
    }
}
