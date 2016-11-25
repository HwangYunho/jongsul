using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class shopManager : MonoBehaviour {
    public int curentShop;
    public Text costText;
    public Transform popupSign;

	// Use this for initialization
	void Start () {
        curentShop = 0;
	}
	
	// Update is called once per frame
	void Update () {
        costText.text = itemDB.itemlist[curentShop].cost.ToString();
	}

    public void buyok(int a)
    {
        curentShop = a;
        popupSign.gameObject.SetActive(true);
    }
    public void buynok(int a)
    {
        curentShop = a;
        popupSign.gameObject.SetActive(false);
    }
    public void buysomthing()
    {
        GameManager.instance.point -= itemDB.itemlist[curentShop].cost;
        GameManager.instance.inven[curentShop]++;
        popupSign.gameObject.SetActive(false);
    }
}
