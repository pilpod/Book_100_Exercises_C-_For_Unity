using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_39 : MonoBehaviour
{
    /*
     * Crea unos cuantos objetos con el tag <<newton>>.
     * Al pulsar espacio, debe activarse la gravedad de todos esos objetos.
     * Los objetos no pueden tener ning�n script a�adido.
     * El ejercicio tiene que funcionar sin modificar el 
     * c�digo aunque se a�adan o quiten objetos de la escena.
     */

    public GameObject[] gameObjects;
    private bool gravityEnabled = true;
    private readonly string objectTag = "newton";

    // Start is called before the first frame update
    void Start()
    {
        gameObjects = GameObject.FindGameObjectsWithTag(objectTag);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var newton in gameObjects)
            {
                Rigidbody rb = newton.GetComponent<Rigidbody>();

                if (rb != null) rb.useGravity = gravityEnabled;
            }
        }
    }
}
