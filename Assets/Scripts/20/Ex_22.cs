using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_22 : MonoBehaviour
{
    /*
     * Crea una línea de diez cubos en el eje X usando un bucle, sin usar prefabs.
     */

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            GameObject object1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            object1.transform.position = new Vector3(i * 2, 0.5f, 2);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
