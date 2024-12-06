using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_02 : MonoBehaviour
{
    /*Utiliza dos variables públicas de tipo float para 
     * mostrar por consola sus valores 
     * sumados, restados, multiplicados y divididos.*/

    public float x = 2.0f;
    public float y = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Addition: " + Addition());
        Debug.Log("Subtraction: " + Subtraction());
        Debug.Log("Multiplication: " + Multiplication());

        Debug.Log((y != 0) ? "Division: " + Division() : "Error: You cannot divide by zero");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private float Addition() =>  x + y;

    private float Subtraction() => x - y;

    private float Multiplication() => x * y;

    private float Division() => x / y;
    
}
