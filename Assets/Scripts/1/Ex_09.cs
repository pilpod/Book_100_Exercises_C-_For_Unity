using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_09 : MonoBehaviour
{
    /*
     * Crea un script que imprima por consola el tiempo
     * que ha pasado desde el inicio de la ejecución cada 100 fotogramas
     */

    private int _countFrame = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _countFrame++;

        if ( _countFrame % 100 == 0 )
        {
            float time = Time.time;
            Debug.Log($"Tiempo trancurrido cada 100 fotogramas: {time}");
        }
    }
}
