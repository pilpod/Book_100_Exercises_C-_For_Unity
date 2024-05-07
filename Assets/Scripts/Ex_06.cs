using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_06 : MonoBehaviour
{
    /*
     * Calcula el factorial de un n�mero dado por una variable p�blica de tipo int.
     */

    public int numb;

    // Start is called before the first frame update
    void Start()
    {
        if (numb < 0)
        {
            Debug.Log("No se puede calcular el factorial de un n�mero negativo");
            return;
        }

        CalculateFactorial();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CalculateFactorial()
    {
        int factorial = numb;
        int count = 1;

        while (count < numb)
        {
            factorial *= count;
            count++;
        }

        Debug.Log($"{factorial} is factorial of {numb}");
    }
}
