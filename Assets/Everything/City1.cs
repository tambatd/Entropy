using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City1 : MonoBehaviour
{
    public Sprite cityone;
    //City that's int can be variated between 1-4
    public static int Cone;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = cityone;
        Cone = 1;
    }
}
