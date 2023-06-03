using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next_scene : MonoBehaviour {
    public GameObject Button;


    // Use this for initialization
    void Start () {
        StartCoroutine(Example());
        Button.gameObject.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Tran()
    {
        SceneManager.LoadScene(1);
    }
    IEnumerator Example()
    {
        print(Time.time);
        yield return new WaitForSeconds(5);
        print(Time.time);
    }
}
