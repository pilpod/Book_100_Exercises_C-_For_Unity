using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_16 : MonoBehaviour
{
    /*
     * Crea un objeto que se desplace en el eje Z
     * una unidad al soltar la tecla espaciadora.
     */

    private float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            //transform.position += Vector3.forward * speed;
            transform.Translate(Vector3.forward * speed);
        }
    }
}
