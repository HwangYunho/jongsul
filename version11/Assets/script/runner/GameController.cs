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

    public AudioClip gameoversound; //hyh


    public void Update ()
	{
		// 스코어 레이블을 업데이트
		int score = CalcScore();
		scoreLabel.text = "Score : " + score + "m";
		
		// 라이프 패널을 업데이트
		lifePanel.UpdateLife(player.Life());

		if (player.Life () <= 0) {
            AudioSource.PlayClipAtPoint(gameoversound, transform.position);//hyh
                                          
            //이 이후의 업데이트는 멈춘다
            enabled = false;
            if (PlayerPrefs.GetInt ("HighScore") < score) {
				PlayerPrefs.SetInt ("HighScore", score);
			}

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
