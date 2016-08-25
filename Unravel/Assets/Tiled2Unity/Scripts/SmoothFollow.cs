using UnityEngine;
using System.Collections;

public class SmoothFollow : MonoBehaviour
{

    //public Transform player;
    // Use this for initialization
    private Transform player = Player_Movement.player_position;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        player = Player_Movement.player_position;
        transform.position = new Vector3(player.position.x, player.position.y, -10);
    }
}