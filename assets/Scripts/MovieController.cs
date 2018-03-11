using UnityEngine;
using System.Collections;

public class MovieController : MonoBehaviour {

    public MovieTexture movie;
    public GameObject Screen;
    void Start()
    {
        GetComponent<Renderer>().material.mainTexture = movie;
        movie.Play();
        Screen.GetComponent<AudioSource>().Play();

        Invoke("DoQuit", 20);
	}

    public void DoQuit()
    {
        Application.Quit();
    }

	void Update()
    {
        
	}
}
