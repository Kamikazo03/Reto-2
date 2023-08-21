using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public int health;
    public int numOfHearts;
    public GameObject gameOver;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public float tiempoPerdidaControl;
    private PersonajeController_2 player;
    private Animator animator;


    void Start()
    {
        player = GetComponent<PersonajeController_2>();
        animator = GetComponent<Animator>();
    }



    public void RestarVida(int Damage)
    {
        
        health = health - Damage;
        Debug.Log("vida: " + health);

        if(health <= 0){            
            gameOver.SetActive(true);
            AudioManager.Instance.musicSource.Stop();
            AudioManager.Instance.PlaySFX("GameOver");
            Destroy(gameObject);
        }
    }


    public void efectoDamage(Vector2 posicion, float direccion){
        Debug.Log("efecto damage");        
        StartCoroutine(PerderControl());
        animator.SetTrigger("Golpe");
        player.Rebote(posicion, direccion);
    }

    private IEnumerator PerderControl(){
        player.sePuedeMover = false;
        yield return new WaitForSeconds(tiempoPerdidaControl);
        Debug.Log("perdio control");
        player.sePuedeMover = true;

    }

    public void Heal(int heal)
    {
        if((health + heal) > numOfHearts)
        {
            health = numOfHearts;

        }else{
            health = health + heal;
        }
    }


    // Update is called once per frame
    void Update()
    {

        if (health > numOfHearts){
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++) {

            if(i < health){
                hearts[i].sprite = fullHeart;
            } else {
                hearts[i].sprite = emptyHeart;
            }
            
            if(i < numOfHearts){
                hearts[i].enabled = true;
            } else {
                hearts[i].enabled = false;
            }
        }
    }
}
