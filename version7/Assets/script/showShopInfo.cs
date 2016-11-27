using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class showShopInfo : MonoBehaviour {

    public int a;
    public Text nametext, cost;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        nametext.text = itemDB.itemlist[a].name;
        cost.text = itemDB.itemlist[a].cost.ToString();
    }
}
