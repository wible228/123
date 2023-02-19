using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomRound : MonoBehaviour
{
    [SerializeField]
    public Text randtext;
    [SerializeField]
    public int max, min;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Ro()
    {
        randtext.text = Random.Range(min, max).ToString();
    }
}