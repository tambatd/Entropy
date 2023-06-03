using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TechPanel : MonoBehaviour {
    public GameObject Panel1;

    public void OpenPanel1()
    {
        if (Panel1 != null)
        {
            bool isActive = Panel1.activeSelf;
            Debug.Log("Actuve???");
            Panel1.SetActive(!isActive);
        }
    }
}
