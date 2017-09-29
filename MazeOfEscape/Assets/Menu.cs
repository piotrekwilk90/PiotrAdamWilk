using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

    public Text play;
    public Text credits;
    public Text levels;
    public GameObject obraz;
    public GameObject ObrazLevels;
    public GameObject ObrazCredits;
    
    // Use this for initialization
    void Start () {
        obraz.SetActive(false);
        ObrazLevels.SetActive(false);
        ObrazCredits.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        Wyjscie();
	}

    private void Wyjscie()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            SceneManager.LoadScene("Menu");

        }

    }

    void OnTriggerStay(Collider col)
    {


        if (col.gameObject.tag == "Play")
        {

            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("one");

            }




        }
        if (col.gameObject.tag == "Credits")
        {


            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("Credits");

            }


        }

        if (col.gameObject.tag == "Levels")
        {


            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("Levels");

            }


        }



    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Play")
        {

            play.color = Color.red;
            obraz.SetActive(true);


           
        

        }
        
    


    


        if (col.gameObject.tag == "Credits")
        {
            
            credits.color = Color.red;
            ObrazCredits.SetActive(true);
            


        }
        if (col.gameObject.tag == "Levels")
        {
            
            levels.color = Color.red;
            ObrazLevels.SetActive(true);



        }

     

      
    }

    void OnTriggerExit(Collider col)
    {

        if (col.gameObject.tag == "Play")
        {

            play.color = Color.white;
            obraz.SetActive(false);



        }
        if (col.gameObject.tag == "Credits")
        {

            credits.color = Color.white;
            ObrazCredits.SetActive(false);



        }
        if (col.gameObject.tag == "Levels")
        {

            levels.color = Color.white;
            ObrazLevels.SetActive(false);



        }


    }
}
