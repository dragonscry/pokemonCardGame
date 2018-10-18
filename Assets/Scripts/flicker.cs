using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flicker : MonoBehaviour {

    public Color col;
    public Color red = Color.red;

    SpriteRenderer spr;

	// Use this for initialization
	void Start () {
        spr = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {

	}

    public IEnumerator flicking ()
    {
        for (int i = 0; i < 3; i++)
        {
            spr.color = red;
            yield return new WaitForSeconds(0.1f);
            spr.color = col;
            yield return new WaitForSeconds(0.1f);

        }

    }

    public void beginFlick()
    {
        StartCoroutine(flicking());
        GetComponent<AudioSource>().Play();
    }
}
