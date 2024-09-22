using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Ex_29 : MonoBehaviour
{
    /*
     * Crea unos cuantos objetos con el tag <<desaparecer>> en la escena,
     * manualmente. Al pulsar la tecla espaciadora, todos los objetos deben desativarse.
     * Los objetos no pueden tener ningún script añadido. El ejercicio ha
     * de funcionar sin modificar el código aunque se añadan o quiten objetos de la escena.
     * 
     * Extra: Si los objectos fueron desactivados volver a activarlos también con la barra espaciadora.
     */

    public GameObject[] spheres;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (spheres.Length == 0) spheres = GameObject.FindGameObjectsWithTag("desaparecer");

            foreach (var sphere in spheres)
            {
                ChangeStateObject(sphere);
            }
        }
    }

    private void ChangeStateObject(GameObject sphere)
    {
        if (sphere.activeSelf)
        {
            sphere.SetActive(false);
        }
        else
        {
            sphere.SetActive(true);
        }
    }
}
