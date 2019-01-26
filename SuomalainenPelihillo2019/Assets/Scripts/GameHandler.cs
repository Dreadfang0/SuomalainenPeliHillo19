using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour {

    public int Weekday;
    int GameState;
    public int Money;
    int PersonLikeYou;
    
    [SerializeField]
    GameObject[] HomeFurniture;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    public void FurnitureActivator(int Furniture)
    {
        if (Furniture == 0)
        {
            HomeFurniture[0].SetActive(true);
        }
        if (Furniture == 1)
        {
            HomeFurniture[1].SetActive(true);
        }
        if (Furniture == 2)
        {
            HomeFurniture[2].SetActive(true);
        }
        if (Furniture == 3)
        {
            HomeFurniture[3].SetActive(true);
        }
        if (Furniture == 4)
        {
            HomeFurniture[4].SetActive(true);
        }

    }
    public void PersonInteraction(int Person, bool Busy)
    {
        if (Person == 0)
        {
            if (Busy == false)
            {
                PersonLikeYou++;
                Debug.Log("eyyyyy Lmao");
            }
            else
            {
                Debug.Log("Im bUsY");
            }
        }
    }
    public void DayChange()
    {
        Weekday++;
        if (Weekday == 7)
        {
            GameState++;
            Weekday = 0;
        }
    }
}
