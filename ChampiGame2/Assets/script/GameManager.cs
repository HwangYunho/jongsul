using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Timers; //여기 안에 타이머가 있다

public class GameManager : MonoBehaviour
{
	public float hungerTimer = 10;

	private int level;

	//ssc
	private float TimeLeft = 10.0f;
	private float nextTime = 0.0f;
	public GameObject uji;
	public int numOfUjicha;
	public GameObject effectPrefab;
	public Vector3 effectRotation;
	private bool effectFlag = false;
	private GameObject effectInstance; 
	private float tt;
	public int[] inven = new int[32];

	public int point;

	public Transform statMenu, mainMenu, shopMenu, invenMenu, deadMenu;

	private bool a = true, b = true;

	public string name;

	public int health, hunger, closeness, cocky, skin, count;
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
		health = 65;
		hunger = 50;
		closeness = 50;
		cocky = 50;
		point = 1000;
		skin = 0;
		level = PlayerPrefs.GetInt("Level");
		name = PlayerPrefs.GetString("Name");

		//ssc
		count = 0;
		numOfUjicha = 1;
	
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

		//ssc
		if (health == 100) {
			GameObject ujija = (GameObject)Instantiate (
				uji,
				champi.transform.position,
				Quaternion.identity
			);

			health = 1;
			hunger = 99;
			numOfUjicha++;
		}
		else if (health >= 65)
		{
			champi.GetComponent<getConfeito>().speed = 2;
			champi.GetComponent<getConfeito>().DokraOffDesu();
			Dokra = false;

			if (effectFlag) {
				effectFlag = false;
				Destroy (effectInstance);	
			}
		}

		//ssc
		else if (health < 65)
		{
			champi.GetComponent<getConfeito>().DokraInDesu();
			Dokra = true;

			if (health < 65 && health >=30)
				champi.GetComponent<getConfeito> ().speed = 4;
			else if (health < 30) {
				champi.GetComponent<getConfeito> ().speed =7;
			}

			if (effectPrefab != null && !effectFlag) {
				Vector3 effect_pos = champi.transform.position;
				effect_pos.y += 1.5f;

				effectInstance = (GameObject) Instantiate (
					effectPrefab,
					effect_pos,
					Quaternion.Euler(effectRotation)
				);

				effectInstance.transform.parent = champi.transform;
				effectFlag = true;
			}
		}

		else if (health < 1)
		{
			showdead();
			champi.GetComponent<getConfeito>().pakin();
		}

		hello.text = health.ToString();

		//ssc
		if (health < 65)
		{
			if (Time.time > nextTime)
			{
				nextTime = Time.time + TimeLeft;
				if (closeness > 0)
				{
					closeness--;
					count++;
				}
				if(count%3 == 0 && health>0)
				{
					health--;
					count = 0;
				}
			}
		}

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

		for (int i = 0; i < 3; i++)
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

		//ssc
		UjiText.text = numOfUjicha.ToString();
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