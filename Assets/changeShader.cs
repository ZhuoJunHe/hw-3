using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeShader : MonoBehaviour
{
    public SpriteRenderer ch;
    Shader shader1;
    Shader shader2;
    Shader shader3;
    Shader shader4;
    Shader original;

    void Start()
    {
      
        shader1 = Shader.Find("Diffuse");
        shader2 = Shader.Find("Transparent/Diffuse");
        shader3 = Shader.Find("Self-Illumin/Diffuse");
        shader4 = Shader.Find("Default");
        original = ch.material.shader;
    }

    void Update()
    {
        if (Input.GetKeyDown("1"))
            ch.material.shader = shader1;

        if (Input.GetKeyDown("2"))
            ch.material.shader = shader2;

        if (Input.GetKeyDown("3"))
            ch.material.shader = shader3;

        if (Input.GetKeyDown("4"))
            ch.material.shader = shader4;

        if (Input.GetKeyDown("5"))
            ch.material.shader = original;
    }
}
