using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_21 : MonoBehaviour
{
    /*
     * Crea un bucle que sume los primeros quinientos números pares.
     */

    private int count = 0;
    private int sum = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 1000; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
                count++;
            };
        }

        Debug.Log(sum);
        Debug.Log(count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
