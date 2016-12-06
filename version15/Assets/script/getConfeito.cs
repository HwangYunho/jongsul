using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class getConfeito : MonoBehaviour
{
	public Animator Anim;
	public float cooltime = 1;
	public bool ruhit = false;
	public bool rudead = false;

	public int numOfConfeito = 0;
	public float speed = 0.5f;

	public static getConfeito instance;

	public Vector3 target;

	public TextMesh hello;

	private Transform tmpposy;

	// Use this for initialization
	void Start () {
		instance = this;
		//hello.text = null;
	}

	// Update is called once per frame
	void Update () {
		cooltime -= Time.deltaTime;
		/*if (Input.GetButtonDown("Fire2"))
        {
            this.transform.position = getNearist().transform.position;
        }*/
		if (numOfConfeito > 0 && !ruhit && !rudead)
		{
			target = getNearist().transform.position;
			target.y = transform.position.y;
			this.transform.LookAt(target);
			Anim.SetBool("w", true);
			this.transform.position += (target - this.transform.position).normalized * speed * Time.deltaTime;
		}
		else
		{
			Anim.SetBool("w", false);
		}
		this.transform.position = new Vector3(this.transform.position.x,0f, this.transform.position.z);
	}

	GameObject getNearist()
	{
		GameObject Nearist = null;
		foreach (GameObject con in GameObject.FindGameObjectsWithTag("con"))
		{
			if (Nearist == null || Vector3.Distance(transform.position, con.transform.position) < Vector3.Distance(transform.position, Nearist.transform.position))
			{
				Nearist = con;
			}
		}
		return Nearist;
	}

	public void DokraInDesu()
	{
		Anim.SetBool("dok", true);
	}

	//ssc
	public void DokraOffDesu()
	{
		Anim.SetBool ("dok", false);

	}

	public void HitInDesu()
	{
		if(cooltime < 0 && !ruhit)
		{
			ruhit = true;
			Anim.SetBool("hit", true);
		}
	}
	public void Hitover()
	{
		cooltime = 1;
		ruhit = false;
		Anim.SetBool("hit", false);
	}

	public void pakin()
	{
		rudead = true;
		Anim.SetBool("dead", true);
	}
}