using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOrder : MonoBehaviour {

    SpriteRenderer sr;
	// Use this for initialization
	void Start () {
        sr = GetComponent<SpriteRenderer>();
        sr.sortingOrder = -(int)transform.position.y;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
