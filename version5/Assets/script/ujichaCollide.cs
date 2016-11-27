using UnityEngine;
using System.Collections;

//ssc
public class ujichaCollide : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("Jissou")){
			this.gameObject.SetActive(false);
		}
	}
}