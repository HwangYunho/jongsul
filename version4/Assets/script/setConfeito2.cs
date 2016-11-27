using UnityEngine;
using System.Collections;
using System.Timers;

public class setConfeito2 : MonoBehaviour
{
    public GameObject confeito;
    public GameObject gamemode;
    public GameObject champigame;
    private int desu;

	//ssc
	private float TimeLeft = 10.0f;
	private float nextTime = 0.0f;
	int count;

	//ssc
	void Start () {
		count = 0;
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

				//ssc
				if (champigame.GetComponent<GameManager> ().hunger > 0) {
					champigame.GetComponent<GameManager> ().hunger--;
					count++;

					if(count%6 == 0 && champigame.GetComponent<GameManager>().closeness<=95)
					{
						champigame.GetComponent<GameManager> ().closeness++;
						count = 0;
					}
				}
			}
        }
    }
}
