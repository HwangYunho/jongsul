using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{
    public Transform LoadMenu;
    public Transform ask;

    // Use this for initialization
    void Start()
    {
        if (!PlayerPrefs.HasKey("Name"))
        {
            LoadMenu.gameObject.SetActive(false);
        }
    }

	public void NewGame()
    {
        PlayerPrefs.SetInt("Level", 1);
        if (PlayerPrefs.HasKey("Name"))
        {
            ask.gameObject.SetActive(true);
        }
        else
        {
            Application.LoadLevel(1);
        }
    }

    public void loadGame()
    {
        PlayerPrefs.SetInt("Level", 2);
        Application.LoadLevel(2);
    }

    public void ExitGame()
    {
    }

    public void askOK()
    {
        Application.LoadLevel(1);
    }
    public void askNOK()
    {
        ask.gameObject.SetActive(false);
    }
}
