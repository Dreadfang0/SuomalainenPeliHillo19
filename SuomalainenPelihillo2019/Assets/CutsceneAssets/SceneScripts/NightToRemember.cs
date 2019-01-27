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
    float cosmicRotationSpeed;

    [SerializeField]
    Animator House;

    void Awake()
    {     
        cosmicRotationSpeed = 1;
        moon = rotator.transform.GetChild(1).gameObject;
        rotator.transform.rotation = Quaternion.AngleAxis(10, Vector3.back);
        SceneLogic();
	}

	void Update ()
    {
        rotator.transform.Rotate(0, 0, -cosmicRotationSpeed * Time.deltaTime);
        moon.transform.Rotate(0, 0, cosmicRotationSpeed * Time.deltaTime);

        if(LoveGenerator.isPlaying == false)
        {
            House.SetBool("Play", true);
        }
	}

    void SceneLogic()
    {
        LoveGenerator.Play();
    }
}
