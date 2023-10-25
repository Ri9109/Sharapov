using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position =new Vector3(20, 4, 15);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(21, 4, 16);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(21 , 4, 14);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(20, 5, 15);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(20, 3, 15);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(20, 2, 15);
    }
  

    // Update is called once per frame
    void Update()
    {
        
    }
}
