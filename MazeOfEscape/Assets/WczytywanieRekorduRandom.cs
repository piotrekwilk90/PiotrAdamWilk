using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class WczytywanieRekorduRandom : MonoBehaviour
{
    public Text Wartosc;
    public Text RekordGracza;
    int i = 0;
    float CzasGracza;
    float RekordGraczaWynik;
    bool spr;

    // Use this for initialization
    void Start()
    {

        WczytanieCzasu();


    }
    void WczytanieCzasu()
    {
        CzasGracza = PlayerPrefs.GetFloat("CzasGraczaRandom");

        spr = PlayerPrefs.HasKey("CzasGraczaRandom");

        if (spr == false)
        {
            Wartosc.text = CzasGracza.ToString(); //wyswietlenie czasu gracza
            RekordGracza.text = "N/A"; //Wyświetlenie rekorfu gracza
            PlayerPrefs.SetFloat("CzasGraczaRandom", CzasGracza);
            PlayerPrefs.Save();

        }
        else
        {
            RekordGraczaWynik = PlayerPrefs.GetFloat("CzasGraczaRandom");
            if (CzasGracza < RekordGraczaWynik)
            {
                Wartosc.text = "New Record: " + CzasGracza.ToString(); //wyswietlenie czasu gracza
                RekordGracza.text = "Old Record: " + RekordGraczaWynik.ToString(); //Wyświetlenie rekorfu gracza

                PlayerPrefs.SetFloat("CzasGraczaRandom", CzasGracza);
                PlayerPrefs.Save();

            }
            else
            {
                Wartosc.text = CzasGracza.ToString(); //wyswietlenie czasu gracza
                RekordGracza.text = "Record: " + RekordGraczaWynik.ToString(); //Wyświetlenie rekorfu gracza

            }
        }


    }



    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            i += 1;
            if (i > 0)
            {
                RekordGracza.text = "";
                Wartosc.text = "Another Random Round";
            }
            if (i > 1)
            {
                SceneManager.LoadScene("Random");
            }
        }


    }
}
