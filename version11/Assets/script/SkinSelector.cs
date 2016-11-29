using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SkinSelector : MonoBehaviour {

    public static SkinSelector instance;

    public int currentSkin;
    public Transform popup;
    public Text nameText;

    public GameObject hood, hoodear1, hoodear2, dress1, dress2, dress3, leftarm, rightarm, leftleg, rightleg;

    public Material midori, pink;

    public Material hollyred, hollyblue,hollywhite, hollyhair;
    public GameObject plane1, plane2, plane3, plane4, plane5, plane6, plane7, plane8, plane9;
    public Material space, desert, candy;

    // Use this for initialization
    void Start () {
        instance = this;
        currentSkin = 0;
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
                getskin2();
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
        plane1.transform.GetComponent<Renderer>().material = space;
        plane2.transform.GetComponent<Renderer>().material = space;
        plane3.transform.GetComponent<Renderer>().material = space;
        plane4.transform.GetComponent<Renderer>().material = space;
        plane5.transform.GetComponent<Renderer>().material = space;
        plane6.transform.GetComponent<Renderer>().material = space;
        plane7.transform.GetComponent<Renderer>().material = space;
        plane8.transform.GetComponent<Renderer>().material = space;
        plane9.transform.GetComponent<Renderer>().material = space;
        GameManager.instance.skin = 0;
        currentSkin = 0;
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
        plane1.transform.GetComponent<Renderer>().material = desert;
        plane2.transform.GetComponent<Renderer>().material = desert;
        plane3.transform.GetComponent<Renderer>().material = desert;
        plane4.transform.GetComponent<Renderer>().material = desert;
        plane5.transform.GetComponent<Renderer>().material = desert;
        plane6.transform.GetComponent<Renderer>().material = desert;
        plane7.transform.GetComponent<Renderer>().material = desert;
        plane8.transform.GetComponent<Renderer>().material = desert;
        plane9.transform.GetComponent<Renderer>().material = desert;
        GameManager.instance.skin = 1;
        currentSkin = 1;
    }
    public void getskin2()
    {//할리퀸
        hood.transform.GetComponent<Renderer>().material = hollyhair;
        hoodear1.transform.GetComponent<Renderer>().material = hollyblue;
        hoodear2.transform.GetComponent<Renderer>().material = hollyred;
        dress1.transform.GetComponent<Renderer>().material = hollyred;
        dress2.transform.GetComponent<Renderer>().material = hollywhite;
        dress3.transform.GetComponent<Renderer>().material = hollywhite;
        leftarm.transform.GetComponent<Renderer>().material = hollyblue;
        rightarm.transform.GetComponent<Renderer>().material = hollyred;
        leftleg.transform.GetComponent<Renderer>().material = hollyred;
        rightleg.transform.GetComponent<Renderer>().material = hollyblue;
        plane1.transform.GetComponent<Renderer>().material = candy;
        plane2.transform.GetComponent<Renderer>().material = candy;
        plane3.transform.GetComponent<Renderer>().material = candy;
        plane4.transform.GetComponent<Renderer>().material = candy;
        plane5.transform.GetComponent<Renderer>().material = candy;
        plane6.transform.GetComponent<Renderer>().material = candy;
        plane7.transform.GetComponent<Renderer>().material = candy;
        plane8.transform.GetComponent<Renderer>().material = candy;
        plane9.transform.GetComponent<Renderer>().material = candy;

        GameManager.instance.skin = 2;
        currentSkin = 2;
    }
}
