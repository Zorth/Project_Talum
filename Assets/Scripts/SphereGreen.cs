using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereGreen : MonoBehaviour {


    //public int LocalScore;
    public Score score;
    public GameObject scoreText;

	// Use this for initialization
	void Start () {

        score = scoreText.GetComponent<Score>(); 
        

    }
	
	// Update is called once per frame
	void Update () {

        if (score.count >= 20)
        {
            Destroy(this.gameObject);
        }

    }
}
