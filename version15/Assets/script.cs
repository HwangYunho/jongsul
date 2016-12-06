using UnityEngine;
using System.Collections;

public class script : MonoBehaviour {
    public TextMesh text;

    public int nowHealth;

    public void SetScriptTort(int health)
    {
        nowHealth = health;
    }
    public void SetScriptHeal(int health)
    {
        nowHealth = health;
    }
}
