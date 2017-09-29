using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelsMenu : MonoBehaviour
{

    public Text One,Two,Three,Four,Random;
    
    public Image arrorRight;
    public Image arrorLeft;
    public GameObject obraz;
   
   
   
    public GameObject MenuL;

    // Use this for initialization
    void Start()
    {
        obraz.SetActive(false);
       
      
    }

    // Update is called once per frame
    void Update()
    {
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


        if (col.gameObject.tag == "One")
        {

            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("one");

            }




        }
        if (col.gameObject.tag == "Two")
        {


            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("Two");

            }


        }
        if (col.gameObject.tag == "Three")
        {


            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("Three");

            }


        }
        if (col.gameObject.tag == "Four")
        {


            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("Four");

            }


        }
        if (col.gameObject.tag == "Random")
        {


            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("Random");

            }


        }



    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "One" )
        {

            One.color = Color.red;
            obraz.SetActive(true);
        }
        if (col.gameObject.tag == "Two")
        {

            Two.color = Color.red;
            obraz.SetActive(true);
        }
        if (col.gameObject.tag == "Three")
        {

            Three.color = Color.red;
            obraz.SetActive(true);
        }
        if (col.gameObject.tag == "Four")
        {

            Four.color = Color.red;
            obraz.SetActive(true);
        }
        if (col.gameObject.tag == "Random")
        {

            Random.color = Color.red;
            obraz.SetActive(true);
        }









        //Menu Levels

        if (col.gameObject.tag == "MoveLeft")
        {

            
            MenuL.transform.position = new Vector3(MenuL.transform.position.x -300, MenuL.transform.position.y, MenuL.transform.position.z);
            arrorLeft.color = Color.red;

            if (MenuL.transform.position.x < -300)
            {

                MenuL.transform.position = new Vector3(934f, 337.1953f, 162.25f);
            }

        }
        if (col.gameObject.tag == "MoveRight")
        {

            MenuL.transform.position = new Vector3(MenuL.transform.position.x + 300, MenuL.transform.position.y, MenuL.transform.position.z);
            arrorRight.color = Color.red;
            if (MenuL.transform.position.x > 1000)
            {

                MenuL.transform.position = new Vector3(-266f, 337.1953f, 162.25f);
            }

        }
    }

    void OnTriggerExit(Collider col)
    {


        if (col.gameObject.tag == "MoveRight")
        {

            
            arrorRight.color = Color.white;
        }
        if (col.gameObject.tag == "MoveLeft")
        {


            arrorLeft.color = Color.white;
        }
        if (col.gameObject.tag == "One" || col.gameObject.tag == "Two" || col.gameObject.tag == "Three" || col.gameObject.tag == "Four" || col.gameObject.tag == "Random")
        {

            One.color = Color.white;
            Two.color = Color.white;
            Three.color = Color.white;
            Four.color = Color.white;
           Random.color = Color.white;





            obraz.SetActive(false);



        }
     
      


    }
}
