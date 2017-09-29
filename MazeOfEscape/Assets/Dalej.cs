using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Dalej : MonoBehaviour {


    public GameObject animacjaRotate;
    public GameObject animacjaWychylenie;
    public GameObject animacjaTouch;
    public GameObject animacjaTap;
    public Text tekst;
    private int i;
	// Use this for initialization
	void Start () {
        i = 0;
        animacjaTap.SetActive(true);
        animacjaRotate.SetActive(false);
        animacjaWychylenie.SetActive(false);
        animacjaTouch.SetActive(false);
        tekst.text = "Tap to Skip";
    }
	
    public void Skip()
    {

        if (Input.GetMouseButtonDown(0)) {

            i += 1;

        }
        if (i == 1)
        {
            animacjaTap.SetActive(false);
            animacjaRotate.SetActive(true);
            animacjaWychylenie.SetActive(false);
            animacjaTouch.SetActive(false);
            tekst.text = "Roll to focus view";
            
        }
        else if (i == 2)
        {
            animacjaTap.SetActive(false);
            animacjaRotate.SetActive(false);
            animacjaWychylenie.SetActive(true);
            animacjaTouch.SetActive(false);
           
            tekst.text = "Tilt your head to rotate";
           

        }else if (i == 3){
            animacjaTap.SetActive(false);
            animacjaRotate.SetActive(false);
            animacjaWychylenie.SetActive(false);
            animacjaTouch.SetActive(true);

            tekst.text = "Touch to move";
        }
        else if (i > 3)
        {

            SceneManager.LoadScene("Menu");

            i = 0;
        }
    }

	// Update is called once per frame
	void Update () {
        Skip();
	}
}
