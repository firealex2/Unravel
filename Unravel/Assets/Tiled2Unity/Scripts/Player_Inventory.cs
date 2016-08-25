using UnityEngine;
using System.Collections;

public class Player_Inventory : MonoBehaviour {


    public GameObject[] HotBar = new GameObject[200];
    public int items = 0;
    private Transform player;
    private SpriteRenderer sr;

    // Use this for initialization
    void Start () {
	
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1) && items>=1)
            set_active(1);
        if (Input.GetKeyDown(KeyCode.Alpha2) && items>=2)
            set_active(2);
        if (Input.GetKeyDown(KeyCode.Alpha3) && items>=3)
            set_active(3);
        if (Input.GetKeyDown(KeyCode.Q))
            Destroy(this.gameObject);
    }

    void set_active(int number)
    {
        player = Player_Movement.player_position;
        GameObject[] finds = GameObject.FindGameObjectsWithTag("Owned_Item");
        foreach(GameObject obj in finds)
        {
            Item comp = obj.GetComponent<Item>();
            if(comp.is_on == true)
            {
                comp.is_on = false;
                sr = obj.GetComponent<SpriteRenderer>();
                sr.sortingLayerName = "Default";
            }
        }
        Item item = HotBar[number].GetComponent<Item>();
        item.is_on = true;
        //Instantiate(HotBar[number], player.position, Quaternion.identity);
        sr = HotBar[number].GetComponent<SpriteRenderer>();
        sr.sortingLayerName = "Default";
    }

    void OnTriggerEnter2D(Collider2D item)
    {
        if (item.tag == "Item")
        {
            HotBar[++items] = item.gameObject;
            sr = item.GetComponent<SpriteRenderer>();
            sr.sortingLayerName = "Default";
            item.tag = "Owned_Item";
        }
    }
}
