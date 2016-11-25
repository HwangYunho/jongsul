using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class item : MonoBehaviour {

    public string name;
    public int itemnum;
    public int cost;
    public bool cancount;
    public enum Type {skin, confe, torture};
    public Type type;

    public Sprite sprite;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
