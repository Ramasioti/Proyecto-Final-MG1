using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PostMuerte : MonoBehaviour
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
    public void MainMenu()
    {
        SceneManager.LoadScene("MenuInicio");
    }
}
