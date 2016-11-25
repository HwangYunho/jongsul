using UnityEngine;
using System.Collections;

public class textLookat : MonoBehaviour {

    public GameObject maincamera;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.LookAt(maincamera.transform.position);
	}
}
