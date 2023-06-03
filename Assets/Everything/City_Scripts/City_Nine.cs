using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//6 1 4 16 17 (9)
public class City_Nine : MonoBehaviour {

    public static int CityNine;
   

    SpriteRenderer Nine;
    // Use this for initialization
    void Start () {
        Nine = gameObject.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update () {
		
	}
    private void OnMouseDown()
    {
        if (CityNine == 1)
        {
            Money_Int_Change.Money += 0;
        }
        else if (City_Six.CitySix == 1 || City_One.CityOne == 1 || City_Four.CityFour == 1 || City_Sixteen.CitySixteen == 1 || City_Seventeen.CitySeventeen == 1)
        {
            Nine.color = new Color(0f, 255f, 244f, 255f);
            CityNine = 1;
            Money_Int_Change.Money += 100;

        }
        else if (CityNine == 0)
        {
            Money_Int_Change.Money -= 200;
        }
        //6 1 4 16 17 (9)

    }
}
