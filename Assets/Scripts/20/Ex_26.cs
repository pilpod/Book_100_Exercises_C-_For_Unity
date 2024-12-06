using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_26 : MonoBehaviour
{
    /*
     * Instancia una pirámide hecha de cubos.
     */

    public GameObject rockPrefab;
    private int pyramidHeight = 10;

    // Start is called before the first frame update
    void Start()
    {
        for (int y = 0; y < pyramidHeight; y++)
        {
            float levelSize = pyramidHeight - (y * 0.5f);
            float position = y * 0.5f;

            for (float z = position; z < levelSize; z++)
            {
                for (float x = position; x < levelSize; x++)
                {
                    Vector3 vector = new Vector3(x, y, z);
                    Instantiate(rockPrefab, vector, Quaternion.identity);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
