using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public int count;
    public Text scoreText;
    public Text round;
    public string roundStatus;

	// Use this for initialization
	void Start () {

        count = 0;
        roundStatus = "";
        
	}

    void UpdateText()
    {

        scoreText.text = "points: " + count.ToString();
        round.text = roundStatus;

    }
	
	// Update is called once per frame
	void Update () {
        UpdateText();
	}
}
