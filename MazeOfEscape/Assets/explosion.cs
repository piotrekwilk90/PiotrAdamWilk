using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour {
    public Rigidbody p;
    public GameObject BOX;
    private bool Generuj;
    private int i;
    GameObject[] Obiekty;
    // Use this for initialization
    void Start () {
		
	}


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish")){
            Obiekty = GameObject.FindGameObjectsWithTag("Cuby");
            if (Obiekty.Length > 70)
            {
                Destroy(GameObject.FindGameObjectWithTag("Cuby"));


            }

            // if (BOX.transform.position.y < 200)


            if (Obiekty.Length < 30)
            {

                //niezly efekt
                Generuj = false;
                Rigidbody clone;
                clone = Instantiate(p, transform.position, transform.rotation) as Rigidbody;
                clone.velocity = transform.TransformDirection(Vector3.forward * 10);

                Destroy(clone.gameObject, 5);

                Debug.Log(Obiekty.Length);
            }
        }
    }

    // Update is called once per frame
    void Update () {

        
     


        

    }
}
