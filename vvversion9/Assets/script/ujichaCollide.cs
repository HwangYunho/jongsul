using UnityEngine;
using System.Collections;

//ssc
public class ujichaCollide : MonoBehaviour {
	
	void Update()
	{
		
	}

	void OnMouseEnter()
	{
		//this.gameObject.SetActive (false);
		Invoke("destory",0.5f);
		GameManager.instance.point += 100;
		GameManager.instance.numOfUjicha--;
	}

	void destory(){
		Destroy(this.gameObject);
	}
}


