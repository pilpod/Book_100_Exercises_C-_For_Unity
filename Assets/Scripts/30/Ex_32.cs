using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_32 : MonoBehaviour
{
    /*
     * Crear dos esferas. 
     * Al clicar sobre una, la otra cambia de color.
     */

    public GameObject sphere2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        ChangeColorOtherSphere();
    }

    public void ChangeColorOtherSphere()
    {
        if (sphere2 != null)
        {
            sphere2.GetComponent<Renderer>().material.color = Color.black;
        }
    }


}
