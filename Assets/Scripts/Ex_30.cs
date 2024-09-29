using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_30 : MonoBehaviour
{
    /*
     * Instancia diez cubos en la escena en posiciones aleatorias entre -10 y 10
     * en cada eje. Al pulsar el espacio, deben destruirse los que tengan posiciones
     * positivas en el eje x.
     */

    private readonly int _cubeQuantity = 10;
    private readonly int _minRange = -10;
    private readonly int _maxRange = 10;
    public List<GameObject> cubes;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < _cubeQuantity; i++)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(
                                            Random.Range(_minRange, _maxRange),
                                            Random.Range(_minRange, _maxRange),
                                            Random.Range(_minRange, _maxRange));
            cubes.Add(cube);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
