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
        i0.name = "미도리";
        i0.cancount = false;
        i0.type = item.Type.skin;
        i0.sprite = sprites[0];
        itemlist.Add(i0);

        item i1 = new item();
        i1.itemnum = 1;
        i1.cost = 10;
        i1.name = "프린세스";
        i1.cancount = true;
        i1.type = item.Type.skin;
        i1.sprite = sprites[1];
        itemlist.Add(i1);
        

        item i2 = new item();
        i2.itemnum = 2;
        i2.cost = 99;
        i2.name = "할리퀸";
        i2.cancount = true;
        i2.type = item.Type.skin;
        i2.sprite = sprites[2];
        itemlist.Add(i2);

        item i3 = new item();
        i3.itemnum = 3;
        i3.cost = 99;
        i3.name = "할리퀸";
        i3.cancount = true;
        i3.type = item.Type.skin;
        i3.sprite = sprites[3];
        itemlist.Add(i3);


    }
	
	// Update is called once per frame
	void Update () {
	}
}
