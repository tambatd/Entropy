using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_1 : MonoBehaviour
{
    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        if (P1.activeSelf)
        {
            P2.SetActive(false);
            P3.SetActive(false);
            P4.SetActive(false);
            //P5.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
