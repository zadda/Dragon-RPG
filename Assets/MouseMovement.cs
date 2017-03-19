using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour 
{

    private GameObject player;
    private Vector3 cursor;

	// Use this for initialization
	void Start () 
	{
        player = GameObject.FindGameObjectWithTag("Player");
        
	}
	
	// Update is called once per frame
	void Update () 
	{




        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            cursor.x = Input.mousePosition.x;
            OnMuisKlik();
        }
	}

    void OnMuisKlik()
    {
        player.transform.position = cursor;
    }

}
