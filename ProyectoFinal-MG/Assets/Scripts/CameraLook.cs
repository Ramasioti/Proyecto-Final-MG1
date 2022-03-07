using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{



    Vector2 mouseMirar;
    Vector2 suavidadV;

    public float sensibilidad = 5.0f;
    public float suavizado = 2.0f;

    GameObject jugador;

    void Start()
    {
        jugador = this.transform.parent.gameObject;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        md = Vector2.Scale(md, new Vector2(sensibilidad * suavizado, sensibilidad * suavizado));

        suavidadV.x = Mathf.Lerp(suavidadV.x, md.x, 1f / suavizado);
        suavidadV.y = Mathf.Lerp(suavidadV.y, md.y, 1f / suavizado);

        mouseMirar += suavidadV;
        mouseMirar.y = Mathf.Clamp(mouseMirar.y, -90f, 90f);
        transform.localRotation = Quaternion.AngleAxis(-mouseMirar.y, Vector3.right);
        jugador.transform.localRotation = Quaternion.AngleAxis(mouseMirar.x, jugador.transform.up);
    }

    //public float mouseSensivity = 80f;

    //public Transform playerBody;

    //float xRotation = 0;

    // void Start()
    //{

    // }


    //void Update()
    //{

    //  float mouseX = Input.GetAxis("Mouse X")*mouseSensivity * Time.deltaTime;

    //float mouseY = Input.GetAxis("Mouse Y")*mouseSensivity * Time.deltaTime;

    //xRotation += mouseY;

    // xRotation = Mathf.Clamp(xRotation, -90f, 90f);

    // transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

    //playerBody.Rotate(Vector3.up * mouseX);


    //}
}
