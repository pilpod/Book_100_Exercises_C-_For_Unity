using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Ex_13 : MonoBehaviour
{
    /*
     * Haz que un cubo aumente la escala si mantenemos pulsada la tecla
     * espaciadora y la disminuya si no la pulsamos. 
     * La escala mínima debe ser 2 en cada eje.
     */

    float initialScale;
    float scaleIncrement = 0.4f;
    float fixPosition = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        initialScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        float setPosition = fixPosition * Time.deltaTime;

        // Using Vector3.one = new Vector3(1,1,1)
        Vector3 vectorScale = Vector3.one * scaleIncrement * Time.deltaTime;

        if (Input.GetKey(KeyCode.Space))
        {
            transform.localScale += vectorScale;
            transform.position += new Vector3(0f, setPosition, 0f);
        }

        if (!Input.GetKey(KeyCode.Space) && transform.localScale.y > initialScale)
        {
            // using Vector.Max(Vector3,Vector3)
            transform.localScale = Vector3.Max(transform.localScale - Vector3.one * scaleIncrement * Time.deltaTime, Vector3.one * initialScale);
            transform.position -= new Vector3(0f, setPosition, 0f);
        }

    }
}
