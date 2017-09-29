using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour {
    public Text timerText;
    public string Scena;
    float CzasDoPrzodu = 0;
   float secondsCount;
    float WartoscPoczatkowa;
    public float CzasDoOdliczenia;
 public float JakasWartosc;
    public GameObject Blokada;
    // Use this for initialization
    void Start () {
        WartoscPoczatkowa = CzasDoOdliczenia;
        JakasWartosc = 0;
     
        Blokada.SetActive(false);
	}

	// Update is called once per frame
	void Update () {

       // Debug.Log(CzasLicz());

        if (CzasDoOdliczenia > 0)
        {
           
            JakasWartosc = WartoscPoczatkowa -CzasDoOdliczenia ;
            
        }
   
        if(CzasDoOdliczenia>=0)
        {

            timerText.text = ZaokroglenieWartosci(UpdateTimerUI()).ToString();

        }
        if (CzasDoOdliczenia < 0)
        {
            
            timerText.text = "0.0";
            SceneManager.LoadScene(Scena);
            
        }    
       
    }
 
    double UpdateTimerUI()
    {
        CzasDoOdliczenia -= Time.deltaTime;
        if (CzasDoOdliczenia < 10)
        {

            timerText.color = Color.yellow;
            if (CzasDoOdliczenia < 5)
            {

                timerText.color = Color.red;
                timerText.fontSize = 100;
               
            }

        }
     
     
        return CzasDoOdliczenia;
    }

    

   double ZaokroglenieWartosci(double WartośćZaokrąglenia)
    {

       return WartośćZaokrąglenia = Math.Round(WartośćZaokrąglenia, 2, MidpointRounding.AwayFromZero);
   
    }
}
