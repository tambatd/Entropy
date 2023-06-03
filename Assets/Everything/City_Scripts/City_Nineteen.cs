using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//18 16 20 (19)
public class City_Nineteen : MonoBehaviour {
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
    SpriteRenderer Nineteen;
    public static int Money;

    // Use this for initialization
    void Start () {
        Nineteen = gameObject.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update () {
		
	}
    private void OnMouseDown()
    {
        if (CityNineteen == 1)
        {
            Money_Int_Change.Money += 0;
        }
        else if (City_Sixteen.CitySixteen == 1)
        {
            Nineteen.color = new Color(0f, 255f, 244f, 255f);
            CityNineteen = 1;
            Money_Int_Change.Money += 100;

        }
        else if (City_Twenty.CityTwenty == 1)
        {
            Nineteen.color = new Color(0f, 255f, 244f, 255f);
            CityNineteen = 1;
            Money_Int_Change.Money += 100;

        }
        else if (City_Eighteen.CityEighteen == 1)
        {
            Nineteen.color = new Color(0f, 255f, 244f, 255f);
            CityNineteen = 1;
            Money_Int_Change.Money += 100;

        }
    }
}
//18 16 20 (19)
