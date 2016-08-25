using UnityEngine;
using System.Collections;

public class Player_Movement : MonoBehaviour {

    public float speed = 0.1f;
    public static Transform player_position;
    public LayerMask blockinglayer;
    private PolygonCollider2D boxcollider;
    public GameObject frost_bolt;
    private Animation anim;

    // Use this for initialization
    void Start()
    {
        boxcollider = GetComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        player_position = transform;
        RaycastHit2D hit;

        if (!Game_Over())
        {

            if (Input.GetKey(KeyCode.W) && move(0.0f, speed * Time.deltaTime, out hit))
                transform.position += new Vector3(0.0f, speed * Time.deltaTime, 0.0f);

            if (Input.GetKey(KeyCode.S) && move(0.0f, -speed * Time.deltaTime, out hit))
                transform.position += new Vector3(0.0f, -speed * Time.deltaTime, 0.0f);

            if (Input.GetKey(KeyCode.D) && move(speed * Time.deltaTime, 0.0f, out hit))
                transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);

            if (Input.GetKey(KeyCode.A) && move(-speed * Time.deltaTime, 0.0f, out hit))
                transform.position += new Vector3(-speed * Time.deltaTime, 0.0f, 0.0f);
        }
    }

    private bool move(float dx, float dy, out RaycastHit2D hit)
    {
        Vector3 start = transform.position;
        Vector3 end = start + new Vector3(dx, dy, 0.0f);
        boxcollider.enabled = false;
        hit = Physics2D.Linecast(start, end, blockinglayer);
        boxcollider.enabled = true;
        if (hit.transform == null)
            return true;
        return false;
    }

    private bool Game_Over()
    {
        return false;
    }

}
