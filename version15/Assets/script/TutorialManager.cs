using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour {
    InputField input;
    InputField.SubmitEvent se;

    public string name;


    // Use this for initialization
    void Start () {
        input = gameObject.GetComponent<InputField>();
        se = new InputField.SubmitEvent();
        se.AddListener(SubmitInput);
        input.onEndEdit = se;
    }
    void Update() {

    }
    // Update is called once per frame
    private void SubmitInput(string arg0)
    {
        name = input.text;

        Debug.Log(name);
    }

    public void submit()
    {
        PlayerPrefs.SetString("Name", name);
        Application.LoadLevel(2);
    }
}
