using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_04 : MonoBehaviour
{
    /*
     * Crea una variable privada booleana y dos variables públicas int.
     * Si al ejecutar el juego la suma de las variables int es par,
     * la booleana debe ser true. Mostrar valor por consola.
     */

    private bool _isEven = false;
    public int numb1 = 4;
    public int numb2 = 3;

    // Start is called before the first frame update
    void Start()
    {
        int result = numb1 + numb2;

        if (result % 2 == 0) _isEven = true;

        Print();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Print()
    {
        Debug.Log($"Is Even: {_isEven}");
    }
}
