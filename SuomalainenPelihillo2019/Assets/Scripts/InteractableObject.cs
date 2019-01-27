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
    AudioSource Sauce;

    void Start ()
    {
        Sauce = GetComponent<AudioSource>();
	}
    void Update()
    {
        if (Interacting == true)
        {
            if (IsFurniture == true)
            {

                if (FurnitureID == 0)
                    FurnitureText.text = ("[Space] to Purchase Bed(BR) for");
                if (FurnitureID == 1)
                    FurnitureText.text = ("[Space] to Purchase Couples' Bed(BR) for");
                if (FurnitureID == 2)
                    FurnitureText.text = ("[Space] to Purchase Sofa(LR) for ");
                if (FurnitureID == 3)
                    FurnitureText.text = ("[Space] to Purchase Armchair(LR) for ");
                if (FurnitureID == 4)
                    FurnitureText.text = ("[Space] to Purchase Television(LR) for");
                if (FurnitureID == 5)
                    FurnitureText.text = ("[Space] to Purchase Work Desk(LR)");
                if (FurnitureID == 6)
                    FurnitureText.text = ("[Space] to Purchase Kitchen Table(K)");
                if (FurnitureID == 7)
                    FurnitureText.text = ("[Space] to Purchase Kitchen Table Chair Set(K)");
                if (FurnitureID == 8)
                    FurnitureText.text = ("[Space] to Purchase Coffeemaker(K)");
                if (FurnitureID == 9)
                    FurnitureText.text = ("[Space] to Purchase Microwave(K)");
                if (FurnitureID == 10)
                    FurnitureText.text = ("[Space] to Purchase Blender(K)");
                if (FurnitureID == 11)
                    FurnitureText.text = ("[Space] to Purchase Toaster(K)");
                if (FurnitureID == 12)
                    FurnitureText.text = ("[Space] to Purchase actual dishes)");
                if (FurnitureID == 13)
                    FurnitureText.text = ("[Space] to Purchase Carpet(K)");
                if (FurnitureID == 14)
                    FurnitureText.text = ("[Space] to Purchase Fruitbowl(K)");
                if (FurnitureID == 15)
                    FurnitureText.text = ("[Space] to Purchase Garden Gnome(LEGENDARY)(K)");
                if (FurnitureID == 16)
                    FurnitureText.text = ("[Space] to Purchase carpet(LR)");
                if (FurnitureID == 17)
                    FurnitureText.text = ("[Space] to Purchase Piano(LR)");
                if (FurnitureID == 18) //////////////
                    FurnitureText.text = ("[Space] to Purchase small plant(LR)");
                if (FurnitureID == 19)
                    FurnitureText.text = ("[Space] to Purchase medium plant(LR)");
                if (FurnitureID == 20)
                    FurnitureText.text = ("[Space] to Purchase big plant(LR)");
                if (FurnitureID == 21)
                    FurnitureText.text = ("[Space] to Purchase Home sweet home sign(LR)");
                if (FurnitureID == 22)
                    FurnitureText.text = ("[Space] to Purchase painting(LR)");
                if (FurnitureID == 23)
                    FurnitureText.text = ("[Space] to Purchase Better painting?(LR)");
                if (FurnitureID == 24)
                    FurnitureText.text = ("[Space] to Purchase Lämp(LR)");
                if (FurnitureID == 25)
                    FurnitureText.text = ("[Space] to Purchase a pair of nightstands(BR)");
                if (FurnitureID == 26)
                    FurnitureText.text = ("[Space] to Purchase nightstand lämps(BR)");
                if (FurnitureID == 27)
                    FurnitureText.text = ("[Space] to Purchase Dresser(BR)");
                if (FurnitureID == 28)
                    FurnitureText.text = ("[Space] to Purchase Drawer(BR)");
                if (FurnitureID == 29)
                    FurnitureText.text = ("[Space] to Purchase Mirror(BR)");
                if (FurnitureID == 30)
                    FurnitureText.text = ("[Space] to Purchase small table(BR)");
                if (FurnitureID == 31)
                    FurnitureText.text = ("[Space] to Purchase Painting Rack(LR)");
                if (FurnitureID == 32)
                    FurnitureText.text = ("[Space] to Purchase carpet(BR)");
                if (FurnitureID == 33)
                    FurnitureText.text = ("[Space] to Purchase ...a plant(BR)");
                if (FurnitureID == 34)
                    FurnitureText.text = ("[Space] to Purchase carpet(WC)");
                if (FurnitureID == 35)
                    FurnitureText.text = ("[Space] to Purchase mirror(WC)");
                if (FurnitureID == 36)
                    FurnitureText.text = ("[Space] to Purchase sigh(WC)");
                if (FurnitureID == 37)
                    FurnitureText.text = ("[Space] to Purchase shaving kit(WC)");
                if (FurnitureID == 38)
                    FurnitureText.text = ("[Space] to Purchase Legendary item(WC)");


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
                    Sauce.Play();
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
