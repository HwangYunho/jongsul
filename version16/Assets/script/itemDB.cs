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
        i0.cost = 10;
        i0.name = "미도리";
        i0.cancount = false;
        i0.type = item.Type.skin;
        i0.sprite = sprites[0];
        itemlist.Add(i0);

        item i1 = new item();
        i1.itemnum = 1;
        i1.cost = 20;
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
        i3.cost = 30;
        i3.name = "a1";
        i3.cancount = true;
        i3.type = item.Type.skin;
        i3.sprite = sprites[3];
        itemlist.Add(i3);

        item i4 = new item();
        i4.itemnum = 4;
        i4.cost = 31;
        i4.name = "a2";
        i4.cancount = true;
        i4.type = item.Type.skin;
        i4.sprite = sprites[4];
        itemlist.Add(i4);

        item i5 = new item();
        i5.itemnum = 5;
        i5.cost = 32;
        i5.name = "a3";
        i5.cancount = true;
        i5.type = item.Type.skin;
        i5.sprite = sprites[5];
        itemlist.Add(i5);

        item i6 = new item();
        i6.itemnum = 6;
        i6.cost = 33;
        i6.name = "a4";
        i6.cancount = true;
        i6.type = item.Type.skin;
        i6.sprite = sprites[6];
        itemlist.Add(i6);

        item i7 = new item();
        i7.itemnum = 7;
        i7.cost = 34;
        i7.name = "a5";
        i7.cancount = true;
        i7.type = item.Type.skin;
        i7.sprite = sprites[7];
        itemlist.Add(i7);

        item i8 = new item();
        i8.itemnum = 8;
        i8.cost = 35;
        i8.name = "a6";
        i8.cancount = true;
        i8.type = item.Type.skin;
        i8.sprite = sprites[8];
        itemlist.Add(i8);

        item i9 = new item();
        i9.itemnum = 9;
        i9.cost = 36;
        i9.name = "a7";
        i9.cancount = true;
        i9.type = item.Type.skin;
        i9.sprite = sprites[9];
        itemlist.Add(i9);

        item i10 = new item();
        i10.itemnum = 10;
        i10.cost = 37;
        i10.name = "a8";
        i10.cancount = true;
        i10.type = item.Type.skin;
        i10.sprite = sprites[10];
        itemlist.Add(i10);

        item i11 = new item();
        i11.itemnum = 11;
        i11.cost = 38;
        i11.name = "a9";
        i11.cancount = true;
        i11.type = item.Type.skin;
        i11.sprite = sprites[11];
        itemlist.Add(i11);

        item i12 = new item();
        i12.itemnum = 12;
        i12.cost = 39;
        i12.name = "a10";
        i12.cancount = true;
        i12.type = item.Type.skin;
        i12.sprite = sprites[12];
        itemlist.Add(i12);

        item i13 = new item();
        i13.itemnum = 13;
        i13.cost = 40;
        i13.name = "a10";
        i13.cancount = true;
        i13.type = item.Type.skin;
        i13.sprite = sprites[13];
        itemlist.Add(i13);
    }
	
	// Update is called once per frame
	void Update () {
	}
}
