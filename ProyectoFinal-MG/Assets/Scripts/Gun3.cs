using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun3 : MonoBehaviour
{

    public Transform spawPoint;

    public GameObject bullet;

    public float shotForce = 1500f;
    public float shotRate = 0.5f;

    private float shotRateTime = 0;








    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Time.time > shotRateTime && GameManager.Instance.gunAmmo3 > 0)
            {
                GameManager.Instance.gunAmmo3--;

                GameObject newBullet;

                newBullet = Instantiate(bullet, spawPoint.position, spawPoint.rotation);

                newBullet.GetComponent<Rigidbody>().AddForce(spawPoint.forward * shotForce);

                shotRateTime = Time.time + shotRate;

                Destroy(newBullet, 5);





            }

        }

    }

}
