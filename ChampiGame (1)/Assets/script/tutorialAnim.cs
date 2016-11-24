using UnityEngine;
using System.Collections;

public class tutorialAnim : MonoBehaviour {
    public Transform menu;

	public void endAnim()
    {
        menu.gameObject.SetActive(true);
    }
}
