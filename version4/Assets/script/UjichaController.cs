using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UjichaController : MonoBehaviour {

    public Animator anim;
    public float controllTimer = 2f;
    public int a;
    public bool stop = true;

    public float speed = 2f;

    public GameObject movepoint;
	// Use this for initialization
	void Start () {
        controllTimer = 3f;

    }
	
	// Update is called once per frame
	void Update () {
        controllTimer -= Time.deltaTime;

        anim.SetBool("w", !stop);

        this.transform.LookAt(movepoint.transform);
        
        if (controllTimer < 0 && stop)
        {
            controllTimer = 3f;
            a = Random.Range(0, 2);
            if (a == 0)
            {
                putmovepoint();
            }
        }
        else if(!stop)
        {
            this.transform.position += (movepoint.transform.position - this.transform.position).normalized * speed * Time.deltaTime;
            if(Vector3.Distance(this.transform.position, movepoint.transform.position) < 0.1f)
            {
                stop = true;
                controllTimer = 3f;
            }
        }
    }
    void putmovepoint()
    {
        stop = false;
        movepoint.transform.position = this.transform.position + new Vector3(Random.RandomRange(-2f,2f),0, Random.RandomRange(-2f, 2f));

        if (movepoint.transform.position.z < -2f)
        {
            movepoint.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, -2f);
        }
        if (movepoint.transform.position.z > 2f)
        {
            movepoint.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 2f);
        }
        if (movepoint.transform.position.y < 0)
        {
            movepoint.transform.position = new Vector3(this.transform.position.x, 1f, this.transform.position.z);
        }
        if (movepoint.transform.position.x < -4f)
        {
            movepoint.transform.position = new Vector3(-4f, this.transform.position.y, this.transform.position.z);
        }
        if (movepoint.transform.position.x > 4f)
        {
            movepoint.transform.position = new Vector3(4f, this.transform.position.y, this.transform.position.z);
        }
        if (movepoint.transform.position.y > 6f)
        {
            movepoint.transform.position = new Vector3(this.transform.position.x, 5f, this.transform.position.z);
        }
    }
}
