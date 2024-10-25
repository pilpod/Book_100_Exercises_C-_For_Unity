using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_36 : MonoBehaviour
{
    /*
     * Crea una esfera en al punto Y=10 y un suelo en el Y=0.
     * Haz que la esfera caiga al pulsar la tecla espaciadora.
     * La esfera tiene que rebotar como un balón de baloncesto
     * y destruirse al rebotar dos veces.
     */

    public PhysicMaterial PhysicMaterial;
    private Rigidbody rb;
    private readonly int _maxRebounds = 2;
    private int _rebounds = 0;

    // Start is called before the first frame update
    void Start()
    {
        SetCollider();
        SetRigidbody();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.isKinematic = false;
        }
    }

    private void SetCollider() => gameObject.GetComponent<SphereCollider>().material = PhysicMaterial;

    private void SetRigidbody()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        _rebounds++;

        if (_rebounds >= _maxRebounds)
        {
            Destroy(gameObject);
        }
    }
}
