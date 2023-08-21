using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    // Start is called before the first frame update
    public void pausa()
    {
        Debug.Log("pausa");
        pauseMenu.SetActive(true);
    }

    // Update is called once per frame
    public void continuar()
    {
        Debug.Log("continuar");
        pauseMenu.SetActive(false);
    }
}
