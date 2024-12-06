using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_37 : MonoBehaviour
{
    /*
     * Crea una esfera en reposos sobre un suelo.
     * Al pulsar la tecla S, recibe una fuerza puntual
     * hacia arriba y hacia la derecha.
     */

    Rigidbody rb;
    private float m_Thrust = 10f;
    private float _mass = 1f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = _mass;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(new Vector3(1,1) * m_Thrust, ForceMode.Impulse);
        }
    }
}
