using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SkinSelector : MonoBehaviour {

    public int currentSkin;
    public Transform popup;
    public Text nameText;

    public GameObject hood, hoodear1, hoodear2, dress1, dress2, dress3, leftarm, rightarm, leftleg, rightleg;

    public Material midori, pink;

	// Use this for initialization
	void Start () {
        currentSkin = 0;
        getskin1();
	}
	
	// Update is called once per frame
	void Update () {
        nameText.text = itemDB.itemlist[currentSkin].name.ToString();
    }

    public void selectok(int a)
    {
        currentSkin = a;
        popup.gameObject.SetActive(true);
        
    }

    public void selectnok(int a)
    {
        currentSkin = a;
        popup.gameObject.SetActive(false);
    }

    public void selectSkin()
    {
        int a = currentSkin;
        switch (a)
        {
            case 0:
                getskin0();
                break;
            case 1:
                getskin1();
                break;
            case 2:
                getskin1();
                break;
        }
        popup.gameObject.SetActive(false);
    }

    public void getskin0()
    {
        hood.transform.GetComponent<Renderer>().material = midori;
        hoodear1.transform.GetComponent<Renderer>().material = midori;
        hoodear2.transform.GetComponent<Renderer>().material = midori;
        dress1.transform.GetComponent<Renderer>().material = midori;
        dress2.transform.GetComponent<Renderer>().material = midori;
        dress3.transform.GetComponent<Renderer>().material = midori;
        leftarm.transform.GetComponent<Renderer>().material = midori;
        rightarm.transform.GetComponent<Renderer>().material = midori;
        leftleg.transform.GetComponent<Renderer>().material = midori;
        rightleg.transform.GetComponent<Renderer>().material = midori;
    }
    public void getskin1()
    {//95c597
        hood.transform.GetComponent<Renderer>().material = pink;
        hoodear1.transform.GetComponent<Renderer>().material = pink;
        hoodear2.transform.GetComponent<Renderer>().material = pink;
        dress1.transform.GetComponent<Renderer>().material = pink;
        dress2.transform.GetComponent<Renderer>().material = pink;
        dress3.transform.GetComponent<Renderer>().material = pink;
        leftarm.transform.GetComponent<Renderer>().material = pink;
        rightarm.transform.GetComponent<Renderer>().material = pink;
        leftleg.transform.GetComponent<Renderer>().material = pink;
        rightleg.transform.GetComponent<Renderer>().material = pink;
    }
    public void getskin2()
    {//할리퀸
        hood.transform.GetComponent<Renderer>().material = pink;
        hoodear1.transform.GetComponent<Renderer>().material = pink;
        hoodear2.transform.GetComponent<Renderer>().material = pink;
        dress1.transform.GetComponent<Renderer>().material = pink;
        dress2.transform.GetComponent<Renderer>().material = pink;
        dress3.transform.GetComponent<Renderer>().material = pink;
        leftarm.transform.GetComponent<Renderer>().material = pink;
        rightarm.transform.GetComponent<Renderer>().material = pink;
        leftleg.transform.GetComponent<Renderer>().material = pink;
        rightleg.transform.GetComponent<Renderer>().material = pink;
    }
}
