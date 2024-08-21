using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_23 : MonoBehaviour
{
    /*
     * Instanciar una pared de cubos vertical usando un prefab.
     */

    private GameObject[] wall;

    // Start is called before the first frame update
    void Start()
    {
        for (int column = 1; column <= 5; column++)
        {
            for (int row = 1; row <= 5; row++)
            {
                GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
                go.transform.position = new Vector3(column, 0.5f * row, 0);
            }
            
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
