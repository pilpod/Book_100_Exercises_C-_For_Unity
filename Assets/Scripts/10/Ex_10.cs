using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Ex_10 : MonoBehaviour
{
    /*]
     * Crea un script que inicialice una probabilidad aleatoria entre 0 y 100
     * y que cada 10 segundos genere un número entre 0 y 100. Si el número es mayor que la
     * probalidad, imprime por consola <<Acierto>> y si no, imprime <<Fallo>>.
     */

    public int probability;

    // Start is called before the first frame update
    void Start()
    {
        InitProbability();
        InvokeRepeating("GenerateNumber",0f,10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitProbability()
    {
        var rand = new Random();
        probability = rand.Next(0,100);
    }

    void GenerateNumber()
    {
        var rand = new Random();
        int numb = rand.Next(0,100);

        if (numb > probability) Debug.Log("<<Acierto>>");
        if (numb < probability) Debug.Log("<<Fallo>>");
    }


}
