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
        float increaseScale = scaleIncrement * Time.deltaTime;
        float setPosition = fixPosition * Time.deltaTime;

        Vector3 vectorScale = new Vector3(increaseScale, increaseScale, increaseScale);

        if (Input.GetKey(KeyCode.Space))
        {
            transform.localScale += vectorScale;
            transform.position += new Vector3(0f, setPosition, 0f);
        }

        if (!Input.GetKey(KeyCode.Space) && transform.localScale.y > initialScale)
        {
            transform.localScale -= vectorScale;
            transform.position -= new Vector3(0f, setPosition, 0f);
        }

    }
}
