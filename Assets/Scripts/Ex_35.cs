using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_35 : MonoBehaviour
{
    /*
     * Seguimiento del ex 34: Crear una esfera en el punto Y=10 y un
     * suelo en el Y=0. Hacer que la esfera caiga al 
     * pulsar el espacio. La esfera tiene que rebotar
     * como un balón de baloncesto. Cuando la esfera toque el suelo
     * deberá cambiar de color.
     */

    public PhysicMaterial physicMaterial;
    public float velocity = 10;
    private SphereCollider sphereCollider;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        SetRigidbody();
        SetCollider();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.useGravity = true;
            SpeedUpTheFall();
        }
    }

    private void SetCollider()
    {
        sphereCollider = gameObject.GetComponent<SphereCollider>();
        sphereCollider.material = physicMaterial; // setting bounce public material
    }

    private void SetRigidbody()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    private void SpeedUpTheFall()
    {
        rb.AddForce(Vector3.down * velocity * rb.mass); // speed up the fall
    }
}
