using UnityEngine;
using System.Collections;
using System.Timers;
using UnityEngine.UI;

public class setConfeito2 : MonoBehaviour
{
    public GameObject confeito;
    public GameObject gamemode;
    public GameObject champigame;
    private int desu;

	//ssc
	const int DefaultAmount = 10;
	const int RecoverySeconds = 60;
	// 현재의 사탕 투척 기회 수
	int confe = DefaultAmount;
	// 투척할 수 있도록 회복될 때까지의 남은 시간(초)
	int counter;
	int count=0;
	int kk;
	bool outofconfeCondition=false;
	public GameObject waitingLabel;

	//ssc
	void Start(){
		kk = 0;
	}

    public void confeitoDesu()
    {
        desu = gamemode.GetComponent<modeSelect>().gameMode;

		//ssc
		//eating mode
		if (kk < 10) {	
			if (desu == 0) {
				waitingLabel.GetComponent<TextMesh>().text="";
				for (int i = 0; i < 1; i++) {
					Vector3 point = new Vector3 (Random.Range (-4.5f, 4.5f), 3f, Random.Range (-2.3f, 2.3f));

					Instantiate (confeito, point, transform.rotation);

					getConfeito.instance.numOfConfeito++;

					//ssc
					if (champigame.GetComponent<GameManager> ().hunger > 0) {
						champigame.GetComponent<GameManager> ().hunger--;
						count++;

						if (count % 6 == 0 && champigame.GetComponent<GameManager> ().closeness <= 95) {
							champigame.GetComponent<GameManager> ().closeness++;
							count = 0;
						}
					}
				}
			}
			kk++;
			outofconfeCondition = true;

		//ssc
		} else if(kk>=10 && outofconfeCondition) {
			outofconfeCondition =false; //hurry to off kk!
			waitingLabel.GetComponent<TextMesh>().text="?";
			Invoke ("waiting", 1);
		}
	}

	//ssc. rocket mode
	/*
		if (desu == 2) {

		}
	*/

	//ssc
	void waiting(){
		kk = 0;
	}
		
}
