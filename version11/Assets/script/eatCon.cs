using UnityEngine;
using System.Collections;

public class eatCon : MonoBehaviour {
    public AudioClip eatsound;//hyh
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("eat"))
        {
            getConfeito.instance.numOfConfeito--;
            GameManager.instance.HealthPlus(1);
			Destroy(this.gameObject);
            AudioSource.PlayClipAtPoint(eatsound, transform.position);//hyh
        }
	}
}
