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
    bool Interacting;
    public Text FurnitureText;
    public int PersonInteractionPerDay;
    public PlayerInputReader Work;
    public GameHandler GM;
   /* [SerializeField]  // Soundfx
    AudioClip sold;
    [SerializeField]
    AudioClip kohvee;
    [SerializeField]
    AudioClip PersonTalk1;
    [SerializeField]
    AudioClip PersonTalk2;
    [SerializeField]
    AudioSource Sauce;*/
    void Start ()
    {
		
	}
    void Update()
    {
        if (Interacting == true)
        {
            if (IsFurniture == true)
            {

                if (FurnitureID == 0)
                    FurnitureText.text = ("[Space] to Purchase Bed for");
                if (FurnitureID == 1)
                    FurnitureText.text = ("[Space] to Purchase Couples' Bed for");
                if (FurnitureID == 2)
                    FurnitureText.text = ("[Space] to Purchase Sofa for ");
                if (FurnitureID == 3)
                    FurnitureText.text = ("[Space] to Purchase Television for");
                if (FurnitureID == 4)
                    FurnitureText.text = ("[Space] to Purchase WelcomeHome carpet");
                if (FurnitureID == 5)
                    FurnitureText.text = ("[Space] to Purchase Work Desk+computer");
                if (FurnitureID == 6)
                    FurnitureText.text = ("[Space] to Purchase Kitchen Table");
                if (FurnitureID == 7)
                    FurnitureText.text = ("[Space] to Purchase Kitchen Chair Set");
                if (FurnitureID == 8)
                    FurnitureText.text = ("[Space] to Purchase Coffeemaker");                        
                if (FurnitureID == 9)
                    FurnitureText.text = ("[Space] to Purchase Toaster");
                if (FurnitureID == 10)
                    FurnitureText.text = ("[Space] to Purchase Carpet(K)");
                if (FurnitureID == 11)
                    FurnitureText.text = ("[Space] to Purchase Fruitbowl");
                if (FurnitureID == 12)
                    FurnitureText.text = ("[Space] to Purchase Gnome Curtains(LEGENDARY)");
                if (FurnitureID == 13)
                    FurnitureText.text = ("[Space] to Purchase carpet(LR)");
                
                if (FurnitureID == 14) //////////////
                    FurnitureText.text = ("[Space] to Purchase small plant");
                if (FurnitureID == 15)
                    FurnitureText.text = ("[Space] to Purchase big plant");
                if (FurnitureID == 16)
                    FurnitureText.text = ("[Space] to Purchase Home sweet home sign");
                if (FurnitureID == 17)
                    FurnitureText.text = ("[Space] to Purchase painting");
                if (FurnitureID == 18)
                    FurnitureText.text = ("[Space] to Purchase nightstand");
                if (FurnitureID == 19)
                    FurnitureText.text = ("[Space] to Purchase Dresser");
                if (FurnitureID == 20)
                    FurnitureText.text = ("[Space] to Purchase Mirror");
                if (FurnitureID == 21)
                    FurnitureText.text = ("[Space] to Purchase carpet(BR)");
                if (FurnitureID == 22)
                    FurnitureText.text = ("[Space] to Purchase Bar");


                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (GM.Money >= FurnitureValue)
                    {
                        GM.FurnitureActivator(FurnitureID);
                        Debug.Log("your furniture has done a thing");
                        GM.Money = GM.Money - FurnitureValue;
                        //Sauce.PlayOneShot(sold);
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
                    //Sauce.PlayOneShot(kohvee);
                    Work.energy = Work.energyAmount;
                }
            }
            if (IsFurniture == false && Coffemaker == false)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (PersonInteractionPerDay > 0)
                    {
                        //Sauce.PlayOneShot(PersonTalk1);
                        GM.PersonInteraction(PersonID, false);
                        PersonInteractionPerDay--;
                    }
                    else
                    {
                        //Sauce.PlayOneShot(PersonTalk2);
                        GM.PersonInteraction(PersonID, true);
                    }
                }
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Interacting = true;
            
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        Interacting = false;
        FurnitureText.text = (" ");
    }
}
