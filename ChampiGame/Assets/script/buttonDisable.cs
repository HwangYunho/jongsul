using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class buttonDisable : MonoBehaviour {
    public int a;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(!itemDB.itemlist[a].cancount && GameManager.instance.inven[a] > 0)
        {
            this.gameObject.transform.GetComponent<Button>().interactable = false;
        }
	}
}
