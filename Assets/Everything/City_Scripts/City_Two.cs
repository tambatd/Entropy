using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//3 6 5 (2)
public class City_Two : MonoBehaviour {
    public static int CityZero;
    public static int Money;

    public static int CityTwo;
    
    SpriteRenderer Two;
    public int City_Two_Chance;
    public GameObject City_Two_Pannel;
    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;
    // Use this for initialization
    void Start() {
        Two = gameObject.GetComponent<SpriteRenderer>();
    }
    private void OnEnable()
    {
        if (City_Two_Pannel.activeSelf)
        {
            P1.SetActive(false);
            P3.SetActive(false);
            P4.SetActive(false);
            //P5.SetActive(false);
        }
    }
    public void Purchase_C1()
    {
        if (CityTwo == 1)
        {
            //Nothing
        }
        else if (CityTwo == 0)
        {
            CityTwo = 1;
            Money_Int_Change.Money -= 600;
        }
    }

    // Update is called once per frame
    void Update() {

        if (CityTwo == 1)
        {
            Two.color = new Color(0f, 255f, 244f, 255f);
        }
        if (mang.stop == 1)
        {
            StopPannels();
        }

    }
    private void OnMouseDown()
    {
        if (mang.stop == 1)
        {
            StopPannels();        
        }
        //Put this within a if then statement of if(CityTwo=1){excecute pannel opening} etc.
        else if (City_Two_Pannel != null)
        {
            bool isActive = City_Two_Pannel.activeSelf;
            // One.color = new Color(255f, 255f, 255f, 255f);

            City_Two_Pannel.SetActive(!isActive);
        }
    }
    void StopPannels()
    {
        City_Two_Pannel.SetActive(false);
    }




    public void Agents_C2()
    {
        City_Two_Chance = Random.Range(0, 100);

        if (City_Two_Chance <= 50) {
            if (CityTwo == 1)
            {
                Money_Int_Change.Money += 0;
            }

            else if (City_Three.CityThree == 1) {
              //  Two.color = new Color(0f, 255f, 244f, 255f);
                CityTwo = 1;
                Money_Int_Change.Money += 100;



            }
            else if (City_Six.CitySix == 1)
            {
               // Two.color = new Color(0f, 255f, 244f, 255f);
                CityTwo = 1;
                Money_Int_Change.Money += 100;


            }
            else if (City_Five.CityFive == 1)
            {
               // Two.color = new Color(0f, 255f, 244f, 255f);
                CityTwo = 1;
                Money_Int_Change.Money += 100;

            }
            else if (City_Zero.CityZero == 1)
            {
             //   Two.color = new Color(0f, 255f, 244f, 255f);
                CityTwo = 1;
                Money_Int_Change.Money += 400;

            }
        }
    }
}