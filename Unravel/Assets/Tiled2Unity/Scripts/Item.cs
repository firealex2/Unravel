using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

    public bool is_on = false;
    public float damage = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(is_on)
        {
            transform.position = Player_Movement.player_position;
        }
	}
}
