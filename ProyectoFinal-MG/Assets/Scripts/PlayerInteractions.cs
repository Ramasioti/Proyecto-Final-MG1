using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("GunAmmo"))
        {

            GameManager.Instance.gunAmmo += other.gameObject.GetComponent<AmmoBox>().ammo;
            GameManager.Instance.gunAmmo2 += other.gameObject.GetComponent<AmmoBox>().ammo2;
            GameManager.Instance.gunAmmo3 += other.gameObject.GetComponent<AmmoBox>().ammo3;

            Destroy(other.gameObject);

        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            GameManager.Instance.health -= other.gameObject.GetComponent<Damage>().damage;
            
        }


    }

    
}
