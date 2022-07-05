using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWeapon : MonoBehaviour
{


    public GameObject principalWeapon;
    public GameObject secondaryWeapon;
    public GameObject tertiaryWeapon;


    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            principalWeapon.SetActive(true);
            secondaryWeapon.SetActive(false);
            tertiaryWeapon.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            principalWeapon.SetActive(false);
            secondaryWeapon.SetActive(true);
            tertiaryWeapon.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            principalWeapon.SetActive(false);
            secondaryWeapon.SetActive(false);
            tertiaryWeapon.SetActive(true);
        }


    }
}
