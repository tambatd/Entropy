using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//1 9 18 (4)
public class City_Four : MonoBehaviour {
    public static int CityFour;
    SpriteRenderer Four;
    public GameObject City_Four_Pannel;
    public int City_Four_Chance;
    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;
    // Use this for initialization
    void Start () {

        Four = gameObject.GetComponent<SpriteRenderer>();

	}

    private void OnEnable()
    {
        P1.SetActive(false);
        P2.SetActive(false);
        P3.SetActive(false);
      //P4.SetActive(false);
    }
    // Update is called once per frame
    void Update () {
        if (City_Nine.CityNine == 0 && City_One.CityOne == 0 && City_Eighteen.CityEighteen == 0)
        {
            P4.SetActive(false);
        }
        if (CityFour == 1)
        {
            Four.color = new Color(0f, 255f, 244f, 255f);
        }
        if (mang.stop == 1)
        {
            StopPannelFour();
        }

    }
    private void OnMouseDown()
    {
        if (mang.stop == 1)
        {
            StopPannelFour();     
        }
        //Put this within a if then statement of if(CityTwo=1){excecute pannel opening} etc.
        else if (City_Four_Pannel != null)
        {
            bool isActive = City_Four_Pannel.activeSelf;
            // One.color = new Color(255f, 255f, 255f, 255f);

            City_Four_Pannel.SetActive(!isActive);
        }
    }
    public void Purchace_C4()
    {
        if(CityFour == 1)
        {
            //Do nothing
        }
        else if (CityFour == 0)
        {
            CityFour = 1;
            Money_Int_Change.Money -= 1200;
        }
    }
    void StopPannelFour()
    {
        City_Four_Pannel.SetActive(false);

    }




    public void Agent_C4()
    {
        City_Four_Chance = Random.Range(0, 100);
        if (City_Four_Chance <= 25)
        {
            if (CityFour == 1)
            {
                Money_Int_Change.Money += 0;
            }
            else if (City_One.CityOne == 1 || City_Nine.CityNine == 1 || City_Eighteen.CityEighteen == 1)
            {
                CityFour = 1;
                Money_Int_Change.Money += 100;
            }
        }
        else if(CityFour == 0)
        {
            Money_Int_Change.Money -= 200;
        }
    }
}
