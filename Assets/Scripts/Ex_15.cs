using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_15 : MonoBehaviour
{
    /*
     * Crea un simple controlador de personaje
     * que desplace un cubo en los ejes X y Y
     * al pulsar los cursores
     * 
     * Doc: https://docs.unity3d.com/ScriptReference/CharacterController.Move.html
     * La solución del libro no hace uso de CharacterController
     */

    private CharacterController controller;
    float speed = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        float axisH = Input.GetAxis("Horizontal");
        float axisV = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(axisH, 0, axisV);

        // My solution
        controller.Move(move * speed * Time.deltaTime);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        // Book solution - it does not take the rotation of the object into account.
        //move.Normalize();
        //transform.Translate(move * speed * Time.deltaTime);

    }
}
