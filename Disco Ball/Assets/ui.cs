using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ui : MonoBehaviour
{

    public GameObject DiscoBall;
    public GameObject SpinButton;
    public GameObject Page_1;
    public GameObject Page_2;
    public GameObject Page_3;
    public GameObject Page_4;
    public GameObject NextButton;

    public bool SpinEnable = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SpinEnable == true)
        {
            Quaternion LastRotation = DiscoBall.GetComponent<Transform>().rotation;
            DiscoBall.GetComponent<Transform>().rotation = Quaternion.Euler(0, LastRotation.eulerAngles.y + 1, 0);
        }
    }
    public void SpinDisco()
    {
        SpinEnable = true;
        //SpinButton.SetActive(false);
    }

    public void NextPage()
    {
        if (Page_1.activeSelf == true){
            Page_1.SetActive(false);
            Page_2.SetActive(true);
        }else if (Page_2.activeSelf == true) {
            Page_2.SetActive(false);
            Page_3.SetActive(true);
        }else if (Page_3.activeSelf == true) {
            Page_3.SetActive(false);
            Page_4.SetActive(true);
            NextButton.SetActive(false);
        }
    }
}
