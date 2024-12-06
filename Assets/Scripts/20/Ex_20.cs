using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_20 : MonoBehaviour
{
    /*
     * Crea un cubo que cambie de nombre para indicar cuántas veces has clicado en otro objeto de la escena.
     */
    public GameObject sphereToRename;
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // if GameObject is clicked
    private void OnMouseDown()
    {
        this.gameObject.name = "Main_Cube";
        RenameSphere();

    }

    public void RenameSphere()
    {
        if (sphereToRename != null)
        {
            sphereToRename.name = "Sphere: " + ++count;
        }
    }
}
