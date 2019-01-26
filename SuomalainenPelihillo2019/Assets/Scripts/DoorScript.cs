using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour {

    public Text InputText;
    
    public Transform targetPosition;
	// Use this for initialization
	void Start ()
    {
        
	}

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            InputText.text = ("[Space] to Exit");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                new WaitForSeconds(2);
                StartCoroutine("FadeToClear");
                collision.transform.position = targetPosition.position;
            }
                
        }

    }
    
    void OnTriggerExit2D(Collider2D collision)
    {
        InputText.text = (" ");
    }

    // Update is called once per frame
    void Update () {
		
	}
    public SpriteRenderer fadeOverlay;
    public float fadeTime;
    public IEnumerator FadeToClear()
    {
        fadeOverlay.gameObject.SetActive(true);
        fadeOverlay.color = Color.black;
        
        float rate = 1.0f / fadeTime;

        float progress = 0.0f;

        while (progress < 1.0f)
        {
            fadeOverlay.color = Color.Lerp(Color.black, Color.clear, progress);
            progress += rate * Time.deltaTime;
            yield return null;
        }
        fadeOverlay.color = Color.clear;
        fadeOverlay.gameObject.SetActive(false);
    }
}
