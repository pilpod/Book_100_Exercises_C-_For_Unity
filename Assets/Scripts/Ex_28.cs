using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_28 : MonoBehaviour
{
    /*
     * Crea un cubo que se desplace uniformemente entre los puntos
     * de un array o lista pública de Vector3, pero que elija
     * aleatoriamente el siguiente punto de la colección
     * al que desplazarse.
     */

    private GameObject prefab;
    public List<Vector3> points = new List<Vector3>();
    public float velocity = 2.0f;
    private int currentIndex;

    // Start is called before the first frame update
    void Start()
    {
        prefab = GameObject.CreatePrimitive(PrimitiveType.Cube);

        for (int i = 0; i < 10; i++)
        {
            float x = Random.Range(0, 20);
            float y = Random.Range(0, 20);
            float z = Random.Range(0, 20);

            Vector3 vector3 = new Vector3(x, y, z);
            points.Add(vector3);
        }

        int index = Random.Range(0, points.Count);
        currentIndex = index;

        prefab.transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (points.Count == 0) return;

        float distance = Vector3.Distance(prefab.transform.position, points[currentIndex]);
        Vector3 direction = (points[currentIndex] - prefab.transform.position).normalized;

        prefab.transform.Translate(direction * velocity * Time.deltaTime, Space.World);

        if (distance < 0.1f) currentIndex = Random.Range(0, points.Count);
        
    }
}
