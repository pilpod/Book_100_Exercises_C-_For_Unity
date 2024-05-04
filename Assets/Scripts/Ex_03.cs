using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_03 : MonoBehaviour
{
    /*
     * Crea dos variables privadas de tipo string, 
     * concaténalas y muestra el resultado por consola.
     */

    private string _part1 = "Hello";
    private string _part2 = "Unity!";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(_part1 + " " + _part2);
        Debug.Log($"{_part1} {_part2} with interpolation");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
