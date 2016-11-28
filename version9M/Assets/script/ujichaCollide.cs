using UnityEngine;
using System.Collections;

public class ujichaCollide : MonoBehaviour {

	public GameObject cha1;
	//public bool mouseDown = false;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0))
		{
			DestroyObject(cha1);
			GameManager.instance.point += 100;
		}

	}
}