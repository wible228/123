using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandowDuraction : MonoBehaviour
{
    [SerializeField]
    private Text randStrong;
    [SerializeField]
    private string[] dur;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void B()
    {
        randStrong.text = dur[Random.Range(0, dur.Length)];
    }
}
