using UnityEngine;
using System.Collections;

public class CloseManager : MonoBehaviour {

    public Transform closeMenu;
    public bool b = true;

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Exitmenu(b);
        }
    }

    public void Exitmenu(bool a)
    {
        closeMenu.gameObject.SetActive(a);
        b = !a;
        
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
