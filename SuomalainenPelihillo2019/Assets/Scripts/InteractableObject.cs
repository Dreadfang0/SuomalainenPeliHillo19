using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableObject : MonoBehaviour {

    [SerializeField]
    bool IsFurniture;
    [SerializeField]
    bool Coffemaker;
    [SerializeField]
    int FurnitureID;
    [SerializeField]
    int FurnitureValue;
    [SerializeField]
    int PersonID;

    public Text FurnitureText;
    public int PersonInteractionPerDay;
    public PlayerInputReader Work;
    public GameHandler GM;
    
    void Start ()
    {
		
	}
	
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            
            if (IsFurniture == true)
            {
                
                if(FurnitureID == 0)
                    FurnitureText.text = ("[Space] to Purchase Bed");
                if (FurnitureID == 1)
                    FurnitureText.text = ("[Space] to Purchase Bed");
                if (FurnitureID == 2)
                    FurnitureText.text = ("[Space] to Purchase Bed");
                if (FurnitureID == 3)
                    FurnitureText.text = ("[Space] to Purchase Bed");
                if (FurnitureID == 4)
                    FurnitureText.text = ("[Space] to Purchase Bed");
                if (FurnitureID == 5)
                    FurnitureText.text = ("[Space] to Purchase Bed");
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
            if (Coffemaker == true)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Work.energy = Work.energyAmount;
                }
            }
            if (IsFurniture == false && Coffemaker == false)
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
