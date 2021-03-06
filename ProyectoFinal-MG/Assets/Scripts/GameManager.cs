using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    public Text ammoText;
    public static GameManager Instance { get; private set; }

    public int gunAmmo = 10;

    public Text healthText;

    public int health = 100;

    public Text ammoText2;

    public int gunAmmo2 = 20;

    public Text ammoText3;

    public int gunAmmo3 = 35;



    public Text enemyKillsText;

    public int enemyKills = 0;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        ammoText.text = gunAmmo.ToString();
        healthText.text = health.ToString();
        enemyKillsText.text = enemyKills.ToString();
        ammoText2.text = gunAmmo2.ToString();
        ammoText3.text = gunAmmo3.ToString();

        if (health <= 0)
        {
            SceneManager.LoadScene("Muerte");
            Cursor.lockState = CursorLockMode.None;

        }
        

       if (enemyKills >= 16)
       {
            SceneManager.LoadScene("Win"); 
       }

    }

    


    
}
