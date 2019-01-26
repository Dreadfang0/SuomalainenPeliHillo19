using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour {

    [SerializeField]
    bool IsFurniture;
    [SerializeField]
    int FurnitureID;
    [SerializeField]
    int FurnitureValue;
    [SerializeField]
    int PersonID;
    [SerializeField]
    int PersonInteractionPerDay;

    public GameHandler GM;
    
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            
            if (IsFurniture == true)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (GM.Money >= FurnitureValue)
                    {
                        GM.FurnitureActivator(FurnitureID);
                        Debug.Log("your furniture has done a thing");
                        GM.Money = GM.Money - FurnitureValue;
                        gameObject.SetActive(false);
                    }
                    else
                    {
                        Debug.Log("You poor, Boi");
                    }
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (PersonInteractionPerDay > 0)
                    {
                        GM.PersonInteraction(PersonID, false);
                        PersonInteractionPerDay--;
                    }
                    else
                    {
                        GM.PersonInteraction(PersonID, true);
                    }
                }
            }
        }
    }
}
