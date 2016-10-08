using UnityEngine;
using System.Collections;

public class setConfeito2 : MonoBehaviour
{
    public GameObject confeito;
    public GameObject gamemode;
    private int desu;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void confeitoDesu()
    {
        desu = gamemode.GetComponent<modeSelect>().gameMode;
        if(desu == 0)
        {
            for (int i = 0; i < 1; i++)
            {
                Vector3 point = new Vector3(Random.Range(-4.5f, 4.5f), 3f, Random.Range(-2.3f, 2.3f));

                Instantiate(confeito, point, transform.rotation);

                getConfeito.instance.numOfConfeito++;

            }
        }
    }
}
