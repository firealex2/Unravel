using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

    public bool is_on = false;
    public float damage = 5f;
    private Transform player;
    SpriteRenderer sr;
	// Use this for initialization
	void Start () {
        sr = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(is_on)
        {
            sr.sortingLayerName = "in_hand";
            player = Player_Movement.player_position;
            transform.position = new Vector3(player.position.x+0.5f, player.position.y-0.14f, 0);
        }
	}
}
