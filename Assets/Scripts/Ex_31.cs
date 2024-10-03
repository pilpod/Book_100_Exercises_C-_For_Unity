using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_31 : MonoBehaviour
{
    /*
     * Crea una esfera que cambie de color cuando se clica en ella. (Enunciado original)
     * 
     * Añadido: Si dejas apretado el botón irquierdo del ratón entonces la esfera cambia de color a negro 
     * y si sueltas el butón vuelve a su color inicial.
     */

    private Renderer sphereRenderer;
    private bool clicking = false;


    // Start is called before the first frame update
    void Start()
    {
        Vector3 position = Vector3.zero;
        transform.position = position;

        sphereRenderer = GetComponent<Renderer>();
        sphereRenderer.material.SetColor("_Color", Color.gray);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        clicking = true;
        SetColor();
    }

    void OnMouseUp()
    {
        clicking = false;
        SetColor();
    }

    void SetColor()
    {
        Color color = (clicking) ? Color.black : Color.gray;
        sphereRenderer.material.color = color;
    }

}
