using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_24 : MonoBehaviour
{
    /*
     * Instanciar un cubo hecho de cubos usando prefab.
     */

    public GameObject prefab;
    private int cubeSize = 10;


    // Start is called before the first frame update
    void Start()
    {
        for (int y = 0; y < cubeSize; y++)
        {
            for (int z = 0; z < cubeSize; z++)
            {
                for (int x = 0; x < cubeSize; x++)
                {
                    Vector3 position = new Vector3(x, y, z);
                    Instantiate(prefab, position, Quaternion.identity);
                }
            }
        }



    }

    // Update is called once per frame
    void Update()
    {

    }
}
