using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_27 : MonoBehaviour
{
    /*
     * Crea un cubo que se desplace uniformemente entre
     * los puntos de un array o lista pública de vectores 3.
     */

    private GameObject prefab;

    public Vector3[] vectors;
    public float velocity = 2.0f;
    private int currentVector = 0;

    // Start is called before the first frame update
    void Start()
    {
        prefab = GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    // Update is called once per frame
    void Update()
    {
        if (vectors.Length == 0) return;

        Vector3 direction = (vectors[currentVector] - prefab.transform.position).normalized;
        
        float distance = Vector3.Distance(prefab.transform.position, vectors[currentVector]);

        MovePrefab(direction);
        
        if (distance < 0.1f)
        {
            currentVector = (currentVector + 1) % vectors.Length;
        }
    }

    private void MovePrefab(Vector3 direction)
    {
        prefab.transform.Translate(direction * velocity * Time.deltaTime, Space.World);
    }
}
