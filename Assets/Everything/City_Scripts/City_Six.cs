using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City_Six : MonoBehaviour {
    public static int CitySix;
  

    //2 5 9 (6)

    SpriteRenderer Six;
	// Use this for initialization
	void Start () {
        Six = gameObject.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    private void OnMouseDown() {

        if (CitySix == 1)
        {
            Money_Int_Change.Money += 0;
        }
        else if (City_Two.CityTwo == 1 || City_Five.CityFive == 1 || City_Nine.CityNine == 1)
        {
            Six.color = new Color(0f, 255f, 244f, 255f);
            CitySix = 1;
            Money_Int_Change.Money += 100;

        }
        else if (CitySix == 0)
        {
            Money_Int_Change.Money -= 200;
        }
    }
}
