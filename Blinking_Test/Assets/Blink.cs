using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Blink : MonoBehaviour
{

    public GameObject ball; //assign the game object sphere or what ever you want to blink
    public double timer;
    public bool onoff;
    void Update()
    {
        sphere_blink();
    }

    void sphere_blink()
    {
        if (Time.time > timer)
        {

            timer = Time.time + .4;
            onoff = !onoff;
            //ball.renderer.enabled = onoff;
            ball.GetComponent<Renderer>().enabled = onoff;

        }
    }
}