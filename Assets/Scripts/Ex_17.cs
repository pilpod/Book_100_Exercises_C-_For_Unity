using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_17 : MonoBehaviour
{
    /*
     * Crea un cubo que se destruye al clicar en él.
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
        Destroy(gameObject);
    }
}
