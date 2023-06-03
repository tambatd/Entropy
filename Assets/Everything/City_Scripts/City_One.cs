using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//4 9 (1)
public class City_One : MonoBehaviour
{
    //Changing time to execute city capture, modify this state by upgrades to company through money
    //========================  
    public static int CityOne;
    SpriteRenderer One;
    public int City_One_Chance;
    public static int EA;
    public GameObject City_One_Pannel;
    //public float max = 1f;
    // public float speed = 5.0f;
    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;


    // Use this for initialization
    void Start()
    {
        One = gameObject.GetComponent<SpriteRenderer>();
        CityOne = 0;
    }
    private void OnEnable()
    {
        if (City_One_Pannel.activeSelf)
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
      
        if (CityOne == 1)
        {
            One.color = new Color(0f, 255f, 244f, 255f);
        }
        if (mang.stop == 1)
        {
            StopPannelOne();
        }

    }
    void StopPannelOne()
    {
        City_One_Pannel.SetActive(false);

    }

    private void OnMouseDown()
    {
         if (City_One_Pannel != null)
        {
            bool isActive = City_One_Pannel.activeSelf;

            City_One_Pannel.SetActive(!isActive);
        }
        
    
    }

    public void Purchase_C1()
    {
        if (CityOne == 1)
        {
            //Nothing
        }
        else if (CityOne == 0)
        {
            CityOne = 1;
            Money_Int_Change.Money -= 600;
        }
    }
    public void Agents_C1()
    {
        City_One_Chance = Random.Range(0, 100);
        if (City_One_Chance <= 25)
        {
            if (CityOne == 1)
            {
                //Do Nothing
            }
            else if (City_Four.CityFour == 1 || City_Nine.CityNine == 1 || City_Four.CityFour == 0 || City_Nine.CityNine == 0)
            {
                Money_Int_Change.Money += 500;
                CityOne = 1;
            }
            else if (CityOne == 0)
            {
                Money_Int_Change.Money -= 200;
            }

        }
    }
}
