using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_14 : MonoBehaviour
{
    /*
     * Crea un cubo que se desplace uniformemente entre x=0 y x=10
     * Debe ir y volver
     */

    float speed = 3.0f;

    // book variables
    //private float minX = 0f;
    //private float maxX = 10f;
    //private int direcion = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // My solution using Mathf.PingPong()
        transform.position = new Vector3(Mathf.PingPong(Time.time * speed, 10), transform.position.y, 0);

        // Book solution
        //transform.Translate(Vector3.right * speed * direcion * Time.deltaTime);
        //if (transform.position.x >= maxX || transform.position.x <= minX) direcion *= -1;

    }
}
