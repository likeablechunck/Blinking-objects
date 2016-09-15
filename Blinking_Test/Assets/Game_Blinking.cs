using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Game_Blinking : MonoBehaviour
{
    public GameObject sphere1;
    public GameObject sphere2;
    public GameObject cube;
    float timer;

	// Use this for initialization
	void Start ()
    {
        timer = Time.time;

    }
	
	// Update is called once per frame
	void Update ()
    {
        print("Timer is at :"+timer);

	
	}
    public void renderOn(GameObject object)
    {

    }
}
