using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//4 16 19 (18)
public class City_Eighteen : MonoBehaviour {
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
    public static int Money;

    public static int CityTwentyfour;
    SpriteRenderer Eighteen;
    // Use this for initialization
    void Start () {
		Eighteen = gameObject.GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
        if (CityEighteen == 1)
        {
            Money_Int_Change.Money += 0;
        }

       else if (City_Four.CityFour == 1)
        {
            Eighteen.color = new Color(0f, 255f, 244f, 255f);
            CityEighteen = 1;
            Money_Int_Change.Money += 100;

        }
        else if (City_Sixteen.CitySixteen == 1)
        {
            Eighteen.color = new Color(0f, 255f, 244f, 255f);
            CityEighteen = 1;
            Money_Int_Change.Money += 100;

        }
        else if (City_Nineteen.CityNineteen == 1)
        {
            Eighteen.color = new Color(0f, 255f, 244f, 255f);
            CityEighteen = 1;
            Money_Int_Change.Money += 100;

        }
    }
}
//4 16 19 (18)
