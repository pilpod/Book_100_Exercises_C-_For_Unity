using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_33 : MonoBehaviour
{
    /*
     * Genera un efecto de movimiento modificando el offset
     * de la textura de un material de un plane o quad.
     */

    public float velocity = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextureMovement();
    }

    public void TextureMovement()
    {
        float offset = Time.time * velocity;
        GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
        
    }
}
