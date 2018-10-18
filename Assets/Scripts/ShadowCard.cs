using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowCard : MonoBehaviour {

    public int choice;
    public int choseCard;
    public GameObject flick;

    private void OnMouseDown()
    {
        choseCard = GameObject.FindWithTag("choceCard").GetComponent<ChooseCard>().numbCard;
        if (choice == choseCard)
        {
            GameObject.FindWithTag("GameController").GetComponent<MainCard>().Restart();
            Debug.Log("true");
        }
        else
        {
            flick.GetComponent<flicker>().beginFlick();
        }
    }

}
