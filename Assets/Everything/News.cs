using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class News : MonoBehaviour {
    public static int News_Update;
    
    public AudioSource MusicSource;
    static public bool NewsUpdateSoundfx = true;
    Text text;

    // Use this for initialization
    void Start () {
        MusicSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
		if (City_One.CityOne == 1)
        {
            text.text = "UNDER NEW LEADERSHIP THE ENTROPY CORPORATION'S STOCK DOUBLES OVERNIGHT";
            MusicPlayer();
            NewsUpdateSoundfx = false;
        }
        if(City_One.CityOne == 1 && City_Two.CityTwo == 1)
        {
            text.text = "ENTROPY TECHNOLOGIES EXPANSION CAUSES STOCK TO TRIPPLE. THE ARYA MEI TECH GROUP HAS DECIDED TO RESTRUCTURE";
        }
        if(City_One.CityOne == 1 && City_Two.CityTwo == 1 && City_Three.CityThree == 1)
            {
            text.text = "ANALYSTS BEGIN SHORTING BILLIONS OF ARYA MEI STOCK";
            }
        if (City_One.CityOne == 1 && City_Two.CityTwo == 1 && City_Three.CityThree == 1 && City_Four.CityFour == 1)
        {
            text.text = "ARYA MEI TECH GROUP DECLARES IT WILL SELL OFF IT'S WESTERN SUBSIDARY TO ENTROPY TECHNOLOGIES, EFFECTIVELY RETREATING FROM THE WEST";
            MusicPlayer();
            NewsUpdateSoundfx = false;
        }
    }
    private void Awake()
    {
        text = GetComponent<Text>();
    }
    void MusicPlayer()
    {
        if (NewsUpdateSoundfx!= false)
        {
            MusicSource.Play(1);
            NewsUpdateSoundfx = true;
        }
    }
}
