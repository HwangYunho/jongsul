using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public float hungerTimer = 10;

    private int level;

    public int[] inven = new int[32];

    public int point;


    public string name;

    public Transform statMenu, mainMenu, shopMenu, invenMenu, deadMenu;

    private bool a = true, b=true;



    public int health, hunger, closeness, cocky, skin;
    public static GameManager instance;

    public bool Dokra;

    public GameObject champi;
    public TextMesh hello;

    public Text healthText, hungerText, closenessText, cockyText, nameText, DokraText, UjiText;
    public Text pointText, pointTextInven;

    //public item i = itemDB.itemlist[0];


    // Use this for initialization
    void Start()
    {
        hungerTimer = 10;
        Dokra = false;
        instance = this;
        health = 70;
        hunger = 50;
        closeness = 50;
        cocky = 50;
        point = 1000;
        skin = 0;
        level = PlayerPrefs.GetInt("Level");
        name = PlayerPrefs.GetString("Name");

        

        if (level == 1)
        {
            PlayerPrefs.SetInt("Health", health);
            PlayerPrefs.SetInt("Hunger", hunger);
            PlayerPrefs.SetInt("Close", closeness);
            PlayerPrefs.SetInt("Cock", cocky);
            PlayerPrefs.SetInt("Point", point);
            PlayerPrefs.SetInt("Skin", skin);
            for (int i = 0; i < 32; i++)
            {
                PlayerPrefs.SetInt("Inven" + i.ToString(), inven[i]);
            }
        }
        else
        {
            health = PlayerPrefs.GetInt("Health");
            hunger = PlayerPrefs.GetInt("Hunger");
            closeness = PlayerPrefs.GetInt("Close");
            cocky = PlayerPrefs.GetInt("Cock");
            point = PlayerPrefs.GetInt("Point");


            skin = PlayerPrefs.GetInt("Skin");
            SkinSelector.instance.currentSkin = skin;
            GetComponent<SkinSelector>().selectSkin();

            for (int i = 0; i < 32; i++)
            {
                inven[i] = PlayerPrefs.GetInt("Inven" + i.ToString());
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (health < 65)
        {
            champi.GetComponent<getConfeito>().DokraInDesu();
            Dokra = true;
        }
        if (health < 1)
        {
            showdead();
            champi.GetComponent<getConfeito>().pakin();
        }
        hello.text = health.ToString();

        

        Save();
        SetStatText();
    }

    public void HealthMinus(int a)
    {
        health -= a;
        if (health < 0)
        {
            health = 0;
        }
    }
    public void HealthPlus(int a)
    {
        health += a;
        if (health > 100)
        {
            health = 100;
        }
    }

    public void Save()
    {
        PlayerPrefs.SetInt("Health", health);
        PlayerPrefs.SetInt("Hunger", hunger);
        PlayerPrefs.SetInt("Close", closeness);
        PlayerPrefs.SetInt("Cock", cocky);
        PlayerPrefs.SetInt("Point", point);
        PlayerPrefs.SetInt("Skin", skin);
        for (int i=0;i<3;i++)
        {
            PlayerPrefs.SetInt("Inven" + i.ToString(), inven[i]);
        }
    }

    public void SetStatText()
    {
        //healthText, hungerText, closenessText, cockyText, nameText, DokraText, UjiText;
        nameText.text = name.ToString();
        healthText.text = health.ToString();
        hungerText.text = hunger.ToString();
        closenessText.text = closeness.ToString();
        cockyText.text = cocky.ToString();
        DokraText.text = Dokra.ToString();
        pointText.text = point.ToString();
        pointTextInven.text = point.ToString();
        //UjiText.text = name.ToString();
    }

    public void statmenu()
    {
        statMenu.gameObject.SetActive(a);
        a = !a;
    }
    public void mainmenu()
    {
        mainMenu.gameObject.SetActive(b);
        b = !b;
    }
    public void mainmenuClose()
    {
        b = false;
        mainMenu.gameObject.SetActive(b);
        b = !b;
    }
    public void shopmenu(bool c)
    {
        shopMenu.gameObject.SetActive(c);
    }
    public void invenmenu(bool c)
    {
        invenMenu.gameObject.SetActive(c);
    }

    public void showdead()
    {
        deadMenu.gameObject.SetActive(true);
    }

    public void ending()
    {
        PlayerPrefs.DeleteKey("Name");
        Application.LoadLevel(0);
    }
}
