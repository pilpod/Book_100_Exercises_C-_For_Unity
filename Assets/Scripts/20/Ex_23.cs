using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_23 : MonoBehaviour
{
    /*
     * Instanciar una pared de cubos vertical usando un prefab.
     */
    public GameObject prefab;
    private readonly int maxRows = 5;
    private readonly int maxColumn = 5;

    // Start is called before the first frame update
    void Start()
    {
        for (int row = 0; row < maxRows; row++)
        {
            for (int column = 0; column < maxColumn; column++)
            {
                Instantiate(prefab, new Vector3(row, 0.5f + column, 0), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
