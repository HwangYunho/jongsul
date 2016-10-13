using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class getConfeito : MonoBehaviour
{
    public Animator Anim;

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

        /*if (Input.GetButtonDown("Fire2"))
        {
            this.transform.position = getNearist().transform.position;
        }*/
        if (numOfConfeito > 0)
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
}
