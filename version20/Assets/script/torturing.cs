using UnityEngine;
using System.Collections;
[RequireComponent(typeof(BoxCollider))]	//or other collider
public class torturing : MonoBehaviour {

    private bool onOff = false;
    private bool uncheck = true;
    public GameObject champi;
    public GameObject gamemode;

    public GameObject hitParticle;

    private int desu;

    void Start()
    {

    }


    void Update()
    {   // Update is called once per frame
        desu = gamemode.GetComponent<modeSelect>().gameMode;
        if (onOff && desu == 1)
        {
            onOff = false;
            Instantiate(hitParticle, this.transform.position + new Vector3(0,1f,0), this.transform.rotation);
            champi.GetComponent<getConfeito>().HitInDesu();
            gamemode.GetComponent<GameManager>().HealthMinus(1);
			gamemode.GetComponent<GameManager> ().cocky++;

			if (gamemode.GetComponent<setConfeito2> ().numberOfConfeCan <= 20) {
				gamemode.GetComponent<setConfeito2> ().numberOfConfeCan += 5;

			}

	    }
    }

    void OnMouseDown()
    {
        if (!onOff&&desu==1 && !champi.GetComponent<getConfeito>().ruhit && champi.GetComponent<getConfeito>().cooltime < 0)
            onOff = true;
    }
}
