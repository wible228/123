using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{

    public GameObject but;
    public float timeStart;
    public Text timerText;
    bool timerrun = false;
    // Start is called before the first frame update
    void Start()
    {
        timerText.text = timeStart.ToString("F2"); 
    }

    // Update is called once per frame
    void Update()
    {
        if(timerrun == true)
        {
            timeStart += Time.deltaTime;
            timerText.text = timeStart.ToString("F2");
        }

    }
    public void ButtonTimer()
    {
        timerrun = !timerrun;
        but.SetActive(false);
    }
}
