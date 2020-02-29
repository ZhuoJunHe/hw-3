using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//not working, still working on it...........

public class onCollisionEnter : MonoBehaviour
{
    public Material matofobject;
    public Color newcol;
    public Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
       // rend.enable = true;
    }
   
        void OnCollisionEnter()
        {
         matofobject.color = newcol;
       // rend.sharedMaterial = newcol;
        }
    
}
