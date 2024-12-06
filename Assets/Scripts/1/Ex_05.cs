using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_05 : MonoBehaviour
{
    /*
     * Crea un script que imprima por consola <<Hoy es jueves> si es jueves, u <<Hoy no es jueves>> en caso contrario.
     */

    // Start is called before the first frame update
    void Start()
    {
        DateTime dateTime = DateTime.Now;

        string phrase = (dateTime.DayOfWeek == DayOfWeek.Thursday) ? "Hoy es jueves" : "Hoy no es jueves";

        Debug.Log(phrase);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
