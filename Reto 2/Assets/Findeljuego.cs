using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Findeljuego : MonoBehaviour
{
    public int Escena;
    void Update()
    {
        if (transform.position.x > 13){
        SceneManager.LoadScene(Escena);
        }
    }

}
