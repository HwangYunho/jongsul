using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class buttonDisableInven : MonoBehaviour {

    public int a;
    public Transform cantview;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.inven[a] < 1)
        {
            cantview.gameObject.SetActive(true);
            this.gameObject.transform.GetComponent<Button>().interactable = false;
        }
        else
        {
            cantview.gameObject.SetActive(false);
            this.gameObject.transform.GetComponent<Button>().interactable = true;
        }
    }
}
