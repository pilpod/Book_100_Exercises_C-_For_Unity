using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_25 : MonoBehaviour
{
    /*
     * Instanciar un bloque de cubos como en el ejercicio 24, 
     * pero utilizar diferentes prefabs para generar capas de piedra, tierra y césped,
     * como si fuese una sección de suelo del juego Minecraft.
     */

    public GameObject rockPrefab;
    public GameObject groundPrefab;
    public GameObject grassPrefab;

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
                    Vector3 position = new Vector3(x,y,z);
                    
                    if (y <= 5)
                    {
                        Instantiate<GameObject>(rockPrefab, position, Quaternion.identity);
                        continue;
                    }

                    if (y <= 8 )
                    {
                        Instantiate<GameObject>(groundPrefab, position, Quaternion.identity);
                        continue;
                    }

                    Instantiate<GameObject>(grassPrefab, position, Quaternion.identity);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
