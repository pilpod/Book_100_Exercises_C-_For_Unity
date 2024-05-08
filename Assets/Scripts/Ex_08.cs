using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_08 : MonoBehaviour
{
    /*
     * Crear un script que imprima por consola, en cada fotograma, el tiempo que ha transcurrido desde el fotograma anterior.
     */

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime : El tiempo en segundos que tardó en completarse el último frame (Read Only).
        // Update + Time.deltaTime fundamental para realizar calculo y movimientos suaves y consistentes
        // doc: https://docs.unity3d.com/es/530/ScriptReference/Time.html
        float deltaTime = Time.deltaTime;
        Debug.Log($"Tiempo transcurrido desde el fotograma anterior: {deltaTime}");
    }
}
