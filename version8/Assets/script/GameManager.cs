using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
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
	private GameObject ujija_ins;
	private GameObject ujija;
	private int ii;

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

    //hyh
    public GameObject eatwarn;
    public GameObject ujiwarn;
    private float eatWarnC = 0.0f;
    public AudioClip stagechangesound;

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
        eatwarn.SetActive(false); //hyh
 
		//ssc
        count = 0;
		numOfUjicha = 0;
		ii = 0;

		if (level == 1)
		{
			PlayerPrefs.SetInt("Health", health);
			PlayerPrefs.SetInt("Hunger", hunger);
			PlayerPrefs.SetInt("Close", closeness);
			PlayerPrefs.SetInt("Cock", cocky);
			PlayerPrefs.SetInt("Point", point);
			PlayerPrefs.SetInt("Skin", skin);

			//ssc
			PlayerPrefs.SetInt("numOfUjicha",numOfUjicha);

			for (int i = 0; i < 32; i++)
			{
				PlayerPrefs.SetInt("Inven" + i.ToString(), inven[i]);
			}
		}
		else if(level ==2)
		{
			health = PlayerPrefs.GetInt("Health");
			hunger = PlayerPrefs.GetInt("Hunger");
			closeness = PlayerPrefs.GetInt("Close");
			cocky = PlayerPrefs.GetInt("Cock");
			point = PlayerPrefs.GetInt("Point");
			skin = PlayerPrefs.GetInt("Skin");
			SkinSelector.instance.currentSkin = skin;
			GetComponent<SkinSelector>().selectSkin();

			//ssc
			numOfUjicha = PlayerPrefs.GetInt("numOfUjicha");

			for (int i = 0; i < 32; i++)
			{
				inven[i] = PlayerPrefs.GetInt("Inven" + i.ToString());
			}
		}

		//ssc
		else if(level ==3)
		{
			health = PlayerPrefs.GetInt("Health");
			hunger = PlayerPrefs.GetInt("Hunger");
			closeness = PlayerPrefs.GetInt("Close");
			cocky = PlayerPrefs.GetInt("Cock");
			point = PlayerPrefs.GetInt("Point");
			skin = PlayerPrefs.GetInt("Skin");
			SkinSelector.instance.currentSkin = skin;
			GetComponent<SkinSelector> ().selectSkin ();
			numOfUjicha = PlayerPrefs.GetInt("numOfUjicha");

			for (int i = 0; i < numOfUjicha; i++) {
				Instantiate (
					uji,
					champi.transform.position,
					Quaternion.identity
				);
			}
		
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
			ujija = (GameObject)Instantiate (
				uji,
				champi.transform.position,
				Quaternion.identity
			);
			ujija.name = ii++.ToString()+"child";

			//add for birth
			ujija_ins = (GameObject)Instantiate (
				ujiwarn,
				ujija.transform.position,
				Quaternion.identity
			);
			StartCoroutine (TextForChild ());
            
			health = 1;
			hunger = 99;
			numOfUjicha++;
			if (numOfUjicha >= 2) {
				Save ();
				SetStatText ();
				Invoke ("StartRunner", 3.0f);
			}
		}

		else if (health >= 65)
		{
			champi.GetComponent<getConfeito>().speed = 4;
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

            if (eatWarnC < 3.0f)
            {
                eatwarn.SetActive(true);
                eatWarnC += Time.deltaTime;
            }
            else
            {
                eatwarn.SetActive(false);
                eatWarnC += Time.deltaTime;
                if (eatWarnC >= 6.0f)
                    eatWarnC = 0.0f;
            }
				
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

	//ssc
	IEnumerator TextForChild(){
		ujija_ins.transform.parent = ujija.transform.FindChild("ujichaController").transform;
		ujija_ins.SetActive (true);
		yield return new WaitForSeconds (1.5f);
		ujija_ins.SetActive (false);
	}

	//ssc
	public void StartRunner(){
        AudioSource.PlayClipAtPoint(stagechangesound, transform.position);//hyh
        Application.LoadLevel ("runner");
		//SceneManager.LoadScene ("runner");
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

		//ssc
		PlayerPrefs.SetInt("numOfUjicha",numOfUjicha);
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