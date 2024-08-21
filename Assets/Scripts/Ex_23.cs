using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_23 : MonoBehaviour
{
    /*
     * Instanciar una pared de cubos vertical usando un prefab.
     */

    public List<GameObject> prefabs;
    private readonly int maxCubePerColumn = 5;

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < maxCubePerColumn; i++)
        {
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
            go.transform.position = new Vector3(0, 0.5f + i, 0);
            prefabs.Add(go);
        }

        for (int i = 0; i < maxCubePerColumn - 1; i++)
        {
            foreach (var cube in prefabs)
            {
                Instantiate(cube, new Vector3(cube.transform.position.x + (i+1), cube.transform.position.y, cube.transform.position.z), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
