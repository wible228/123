using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomRazmer : MonoBehaviour
{
    [SerializeField]
    private Text randrazmer;
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
    public void R()
    {
        randrazmer.text = Random.Range(min, max).ToString();
    }
}