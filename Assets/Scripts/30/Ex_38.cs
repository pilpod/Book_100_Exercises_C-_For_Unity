using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_38 : MonoBehaviour
{
    /*
     * Crea una esfera en reposo sobre un suelo.
     * Mientras la tecla S permanezca pulsada, la
     * esfera debe recibir una fuerza constante hacia arriba y hacia la derecha.
     */

    Rigidbody rb;
    private float m_Thrust = 10f;
    private float _mass = 0.8f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = _mass;
    }

    /*
     * FiedUpdate garantiza un intervalo de tiempo fijo entre fotogramas.
     * Diseñado para trabajar con físicas y movimientos de objetos
     * 
     */
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector3(1, 1) * m_Thrust, ForceMode.Force);
        }
    }

    /*
     * Update is called once per frame. Pero no garantiza un intervalo de tiempo constante entre cada llamada.
     * Ideal para entradas del usuario, como movimientos del teclado o clics del ratón.
     */
    void Update()
    {
    }
}
