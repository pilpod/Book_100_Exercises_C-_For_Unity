using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_19 : MonoBehaviour
{
    /*
     * Crea un cubo que se desactive entre
     * tres y cinco segundos después de clicar en él
     */

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("Click sobre el objecto");
        Invoke("DisableObject", RandomTime());
    }

    private void DisableObject()
    {
        gameObject.SetActive(false);
    }

    private float RandomTime()
    {
        return Random.Range(3f, 5f);
    }
}
