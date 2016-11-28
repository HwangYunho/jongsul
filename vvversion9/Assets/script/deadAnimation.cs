using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class deadAnimation : MonoBehaviour {

    public Text healthText, hungerText, closenessText, cockyText, nameText, nameText2, DokraText;
    public Transform ending;

    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {

        nameText.text = GameManager.instance.name.ToString();
        nameText2.text = GameManager.instance.name.ToString();
        healthText.text = GameManager.instance.health.ToString();
        hungerText.text = GameManager.instance.hunger.ToString();
        closenessText.text = GameManager.instance.closeness.ToString();
        cockyText.text = GameManager.instance.cocky.ToString();

        Debug.Log(nameText);
    }

    public void showending()
    {
        ending.gameObject.SetActive(true);
    }
}
