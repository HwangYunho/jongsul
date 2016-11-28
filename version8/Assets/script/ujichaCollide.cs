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
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit))
			{
				if(this.name == "11"){
				//if(this.CompareTag("test1")){
					DestroyObject(this.cha1);
					GameManager.instance.point += 100;
				}
			}
		}

	}
}