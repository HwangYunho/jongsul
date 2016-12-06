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
    public Material champieA1, champieA2, champieA3, champieA4, champieA5, champieA6, champieA7, champieA8, champieA9, champieA10;
    public Material planeA1, planeA2, planeA3, planeA4, planeA5, planeA6, planeA7, planeA8, planeA9, planeA10;

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
            case 3:
                getskin3();
                break;
            case 4:
                getskin4();
                break;
            case 5:
                getskin5();
                break;
            case 6:
                getskin6();
                break;
            case 7:
                getskin7();
                break;
            case 8:
                getskin8();
                break;
            case 9:
                getskin9();
                break;
            case 10:
                getskin10();
                break;
            case 11:
                getskin11();
                break;
            case 12:
                getskin12();
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

    public void getskin3()
    {//할리퀸
        hood.transform.GetComponent<Renderer>().material = champieA1;
        hoodear1.transform.GetComponent<Renderer>().material = champieA1;
        hoodear2.transform.GetComponent<Renderer>().material = champieA1;
        dress1.transform.GetComponent<Renderer>().material = champieA1;
        dress2.transform.GetComponent<Renderer>().material = champieA1;
        dress3.transform.GetComponent<Renderer>().material = champieA1;
        leftarm.transform.GetComponent<Renderer>().material = champieA1;
        rightarm.transform.GetComponent<Renderer>().material = champieA1;
        leftleg.transform.GetComponent<Renderer>().material = champieA1;
        rightleg.transform.GetComponent<Renderer>().material = champieA1;
        plane1.transform.GetComponent<Renderer>().material = planeA1;
        plane2.transform.GetComponent<Renderer>().material = planeA1;
        plane3.transform.GetComponent<Renderer>().material = planeA1;
        plane4.transform.GetComponent<Renderer>().material = planeA1;
        plane5.transform.GetComponent<Renderer>().material = planeA1;
        plane6.transform.GetComponent<Renderer>().material = planeA1;
        plane7.transform.GetComponent<Renderer>().material = planeA1;
        plane8.transform.GetComponent<Renderer>().material = planeA1;
        plane9.transform.GetComponent<Renderer>().material = planeA1;

        GameManager.instance.skin = 3;
        currentSkin = 3;
    }

    public void getskin4()
    {//할리퀸
        hood.transform.GetComponent<Renderer>().material = champieA2;
        hoodear1.transform.GetComponent<Renderer>().material = champieA2;
        hoodear2.transform.GetComponent<Renderer>().material = champieA2;
        dress1.transform.GetComponent<Renderer>().material = champieA2;
        dress2.transform.GetComponent<Renderer>().material = champieA2;
        dress3.transform.GetComponent<Renderer>().material = champieA2;
        leftarm.transform.GetComponent<Renderer>().material = champieA2;
        rightarm.transform.GetComponent<Renderer>().material = champieA2;
        leftleg.transform.GetComponent<Renderer>().material = champieA2;
        rightleg.transform.GetComponent<Renderer>().material = champieA2;
        plane1.transform.GetComponent<Renderer>().material = planeA2;
        plane2.transform.GetComponent<Renderer>().material = planeA2;
        plane3.transform.GetComponent<Renderer>().material = planeA2;
        plane4.transform.GetComponent<Renderer>().material = planeA2;
        plane5.transform.GetComponent<Renderer>().material = planeA2;
        plane6.transform.GetComponent<Renderer>().material = planeA2;
        plane7.transform.GetComponent<Renderer>().material = planeA2;
        plane8.transform.GetComponent<Renderer>().material = planeA2;
        plane9.transform.GetComponent<Renderer>().material = planeA2;

        GameManager.instance.skin = 4;
        currentSkin = 4;
    }

    public void getskin5()
    {//할리퀸
        hood.transform.GetComponent<Renderer>().material = champieA3;
        hoodear1.transform.GetComponent<Renderer>().material = champieA3;
        hoodear2.transform.GetComponent<Renderer>().material = champieA3;
        dress1.transform.GetComponent<Renderer>().material = champieA3;
        dress2.transform.GetComponent<Renderer>().material = champieA3;
        dress3.transform.GetComponent<Renderer>().material = champieA3;
        leftarm.transform.GetComponent<Renderer>().material = champieA3;
        rightarm.transform.GetComponent<Renderer>().material = champieA3;
        leftleg.transform.GetComponent<Renderer>().material = champieA3;
        rightleg.transform.GetComponent<Renderer>().material = champieA3;
        plane1.transform.GetComponent<Renderer>().material = planeA3;
        plane2.transform.GetComponent<Renderer>().material = planeA3;
        plane3.transform.GetComponent<Renderer>().material = planeA3;
        plane4.transform.GetComponent<Renderer>().material = planeA3;
        plane5.transform.GetComponent<Renderer>().material = planeA3;
        plane6.transform.GetComponent<Renderer>().material = planeA3;
        plane7.transform.GetComponent<Renderer>().material = planeA3;
        plane8.transform.GetComponent<Renderer>().material = planeA3;
        plane9.transform.GetComponent<Renderer>().material = planeA3;
    
        GameManager.instance.skin = 5;
        currentSkin = 5;
    }

    public void getskin6()
    {//할리퀸
        hood.transform.GetComponent<Renderer>().material = champieA4;
        hoodear1.transform.GetComponent<Renderer>().material = champieA4;
        hoodear2.transform.GetComponent<Renderer>().material = champieA4;
        dress1.transform.GetComponent<Renderer>().material = champieA4;
        dress2.transform.GetComponent<Renderer>().material = champieA4;
        dress3.transform.GetComponent<Renderer>().material = champieA4;
        leftarm.transform.GetComponent<Renderer>().material = champieA4;
        rightarm.transform.GetComponent<Renderer>().material = champieA4;
        leftleg.transform.GetComponent<Renderer>().material = champieA4;
        rightleg.transform.GetComponent<Renderer>().material = champieA4;
        plane1.transform.GetComponent<Renderer>().material = planeA4;
        plane2.transform.GetComponent<Renderer>().material = planeA4;
        plane3.transform.GetComponent<Renderer>().material = planeA4;
        plane4.transform.GetComponent<Renderer>().material = planeA4;
        plane5.transform.GetComponent<Renderer>().material = planeA4;
        plane6.transform.GetComponent<Renderer>().material = planeA4;
        plane7.transform.GetComponent<Renderer>().material = planeA4;
        plane8.transform.GetComponent<Renderer>().material = planeA4;
        plane9.transform.GetComponent<Renderer>().material = planeA4;

        GameManager.instance.skin = 6;
        currentSkin = 6;
    }

    public void getskin7()
    {//할리퀸
        hood.transform.GetComponent<Renderer>().material = champieA5;
        hoodear1.transform.GetComponent<Renderer>().material = champieA5;
        hoodear2.transform.GetComponent<Renderer>().material = champieA5;
        dress1.transform.GetComponent<Renderer>().material = champieA5;
        dress2.transform.GetComponent<Renderer>().material = champieA5;
        dress3.transform.GetComponent<Renderer>().material = champieA5;
        leftarm.transform.GetComponent<Renderer>().material = champieA5;
        rightarm.transform.GetComponent<Renderer>().material = champieA5;
        leftleg.transform.GetComponent<Renderer>().material = champieA5;
        rightleg.transform.GetComponent<Renderer>().material = champieA5;
        plane1.transform.GetComponent<Renderer>().material = planeA5;
        plane2.transform.GetComponent<Renderer>().material = planeA5;
        plane3.transform.GetComponent<Renderer>().material = planeA5;
        plane4.transform.GetComponent<Renderer>().material = planeA5;
        plane5.transform.GetComponent<Renderer>().material = planeA5;
        plane6.transform.GetComponent<Renderer>().material = planeA5;
        plane7.transform.GetComponent<Renderer>().material = planeA5;
        plane8.transform.GetComponent<Renderer>().material = planeA5;
        plane9.transform.GetComponent<Renderer>().material = planeA5;

        GameManager.instance.skin = 7;
        currentSkin = 7;
    }

    public void getskin8()
    {//할리퀸
        hood.transform.GetComponent<Renderer>().material = champieA6;
        hoodear1.transform.GetComponent<Renderer>().material = champieA6;
        hoodear2.transform.GetComponent<Renderer>().material = champieA6;
        dress1.transform.GetComponent<Renderer>().material = champieA6;
        dress2.transform.GetComponent<Renderer>().material = champieA6;
        dress3.transform.GetComponent<Renderer>().material = champieA6;
        leftarm.transform.GetComponent<Renderer>().material = champieA6;
        rightarm.transform.GetComponent<Renderer>().material = champieA6;
        leftleg.transform.GetComponent<Renderer>().material = champieA6;
        rightleg.transform.GetComponent<Renderer>().material = champieA6;
        plane1.transform.GetComponent<Renderer>().material = planeA6;
        plane2.transform.GetComponent<Renderer>().material = planeA6;
        plane3.transform.GetComponent<Renderer>().material = planeA6;
        plane4.transform.GetComponent<Renderer>().material = planeA6;
        plane5.transform.GetComponent<Renderer>().material = planeA6;
        plane6.transform.GetComponent<Renderer>().material = planeA6;
        plane7.transform.GetComponent<Renderer>().material = planeA6;
        plane8.transform.GetComponent<Renderer>().material = planeA6;
        plane9.transform.GetComponent<Renderer>().material = planeA6;

        GameManager.instance.skin = 8;
        currentSkin = 8;
    }

    public void getskin9()
    {//할리퀸
        hood.transform.GetComponent<Renderer>().material = champieA7;
        hoodear1.transform.GetComponent<Renderer>().material = champieA7;
        hoodear2.transform.GetComponent<Renderer>().material = champieA7;
        dress1.transform.GetComponent<Renderer>().material = champieA7;
        dress2.transform.GetComponent<Renderer>().material = champieA7;
        dress3.transform.GetComponent<Renderer>().material = champieA7;
        leftarm.transform.GetComponent<Renderer>().material = champieA7;
        rightarm.transform.GetComponent<Renderer>().material = champieA7;
        leftleg.transform.GetComponent<Renderer>().material = champieA7;
        rightleg.transform.GetComponent<Renderer>().material = champieA7;
        plane1.transform.GetComponent<Renderer>().material = planeA7;
        plane2.transform.GetComponent<Renderer>().material = planeA7;
        plane3.transform.GetComponent<Renderer>().material = planeA7;
        plane4.transform.GetComponent<Renderer>().material = planeA7;
        plane5.transform.GetComponent<Renderer>().material = planeA7;
        plane6.transform.GetComponent<Renderer>().material = planeA7;
        plane7.transform.GetComponent<Renderer>().material = planeA7;
        plane8.transform.GetComponent<Renderer>().material = planeA7;
        plane9.transform.GetComponent<Renderer>().material = planeA7;

        GameManager.instance.skin = 9;
        currentSkin = 9;
    }

    public void getskin10()
    {//할리퀸
        hood.transform.GetComponent<Renderer>().material = champieA8;
        hoodear1.transform.GetComponent<Renderer>().material = champieA8;
        hoodear2.transform.GetComponent<Renderer>().material = champieA8;
        dress1.transform.GetComponent<Renderer>().material = champieA8;
        dress2.transform.GetComponent<Renderer>().material = champieA8;
        dress3.transform.GetComponent<Renderer>().material = champieA8;
        leftarm.transform.GetComponent<Renderer>().material = champieA8;
        rightarm.transform.GetComponent<Renderer>().material = champieA8;
        leftleg.transform.GetComponent<Renderer>().material = champieA8;
        rightleg.transform.GetComponent<Renderer>().material = champieA8;
        plane1.transform.GetComponent<Renderer>().material = planeA8;
        plane2.transform.GetComponent<Renderer>().material = planeA8;
        plane3.transform.GetComponent<Renderer>().material = planeA8;
        plane4.transform.GetComponent<Renderer>().material = planeA8;
        plane5.transform.GetComponent<Renderer>().material = planeA8;
        plane6.transform.GetComponent<Renderer>().material = planeA8;
        plane7.transform.GetComponent<Renderer>().material = planeA8;
        plane8.transform.GetComponent<Renderer>().material = planeA8;
        plane9.transform.GetComponent<Renderer>().material = planeA8;

        GameManager.instance.skin = 10;
        currentSkin = 10;
    }

    public void getskin11()
    {//할리퀸
        hood.transform.GetComponent<Renderer>().material = champieA9;
        hoodear1.transform.GetComponent<Renderer>().material = champieA9;
        hoodear2.transform.GetComponent<Renderer>().material = champieA9;
        dress1.transform.GetComponent<Renderer>().material = champieA9;
        dress2.transform.GetComponent<Renderer>().material = champieA9;
        dress3.transform.GetComponent<Renderer>().material = champieA9;
        leftarm.transform.GetComponent<Renderer>().material = champieA9;
        rightarm.transform.GetComponent<Renderer>().material = champieA9;
        leftleg.transform.GetComponent<Renderer>().material = champieA9;
        rightleg.transform.GetComponent<Renderer>().material = champieA9;
        plane1.transform.GetComponent<Renderer>().material = planeA9;
        plane2.transform.GetComponent<Renderer>().material = planeA9;
        plane3.transform.GetComponent<Renderer>().material = planeA9;
        plane4.transform.GetComponent<Renderer>().material = planeA9;
        plane5.transform.GetComponent<Renderer>().material = planeA9;
        plane6.transform.GetComponent<Renderer>().material = planeA9;
        plane7.transform.GetComponent<Renderer>().material = planeA9;
        plane8.transform.GetComponent<Renderer>().material = planeA9;
        plane9.transform.GetComponent<Renderer>().material = planeA9;

        GameManager.instance.skin = 11;
        currentSkin = 11;
    }

    public void getskin12()
    {//할리퀸
        hood.transform.GetComponent<Renderer>().material = champieA10;
        hoodear1.transform.GetComponent<Renderer>().material = champieA10;
        hoodear2.transform.GetComponent<Renderer>().material = champieA10;
        dress1.transform.GetComponent<Renderer>().material = champieA10;
        dress2.transform.GetComponent<Renderer>().material = champieA10;
        dress3.transform.GetComponent<Renderer>().material = champieA10;
        leftarm.transform.GetComponent<Renderer>().material = champieA10;
        rightarm.transform.GetComponent<Renderer>().material = champieA10;
        leftleg.transform.GetComponent<Renderer>().material = champieA10;
        rightleg.transform.GetComponent<Renderer>().material = champieA10;
        plane1.transform.GetComponent<Renderer>().material = planeA10;
        plane2.transform.GetComponent<Renderer>().material = planeA10;
        plane3.transform.GetComponent<Renderer>().material = planeA10;
        plane4.transform.GetComponent<Renderer>().material = planeA10;
        plane5.transform.GetComponent<Renderer>().material = planeA10;
        plane6.transform.GetComponent<Renderer>().material = planeA10;
        plane7.transform.GetComponent<Renderer>().material = planeA10;
        plane8.transform.GetComponent<Renderer>().material = planeA10;
        plane9.transform.GetComponent<Renderer>().material = planeA10;

        GameManager.instance.skin = 12;
        currentSkin = 12;
    }
}
