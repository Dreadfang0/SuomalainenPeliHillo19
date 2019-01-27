using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour {

    public int Weekday;
    public int GameState;
    public int Money;
    public int HomeOMeter;
    int PersonLikeYou;
    [SerializeField]
    Text MoneyText;
    [SerializeField]
    int DayLength;
    [SerializeField]
    GameObject[] HomeFurniture;
    [SerializeField]
    GameObject[] Waifus;
    [SerializeField]
    GameObject WaifuInHome;
    [SerializeField]
    bool HasDate;
    [SerializeField]
    PlayerInputReader WorkScript;
    public bool AtWork;
    [SerializeField]
    GameObject MainCamera;
    [SerializeField]
    GameObject CutSceneCamera;

    int WaifuDateWeek = -1;
    public GameObject EnergyBar;
    [SerializeField]
    ParticleSystem CashParticle;
    [SerializeField]
    ParticleSystem SingleHeartParticle;
    [SerializeField]
    ParticleSystem FullHeartParticle;
    [SerializeField]
    DoorScript fadeOverlay;
    [SerializeField]
    GameObject Player;
    [SerializeField]
    Transform SpawnPoint;
    [SerializeField]
    Transform Shop;
    public GameObject GKidScreen;
    public GameObject KidScreen;
    public GameObject JustWaifuScreen;
    public GameObject LoenlyScreen;
    /*
    // Soundfx
    [SerializeField]
    AudioClip ShopMusic;
    [SerializeField]
    AudioClip Music;
    [SerializeField]
    AudioClip WorkNoice;
    [SerializeField]
    AudioSource Sauce;*/

    void Start ()
    {
        fadeOverlay.StartCoroutine("FadeToClear");
        Player.transform.position = SpawnPoint.position;
        CutSceneCamera.SetActive(false);
        MainCamera.SetActive(true);
        StartCoroutine("DayCycle");
	}
    void Update()
    {
        EnergyBar.GetComponent<Slider>().value = WorkScript.energy;
        if (AtWork == true)
        {
            // Sauce.PlaySomething(WorkNoice);
            EnergyBar.SetActive(true);
        }
        else
        {
            // Sauce.StopSomething(WorkNoice);
            EnergyBar.SetActive(false);
        }
        MoneyText.text = ("$: "+Money);
    }
    public void FurnitureActivator(int Furniture)
    {
        CashParticle.Play();
        if (Furniture == 0)
        {
            HomeFurniture[0].SetActive(true);
            HomeOMeter++;
        }
        if (Furniture == 1)
        {
            HomeFurniture[1].SetActive(true);
            HomeOMeter++;
        }
        if (Furniture == 2)
        {
            HomeFurniture[2].SetActive(true);
            HomeOMeter++;
        }
        if (Furniture == 3)
        {
            HomeFurniture[3].SetActive(true);
            HomeOMeter++;
        }
        if (Furniture == 4)
        {
            HomeFurniture[4].SetActive(true);
            HomeOMeter++;
        }
        if (Furniture == 5)
        {
            HomeFurniture[5].SetActive(true);
            HomeOMeter++;
        }
        if (Furniture == 6)
        {
            HomeFurniture[6].SetActive(true);
            HomeOMeter++;
        }
        if (Furniture == 7)
        {
            HomeFurniture[7].SetActive(true);
            HomeOMeter++;
        }
        if (Furniture == 8)
        {
            HomeFurniture[8].SetActive(true);
            HomeOMeter++;
        }
        if (Furniture == 9)
        {
            HomeFurniture[9].SetActive(true);
            HomeOMeter++;
        }
        if (Furniture == 10)
        {
            HomeFurniture[10].SetActive(true);
            HomeOMeter++;
        }
        if (Furniture == 11)
        {
            HomeFurniture[11].SetActive(true);
            HomeOMeter++;
        }
        if (Furniture == 12)
        {
            HomeFurniture[12].SetActive(true);
            HomeOMeter++;
        }
        if (Furniture == 13)
        {
            HomeFurniture[13].SetActive(true);
            HomeOMeter++;
        }
        if (Furniture == 14)
        {
            HomeFurniture[14].SetActive(true);
            HomeOMeter++;
        }
        if (Furniture == 15)
        {
            HomeFurniture[15].SetActive(true);
            HomeOMeter++;
        }
        if (Furniture == 16)
        {
            HomeFurniture[16].SetActive(true);
            HomeOMeter++;
        }
        if (Furniture == 17)
        {
            HomeFurniture[17].SetActive(true);
            HomeOMeter++;
        }
        if (Furniture == 18)
        {
            HomeFurniture[18].SetActive(true);
            HomeOMeter++;
        }
        if (Furniture == 19)
        {
            HomeFurniture[19].SetActive(true);
            HomeOMeter++;
        }
        if (Furniture == 20)
        {
            HomeFurniture[20].SetActive(true);
            HomeOMeter++;
        }
        if (Furniture == 21)
        {
            HomeFurniture[21].SetActive(true);
            HomeOMeter++;
        }
        if (Furniture == 22)
        {
            HomeFurniture[22].SetActive(true);
            HomeOMeter++;
        }
        if (Furniture == 23)
        {
            HomeFurniture[23].SetActive(true);
            HomeOMeter++;
        }
        if (Furniture == 24)
        {
            HomeFurniture[24].SetActive(true);
            HomeOMeter++;
        }
        if (Furniture == 25)
        {
            HomeFurniture[25].SetActive(true);
            HomeOMeter++;
        }
        if (Furniture == 26)
        {
            HomeFurniture[26].SetActive(true);
            HomeOMeter++;
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
                if(PersonLikeYou >= 2)
                    SingleHeartParticle.Play();
                if (PersonLikeYou == 3)
                {
                    FullHeartParticle.Play();
                    HasDate = true;
                }
            }
            else
            {
                Debug.Log("Im bUsY");
            }
            
        }
    }
    IEnumerator GoOnDate()
    {
        // Waifu cutscene or smth
        Debug.Log("Meneekse tänne?");
        CutSceneCamera.SetActive(true);
        MainCamera.SetActive(false);
        Debug.Log("?");
        yield return new WaitForSeconds(13);
        CutSceneCamera.SetActive(false);
        MainCamera.SetActive(true);
        HasDate = false;
        Debug.Log("?!");
        WaifuDateWeek = GameState;
        DayChange();
    }
    IEnumerator DayCycle()
    {
        Debug.Log("Start of a new day");
        Debug.Log("Go to work");

        yield return new WaitForSeconds(DayLength / 20 *5);
        Debug.Log("Work Time has started");
        yield return new WaitForSeconds(DayLength / 10 * 6);
        //Throw player out of work
        fadeOverlay.StartCoroutine("FadeToClear");
        Player.transform.position = Shop.position;
        AtWork = false;
        Debug.Log("Shopping time");
        yield return new WaitForSeconds(DayLength / 20 * 3);
        Debug.Log("REEE "+Weekday);
        if (Weekday == 5)
        {
            StartCoroutine(GoOnDate());
        }
        else
        {
            DayChange();
        }
        
    }
    
    public void DayChange()
    {
        Weekday++;
        Debug.Log("Day "+Weekday+" has passed");
        HomeOMeter--;
        if (HasDate == true && Weekday == 5)
        {
            WaifuInHome.SetActive(true);

        }
        else if(Weekday == 5)
        {
            Debug.Log("Years have passed!?");
            GameState++;
            Weekday = 0;
            if (GameState == 3)
            {
                if (WaifuDateWeek == 0)
                {
                    GKidScreen.SetActive(true);
                }
                if (WaifuDateWeek == 1)
                {
                    KidScreen.SetActive(true);
                }
                if (WaifuDateWeek == 2)
                {
                    JustWaifuScreen.SetActive(true);
                }
                if (WaifuDateWeek == -1)
                {
                    LoenlyScreen.SetActive(true);
                }
            }
        }
        if (Weekday == 6)
        {
            Debug.Log("Years have passed!?");
            GameState++;
            Weekday = 0;
        }
        fadeOverlay.StartCoroutine("FadeToClear");
        Player.transform.position = SpawnPoint.position;
        StartCoroutine("DayCycle");
        foreach (GameObject Waifu in Waifus)
        {
            Waifu.GetComponent<InteractableObject>().PersonInteractionPerDay = 1;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            AtWork = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            AtWork = false;
        }
    }
}
