using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_11 : MonoBehaviour
{
    /*
     * Crea un cubo que se desplace en el eje X a una velocidad de 1 unidad por segundo. 
     * Al llegar a la posición 10, debe recolocarse en la posición 0
     */

    private float movementSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        // Moving object in the scene
        transform.position = transform.position + new Vector3(horizontalInput + movementSpeed * Time.deltaTime, 0, 0);
        //transform.Translate(new Vector3(horizontalInput + movementSpeed * Time.deltaTime, 0, 0));

        if (transform.position.x >= 10) transform.position = new Vector3(0, transform.position.y, 0);

    }
}
