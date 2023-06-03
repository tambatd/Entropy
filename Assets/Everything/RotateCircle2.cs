using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCircle2 : MonoBehaviour
{
    public float speed = 1.5f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
            transform.Rotate(Vector3.forward * -90 * Time.deltaTime);
            //Upgrade Calc//
       
    }
}
