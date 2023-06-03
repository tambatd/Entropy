using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;


public class Entropy_Activation : Selectable  {
    public static int Money;

    public void Entropy(string okane)
    {
        Debug.Log("CLICKED");

        if (UpgradeTree.EA == 1)
        {
            Money_Int_Change.Money += 0;
            Debug.Log("0 increase");
        }
        else if(UpgradeTree.EA == 0)
        {
            Money_Int_Change.Money -= 1000;
            UpgradeTree.EA = 1;
            Debug.Log("400 decrease");
        }
    }
    void Update()
    {
     
    }
}

