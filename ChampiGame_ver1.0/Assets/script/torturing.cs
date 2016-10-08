using UnityEngine;
using System.Collections;
[RequireComponent(typeof(BoxCollider))]	//or other collider
public class torturing : MonoBehaviour {

    private bool onOff = false;
    private bool uncheck = true;
    public GameObject champi;
    public GameObject gamemode;
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
            gamemode.GetComponent<GameManager>().HealthMinus(1);
        }
    }

    void OnMouseDown()
    {
        if (!onOff&&desu==1)
            onOff = true;
    }
}
