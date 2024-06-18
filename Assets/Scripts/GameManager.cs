using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject cube;
    public GameObject cube1;
    void Start()
    {
        cube.transform.position = new Vector3(0,0,0);  
        //cube1.transform.position = newpos;
       
    }

    private Vector3 Vector3(float x, float y, float z)
    {
        throw new NotImplementedException();
    }


    // Update is called once per frame
    void Update()
    {;
        //float distance=Vector3.Distance(target,transform.position);
        //if (distance > 1.0f)
        //{
        //    Vector3 dir=target-transform.position;
        //    dir.Normalize();
        //    transform.position+=dir*speed*Time.deltaTime;
        //}
    }
}
