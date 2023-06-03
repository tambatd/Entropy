using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cont : MonoBehaviour {

    public GameObject Button;


    // Use this for initialization
    void Start()
    {
        StartCoroutine(Example());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator Example()
    {
        print(Time.time);
        yield return new WaitForSeconds(5);
        print(Time.time);
        Button.gameObject.SetActive(true);

    }
}