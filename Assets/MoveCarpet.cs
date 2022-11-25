using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCarpet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float speed = 2f;
    float height = 5.0f;

void Update()
{
    // UnityEditor.TransformWorldPlacementJSON:{"position":{"x":-25.51329231262207,"y":3.576918363571167,"z":0.9800000190734863},"rotation":{"x":0.0,"y":0.7071068286895752,"z":0.0,"w":0.7071068286895752},"scale":{"x":4.185451030731201,"y":0.03213699907064438,"z":2.4299182891845705}}
    Vector3 pos = transform.position;

    float newY = Mathf.Sin(Time.time * speed) * 2;

    newY = newY*height;

    transform.position = new Vector3(pos.x, pos.y, newY);
}

}
