using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//15 14 10 (13)
public class City_Thirteen : MonoBehaviour {
    public static int CityOne;
    public static int CityTwo;
    public static int CityThree;
    public static int CityFour;
    public static int CityFive;
    public static int CitySix;
    public static int CitySeven;
    public static int CityEight;
    public static int CityNine;
    public static int CityTen;
    public static int CityEleven;
    public static int CityTwelve;
    public static int CityThirteen;
    public static int CityFourteen;
    public static int CityFifteen;
    public static int CitySixteen;
    public static int CitySeventeen;
    public static int CityEighteen;
    public static int CityNineteen;
    public static int CityTwenty;
    public static int CityTwentyone;
    public static int CityTwentytwo;
    public static int CityTwentythree;
    public static int CityTwentyfour;
    public static int Money;

    SpriteRenderer Thirteen;
    // Use this for initialization
    void Start () {
        Thirteen = gameObject.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update () {
		
	}
    private void OnMouseDown()
    {
        if (CityThirteen == 1)
        {
            Money_Int_Change.Money += 0;
        }
        else if (City_Fifteen.CityFifteen == 1)
        {
            Thirteen.color = new Color(0f, 255f, 244f, 255f);
            CityThirteen = 1;
            Money_Int_Change.Money += 100;

        }
        else if (City_Fourteen.CityFourteen == 1)
        {
            Thirteen.color = new Color(0f, 255f, 244f, 255f);
            CityThirteen = 1;
            Money_Int_Change.Money += 100;

        }
        else if (City_Ten.CityTen == 1)
        {
            Thirteen.color = new Color(0f, 255f, 244f, 255f);
            CityThirteen = 1;
            Money_Int_Change.Money += 100;

        }

        //15 14 10 (13)

    }
}
