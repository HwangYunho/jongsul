using UnityEngine;
using System.Collections;

public class modeSelect : MonoBehaviour {

    public int gameMode;
    public bool floorMode;
    public bool HideMode;

    public Transform confeButton;
    public Transform torturButton;

    public Transform wall;
    public GameObject imagetarget;
    public GameObject gametarget;

    //public Transform temp;

    // Use this for initialization
    void Start () {
        gameMode = 0;
        floorMode = true;
        HideMode = true;
        //temp.gameObject.transform.position = gametarget.gameObject.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void TortureMode(bool clicked)
    {
        if (clicked == true)
        {
            torturButton.gameObject.SetActive(clicked);
            confeButton.gameObject.SetActive(false);
            gameMode = 1;
        }
    }

    public void ConfeMode(bool clicked)
    {
        if (clicked == true)
        {
            confeButton.gameObject.SetActive(clicked);
            torturButton.gameObject.SetActive(false);
            gameMode = 0;
        }
    }

    public void turnGame()
    {
        if (floorMode == true)
        {
            floorMode = false;
            imagetarget.transform.position = new Vector3(0, -0.41f, 0);
            imagetarget.transform.rotation = Quaternion.Euler(0,0,0);

            gametarget.transform.position = new Vector3(0f, 0f, 0f);
            gametarget.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            floorMode = true;
            imagetarget.transform.position = new Vector3(0.04f, 2.72f, 4.7f);
            imagetarget.transform.rotation = Quaternion.Euler(270,0,0);

            gametarget.transform.position = new Vector3(0f, 0.00100014f, 0f);
            gametarget.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    public void HideWall()
    {
        if (HideMode == true)
        {
            HideMode = false;
            wall.gameObject.SetActive(HideMode);

        }
        else
        {
            HideMode = true;
            wall.gameObject.SetActive(HideMode);
        }
    }
}
