using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InneSkrypty : MonoBehaviour {


   // public GameObject CubeObrotowy;
    public GameObject Sceneria;
    public GameObject PierwszyTip;
    
    public Light SwiatloGlowne;
    public Text TekstInfo;
    public GameObject Czas;
   

	// Use this for initialization
	void Start () {
        i = 0;
      licznik = 0;
        Sceneria.SetActive(false);
        PierwszyTip.SetActive(true);
       // Enter.SetActive(true);
        SwiatloGlowne.intensity = 1.0f;
        Czas.SetActive(false);
	}
    private int i;
    
    void WylaczanieElementów()
    {
        if (Input.GetMouseButtonDown(0))
        {

            SwiatloGlowne.intensity = 0.1f;
            PierwszyTip.SetActive(false);
            Sceneria.SetActive(true);
            Czas.SetActive(true);
            // Enter.SetActive(false);
            i = i + 1;
            licznik = 0;
            if (i > 1)
            {
                
               // CubeObrotowy.SetActive(false);
            }


        }
        if (Input.GetKey(KeyCode.Escape))
        {
            SwiatloGlowne.intensity = 1.0f;
            TekstInfo.text = "Press Escape Button to Exit";

        }
    }

 int licznik;
    private void Wyjscie()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            PierwszyTip.SetActive(true);
            licznik += 1;
            
            if (licznik > 1)
            {
                SceneManager.LoadScene("Menu");

                licznik = 0;
            }
        }

        

    }
    // Update is called once per frame
    void Update () {

        WylaczanieElementów();
        Wyjscie();
		
	}
}
