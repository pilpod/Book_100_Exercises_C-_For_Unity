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
        for (int i = 2; i <= 1000; i += 2)
        {
            sum += i;
            count++;
        }

        Debug.Log(sum);
        Debug.Log(count);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
