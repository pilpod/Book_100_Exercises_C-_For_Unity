using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_30 : MonoBehaviour
{
    /*
     * Instancia diez cubos en la escena en posiciones aleatorias entre -10 y 10
     * en cada eje. Al pulsar el espacio, deben destruirse los que tengan posiciones
     * positivas en el eje x.
     * 
     * Se puede hacer el ejercicio creando GameObject publico y asignadole un tag. Seguidamente
     * solo tendremos que crear 10 instancies del cubo publico con diferente posiciones tal como lo indica el
     * paragrafo anterior. Utilizaremos FindGameObjectsWithTag para recuperar los cubos y destruirlos si se cumple la condición.
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var cube in cubes)
            {
                if (cube.transform.position.x > 0)
                {
                    GameObject.Destroy(cube);
                }
            }
        }
    }
}
