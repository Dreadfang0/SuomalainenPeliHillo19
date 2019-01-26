using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour {

    public int Weekday;
    public int GameState;
    public int Money;
    int PersonLikeYou;
    [SerializeField]
    int DayLength;
    [SerializeField]
    GameObject[] HomeFurniture;
    [SerializeField]
    GameObject[] Waifus;

    public bool AtWork;
    public GameObject EnergyBar;
	void Start ()
    {
        StartCoroutine("DayCycle");
	}
    void Update()
    {
        if (AtWork == true)
        {
            //EnergyBar.SetActive(true);
        }
        else
        {
            //EnergyBar.SetActive(false);
        }
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
            if (PersonLikeYou == 5)
            {

            }
        }
    }
    IEnumerator DayCycle()
    {
        Debug.Log("Start of a new day");
        yield return new WaitForSeconds(DayLength);
        DayChange();
        
    }
    public void DayChange()
    {
        Weekday++;
        Debug.Log("Day "+Weekday+" has passed");
        if (Weekday == 7)
        {
            Debug.Log("Years have passed!?");
            GameState++;
            Weekday = 0;
        }
        StartCoroutine("DayCycle");
        foreach (GameObject Waifu in Waifus)
        {
            Waifu.GetComponent<InteractableObject>().PersonInteractionPerDay = 1;
        }
    }
}
