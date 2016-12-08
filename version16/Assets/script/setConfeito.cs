using UnityEngine;
using System.Collections;

public class setConfeito : MonoBehaviour {

    public GameObject confeito;
    public bool mouseDown = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0)&&!mouseDown)
        {
            mouseDown = true;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                Instantiate(confeito, hit.point, transform.rotation);
                getConfeito.instance.numOfConfeito++;
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            mouseDown = false;
        }
	}
}
