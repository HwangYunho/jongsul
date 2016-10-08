using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class itemDB : MonoBehaviour {

    public Sprite[] sprites;
    public static List<item> itemlist = new List<item>();

	// Use this for initialization
	void Start () {
        //item creation

        item i0 = new item();
        i0.itemnum = 0;
        i0.cost = 100;
        i0.name = "pink";
        i0.type = item.Type.skin;
        i0.sprite = sprites[0];
        itemlist.Add(i0);

        item i1 = new item();
        i1.itemnum = 1;
        i1.cost = 10;
        i1.name = "midori";
        i1.type = item.Type.skin;
        i1.sprite = sprites[1];
        itemlist.Add(i1);


    }
	
	// Update is called once per frame
	void Update () {
	}
}
