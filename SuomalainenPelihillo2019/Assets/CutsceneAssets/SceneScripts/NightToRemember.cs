using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightToRemember : MonoBehaviour {

    [SerializeField]
    GameObject rotator;
    GameObject moon;
    [SerializeField]
    GameObject house;
    [SerializeField]
    ParticleSystem LoveGenerator;

    [SerializeField]
    float cosmicRoationSpeed;

	// Use this for initialization
	void Start ()
    {
        cosmicRoationSpeed = 1;
        moon = rotator.transform.GetChild(1).gameObject;
        rotator.transform.rotation = Quaternion.AngleAxis(10, Vector3.back);
        SceneLogic();
	}
	
	// Update is called once per frame
	void Update ()
    {
        rotator.transform.Rotate(0, 0, -cosmicRoationSpeed * Time.deltaTime);
        moon.transform.Rotate(0, 0, cosmicRoationSpeed * Time.deltaTime);
	}

    void SceneLogic()
    {
        LoveGenerator.Play();


    }
}
