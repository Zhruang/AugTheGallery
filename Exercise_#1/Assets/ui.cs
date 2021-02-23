using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ui : MonoBehaviour
{

    public GameObject DiscoBall;
    public GameObject SpinButton;
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
        SpinButton.SetActive(false);
    }
}