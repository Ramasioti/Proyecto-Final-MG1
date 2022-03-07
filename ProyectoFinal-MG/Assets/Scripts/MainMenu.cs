using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
   
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    
    void Update()
    {
       
    }


    public void EscenaJuego()
    {
        SceneManager.LoadScene("PrimerNivel");
    }
    public void Salir()
    {
        Application.Quit();
    }
}
