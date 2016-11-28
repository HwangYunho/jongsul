using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class countInvenNum : MonoBehaviour {
    public int a;
    public Text nametext, count;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update ()
    {
        nametext.text = itemDB.itemlist[a].name;
        count.text = GameManager.instance.inven[a].ToString();
    }
}
