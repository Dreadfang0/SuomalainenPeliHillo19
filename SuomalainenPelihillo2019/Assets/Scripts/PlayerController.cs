using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public static PlayerController instance;
    [SerializeField] // Komento = Alla olevaa arvoa voi muuttaa Unityssä
    private float movementSpeed;
    [SerializeField]
    PlayerInputReader WorkStation;
    void Start () {
        instance = this;
	}
	
	
	void Update () {
        if(WorkStation.Working == false)
            HandleMovementInput();
        //HandleRotationInput();
       
    }
    void HandleMovementInput()
    {
        float _horizontal = Input.GetAxis("Horizontal");  //Get input for horizontal and vertical from Unity
        float _vertical = Input.GetAxis("Vertical");

        Vector3 _movement = new Vector3(_horizontal, _vertical, 0);
        transform.Translate(_movement * movementSpeed * Time.deltaTime, Space.World);
    }
    /*void HandleRotationInput()
    {
        RaycastHit _hit;
        Ray _ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Follow mouse
        if (Physics.Raycast(_ray, out _hit))
        {
            transform.LookAt(new Vector3(_hit.point.x, transform.position.y, _hit.point.z));
        }
    }*/
    
}
