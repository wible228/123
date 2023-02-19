using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomStrong : MonoBehaviour
{
    [SerializeField]
    private Text randStrong;
    [SerializeField]
    private int max, min;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void S()
    {
        randStrong.text = Random.Range(min, max) + "H".ToString();
    }

}