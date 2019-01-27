using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectMonitor : MonoBehaviour {

    public Collider2D playerAbove, playerBelow;
    public static Transform player;
    SpriteRenderer SR;

    public void Awake()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
        SR = this.GetComponent<SpriteRenderer>();
    }

    

    


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(this.transform.position, player.position) < 20.0f)
        {
            decideColliderToUse();
            decideSortingOrder();
        }
	}
    void decideSortingOrder()
    {
        //SR.sortingOrder = (int)transform.position.y; // (int)Camera.main.WorldToScreenPoint(this.transform.position).y * -1;
    }

    void decideColliderToUse()
    {
        if (player.transform.position.y > this.transform.position.y)
        {
            playerAbove.enabled = true;
            playerBelow.enabled = false;
        }
        else
        {
            playerAbove.enabled = false;
            playerBelow.enabled = true;
        }
    
    }

}
