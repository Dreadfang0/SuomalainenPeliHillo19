using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputReader : MonoBehaviour {

    public float energyAmount;
    public float energy;
    public GameHandler GM;
    public int munies = 0;
    public bool Working = false;
    List<string> allowed = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "Y", "W", "V", "X", "Y", "Z"};
    public List<string> usedKeys = new List<string>();
    [SerializeField]
    ParticleSystem HavMoni;
    bool interacting;
    /*[SerializeField] // SFX
    AudioClip Coins;
    [SerializeField]
    AudioSource Sauce;*/

    [SerializeField]
    AudioClip[] keyboardSounds = new AudioClip[27];
    AudioSource keyboardSoundSource;

    // Use this for initialization
    void Start()
    {
        energy = energyAmount;
        keyboardSoundSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GM.AtWork == true)
        {
            exhaustion();
            if (Working == true)
            {
                ReadKeys();
               // testResetEnergy();
            }
            if (interacting == true)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                    Working = !Working;
            }
        }
    }

    void ReadKeys()
    {
        foreach (KeyCode KeyPressed in System.Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(KeyPressed) && allowed.Contains(KeyPressed.ToString()) && usedKeys.IndexOf(KeyPressed.ToString()) < 0 && energy >= 0)
            {
                if (usedKeys.Count >= 10)
                {
                    usedKeys.RemoveAt(0);
                }

                usedKeys.Add(KeyPressed.ToString());
                keyboardSoundSource.clip = keyboardSounds[Random.Range(0, 26)];
                keyboardSoundSource.Play();
                gibMunies();
            }
        }
    }

    void exhaustion()
    {
        if (energy >= 0)
        {
            energy -= Time.deltaTime;
        }
        else
        {
            Working = false;
        }
    }

    void gibMunies()
    {
        GM.Money++;
        //Sauce.PlayOneShot(Coins);
        HavMoni.Play();
        //Debug.Log("added one munies" + "(" + GM.Money + ")");
    }

    void testResetEnergy()
    {
        if(Input.GetKeyDown("up"))
        {
            energy = energyAmount;
        }       
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            interacting = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            interacting = false;
        }
    }

}
