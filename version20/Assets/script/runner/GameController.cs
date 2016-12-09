using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

//ssc
public class GameController : MonoBehaviour 
{
	public PlayerController2 player;
	public Text scoreLabel;
	public Text exitLabel;
	public LifePanel lifePanel;
	bool score_set_once;

    public AudioClip gameoversound; //hyh

	void Start (){
		score_set_once = false;
		if (PlayerPrefs.GetInt ("Level") == 1) {
			PlayerPrefs.SetInt ("HighScore", 0);
		} 
	}

    public void Update ()
	{
		// 스코어 레이블을 업데이트
		int score = CalcScore();

		scoreLabel.text = "Score : " + score + "m";

		// whenever score is increased more, the speed for character will be faster ! 
		if (score >= 200 && score <= 400 && score_set_once == false) {
			player.speedZ += 3;
			score_set_once = true;
		} else if (score > 400 && score <= 700 && score_set_once == true) {
			player.speedZ += 2;
			score_set_once = false;
		} else if (score > 700 && score <= 1100 && score_set_once == false) {
			player.speedZ += 2;
			score_set_once = true;
		} else if (score > 1100 && score <= 1500 && score_set_once ==true) {
			player.speedZ += 1;
			score_set_once = false;
		}

		// 라이프 패널을 업데이트
		lifePanel.UpdateLife(player.Life());

		if (player.Life () <= 0) {
            AudioSource.PlayClipAtPoint(gameoversound, transform.position);//hyh
                                          
            //이 이후의 업데이트는 멈춘다
            enabled = false;
            if (PlayerPrefs.GetInt ("HighScore") < score) {
				PlayerPrefs.SetInt ("HighScore", score);
			}

			int point = PlayerPrefs.GetInt ("Point");
			PlayerPrefs.SetInt ("Point", score/10+point);
			exitLabel.text = "Cheer up ! Let's go home";
            //after 2second call ReturnToTitle function
            Invoke ("ReturnToTitle", 1.5f);
		}
	}
	
	int CalcScore ()
	{
		return (int)player.transform.position.z;
	}
		
	void ReturnToTitle(){

		PlayerPrefs.SetInt("Level", 3);
		//Application.LoadLevel(2);

        Application.LoadLevel ("game");
        //SceneManager.LoadScene ("game");
	}
   
}
