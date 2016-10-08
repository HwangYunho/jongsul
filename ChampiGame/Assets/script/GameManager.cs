using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    private int level;

    public int point;


    public string name;

    public Transform statMenu, mainMenu, shopMenu;

    private bool a = true, b=true;



    public int health, hunger, closeness, cocky;
    public static GameManager instance;

    public bool Dokra;

    public GameObject champi;
    public TextMesh hello;

    public Text healthText, hungerText, closenessText, cockyText, nameText, DokraText, UjiText;
    public Text pointText;

    public item i = itemDB.itemlist[0];


    // Use this for initialization
    void Start()
    {
        Dokra = false;
        instance = this;
        health = 70;
        hunger = 50;
        closeness = 50;
        cocky = 50;
        point = 1000;
        level = PlayerPrefs.GetInt("Level");
        name = PlayerPrefs.GetString("Name");

        Debug.Log(health);

        if (level == 1)
        {
            PlayerPrefs.SetInt("Health", health);
            PlayerPrefs.SetInt("Hunger", hunger);
            PlayerPrefs.SetInt("Close", closeness);
            PlayerPrefs.SetInt("Cock", cocky);
            PlayerPrefs.SetInt("Point", point);
        }
        else
        {
            health = PlayerPrefs.GetInt("Health");
            hunger = PlayerPrefs.GetInt("Hunger");
            closeness = PlayerPrefs.GetInt("Close");
            cocky = PlayerPrefs.GetInt("Cock");
            point = PlayerPrefs.GetInt("Point");
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
        hello.text = health.ToString();

        Debug.Log(itemDB.itemlist[0].name);

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
    public void shopmenu(bool c)
    {
        shopMenu.gameObject.SetActive(c);
    }
}
