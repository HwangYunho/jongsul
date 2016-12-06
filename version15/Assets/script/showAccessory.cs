using UnityEngine;
using System.Collections;

public class showAccessory : MonoBehaviour {

    public int a;
    public Transform b;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(GameManager.instance.skin == a)
        {
            b.gameObject.SetActive(true);
        }
        else
        {
            b.gameObject.SetActive(false);
        }
	}
}
