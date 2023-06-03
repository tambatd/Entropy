using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panels : MonoBehaviour
{
    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (P1.activeSelf)
        {
            P2.SetActive(false);
            P3.SetActive(false);
            P4.SetActive(false);
          //P5.SetActive(false);
        }
        else if (P2.activeSelf)
        {
            P1.SetActive(false);
            P3.SetActive(false);
            P4.SetActive(false);
        }
        else if (P3.activeSelf)
        {
            P1.SetActive(false);
            P2.SetActive(false);
            P4.SetActive(false);
        }
        else if (P4.activeSelf)
        {
            P1.SetActive(false);
            P2.SetActive(false);
            P3.SetActive(false);
        }
    }
}
