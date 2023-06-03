using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//5 2 (3)
public class City_Three : MonoBehaviour {
    public static int CityThree;
    SpriteRenderer Three;
    public GameObject City_Three_Pannel;
    public int City_Three_Chance;
    public GameObject Explosion1;
    public GameObject Explosion2;
    public float City_Three_ExplosionRateRand;
    public static int Agents;
    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;
    // Use this for initialization
    void Start () {
        Three = gameObject.GetComponent<SpriteRenderer>();
        Explosion1.SetActive(false);
        Explosion2.SetActive(false);
    }
    private void OnEnable()
    {
        if (City_Three_Pannel.activeSelf)
        {
            P1.SetActive(false);
            P2.SetActive(false);
            P4.SetActive(false);
            //P4.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update () {

        if (City_Five.CityFive == 0 && City_Two.CityTwo == 0)
        {
            P3.SetActive(false);
        }

        if (mang.stop == 1)
        {
            StopPannelThree();
        }
        City_Three_ExplosionRateRand = Random.Range(0, 100000);
        if (CityThree == 1)
        {
            if (City_Three_ExplosionRateRand <= 100)
            {
                if (Agents <= 5)
                {
                    Explosion1.SetActive(true);
                    Explosion2.SetActive(true);
                    CityThree = 2;
                }
            }
        }
        if (CityThree == 1)
        {
            Three.color = new Color(0f, 255f, 244f, 255f);
            Explosion1.SetActive(false);
            Explosion2.SetActive(false);
        }
        if(CityThree == 2)
        {
            Three.color = new Color(255f, 255f, 255f, 255f);

        }
    }
    public void Purchace_C3()
    {
        if (CityThree == 1)
        {
            //Nothing
        }
        else if (CityThree == 0)
        {
            CityThree = 1;
            Money_Int_Change.Money -= 600;
        }
    }
    public void Agents_C3()
    {
        City_Three_Chance = Random.Range(0, 100);
        if (City_Three_Chance + UpgradeTree.EA <= 25)
        {
            if (CityThree == 1)
            {
                Money_Int_Change.Money += 0;
            }
            else if (City_Two.CityTwo == 1 || City_Five.CityFive == 1)
            {
                //Three.color = new Color(0f, 255f, 244f, 255f);
                CityThree = 1;
                Money_Int_Change.Money += 100;

            }
        }
        else if (CityThree == 0)
        {
            Money_Int_Change.Money -= 400;
        }
    }
    private void OnMouseDown()
    {
        if (City_Three_Pannel != null)
        {
            bool isActive = City_Three_Pannel.activeSelf;
            City_Three_Pannel.SetActive(!isActive);
        }
    }
    void StopPannelThree()
    {
        City_Three_Pannel.SetActive(false);
    }

}
