using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_07 : MonoBehaviour
{
    /*
     * Crea un script que demuestre el orden de ejecución de los métodos Start y Awake de MonoBehaviour.
     */

    // Awake is called before Start method
    void Awake()
    {
        Debug.Log("Awake: Este mensaje se imprime antes de Start");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start: Este mensaje se imprime al iniciar el juego");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
