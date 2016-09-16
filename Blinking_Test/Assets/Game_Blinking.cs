using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Game_Blinking : MonoBehaviour
{
    public GameObject sphere1;
    public GameObject sphere2;
    public GameObject sphere3;
    float timer = 0;

	// Use this for initialization
	void Start ()
    {
        sphere1.GetComponent<Renderer>().enabled = false;
        sphere2.GetComponent<Renderer>().enabled = false;
        sphere3.GetComponent<Renderer>().enabled = false;
        

    }
	
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;
        print("Timer is at :"+timer);

        if (timer >= 2)
        {
            renderOn(sphere1);
        }
        if (timer >= 3)
        {
            renderOn(sphere2);
        }
        if (timer >= 4)
        {
            renderOn(sphere3);
        }
        if(timer > 5)
        {
            renderOff(sphere1);
            renderOff(sphere2);
            renderOff(sphere3);
        }

    }
    public void renderOn(GameObject ball)
    {
        ball.GetComponent<Renderer>().enabled = true;

    }
    public void renderOff(GameObject ball)
    {
        ball.GetComponent<Renderer>().enabled = false;
    }
}
