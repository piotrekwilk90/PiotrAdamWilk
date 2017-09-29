using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class animacjalogo : MonoBehaviour
{
    public SpriteRenderer anim;
    public Sprite sprite;

    // Use this for initialization
    void Start()
    {

    }

    void SkipLogo()
    {
        if (anim.sprite.name == "MAZETwo_62")
        {
            SceneManager.LoadScene("Instrukcje");

            
        }

    }
    // Update is called once per frame
    void Update()
    {

        SkipLogo();
    }
}