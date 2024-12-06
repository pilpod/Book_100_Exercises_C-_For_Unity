using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_12 : MonoBehaviour
{
    /*
     * Haz que un cubo rote a la izquierda o a la derecha respondiendo
     * a las pulsaciones del teclado correspondientes a los cursores <- , ->
     * o a las letras A y D
     */

    float movementSpeed = 45.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            float rotation = inputHorizontal + movementSpeed * Time.deltaTime;
            transform.Rotate(Vector3.up, rotation);
        }
    }
}
