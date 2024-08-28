using System;
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

    private readonly int cubeSize = 10;

    // Start is called before the first frame update
    void Start()
    {
        for (int y = 0; y < cubeSize; y++)
        {
            for (int z = 0; z < cubeSize; z++)
            {
                BuildFloor(y, z);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InstantiatePrefab(Vector3 position)
    {
        if (position.y <= 5)
        {
            Instantiate<GameObject>(rockPrefab, position, Quaternion.identity);
            return;
        }

        if (position.y <= 8)
        {
            Instantiate<GameObject>(groundPrefab, position, Quaternion.identity);
            return;
        }

        Instantiate<GameObject>(grassPrefab, position, Quaternion.identity);
    }

    private void BuildFloor(int y, int z)
    {
        for (int x = 0; x < cubeSize; x++)
        {
            Vector3 position = new(x, y, z);
            InstantiatePrefab(position);
        }
    }
}
