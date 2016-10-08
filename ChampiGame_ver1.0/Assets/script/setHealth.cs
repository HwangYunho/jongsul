using UnityEngine;
using System.Collections;

public class setHealth : MonoBehaviour {

    public int health;
    public static setHealth instance;

    public GameObject champi, GameManager;
    public TextMesh hello;

    // Use this for initialization
    void Start ()
    {
        instance = this;
        health = 70;

    }
	
	// Update is called once per frame
	void Update () {
        if (health < 65)
        {
            champi.GetComponent<getConfeito>().DokraInDesu();
        }
        hello.text = health.ToString();
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
}
