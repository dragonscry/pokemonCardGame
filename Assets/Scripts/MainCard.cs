using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCard : MonoBehaviour {

    public GameObject[] pokemons;

    public GameObject[] shadows;

    public Vector3[] vectors;

    public int pokLength;
    public int randChoice;


    private void Awake()
    {
        pokLength = pokemons.Length;
    }

    // Use this for initialization
    void Start () {


        shadowPokemon();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void shadowPokemon()
    {
        randChoice = Random.Range(0, pokLength);

        Instantiate(pokemons[randChoice], new Vector3(0.22f, 3.5f, -1f), Quaternion.identity);

        int l = Random.Range(0, vectors.Length );
        Instantiate(shadows[randChoice], vectors[l], Quaternion.identity);


        for (int i = 0; i < vectors.Length; i++)
        {
            if (i != l)
            {
                int k = Random.Range(0, pokLength);
                if (k!=randChoice)
                {
                    Instantiate(shadows[k], vectors[i], Quaternion.identity);

                }
                else if (k == randChoice)
                {
                    k = Random.Range(0, pokLength);
                    Instantiate(shadows[k], vectors[i], Quaternion.identity);

                }

            }

        }
    }

    void DeleteObjects()
    {
        GameObject[] arr = GameObject.FindGameObjectsWithTag("card");
        for (int i = 0; i < arr.Length; i++)
        {
            Destroy(arr[i]);
        }
        GameObject onearr = GameObject.FindGameObjectWithTag("choceCard");
        Destroy(onearr);

    }

    public void Restart()
    {
        DeleteObjects();
        shadowPokemon();
    }

}
