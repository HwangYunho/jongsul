using UnityEngine;
using System.Collections;

public class Holder : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.z < -2.3f)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, -2.2f);
        }
        if (this.transform.position.z > 2.3f)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 2.2f);
        }
        if (this.transform.position.y < 0)
        {
            this.transform.position = new Vector3(this.transform.position.x, 1f, this.transform.position.z);
        }
        if (this.transform.position.x < -4.75f)
        {
            this.transform.position = new Vector3(-4.7f, this.transform.position.y, this.transform.position.z);
        }
        if (this.transform.position.x > 4.75f)
        {
            this.transform.position = new Vector3(4.7f, this.transform.position.y, this.transform.position.z);
        }
        if (this.transform.position.y > 6f)
        {
            this.transform.position = new Vector3(this.transform.position.x, 5f, this.transform.position.z);
        }
    }
}
