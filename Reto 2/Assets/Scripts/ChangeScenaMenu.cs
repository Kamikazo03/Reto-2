using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenaMenu : MonoBehaviour
{
    public void changeScena(int scena)
    {
        SceneManager.LoadScene(scena);
        Time.timeScale = 1f;
    }
}
