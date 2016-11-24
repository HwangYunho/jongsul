using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class buttonDisable : MonoBehaviour {
    public int a;
    public Transform cantview;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(!itemDB.itemlist[a].cancount && GameManager.instance.inven[a] > 0 || GameManager.instance.point < itemDB.itemlist[a].cost)
        {
            cantview.gameObject.SetActive(true);
            this.gameObject.transform.GetComponent<Button>().interactable = false;
        }
        else
        {
            cantview.gameObject.SetActive(false);
            this.gameObject.transform.GetComponent<Button>().interactable = true;
        }
	}
}
