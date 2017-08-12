using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;



public class BoxScript : MonoBehaviour {


    public GameObject Box;
    public Vector3 ObjectSpawnPosition;
    public float speed;
    public int Extra;
    public Scene MainMenuScene;
    public string MainMenu;
    public Values Values;
    private int HS;

    public void OnTriggerEnter(Collider collision)
    {
        
        GameObject score = GameObject.Find("ScoreText");
        Score Score = score.GetComponent<Score>();
        HS = Values.highScore;
        Extra = Score.count;
        
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "PlayerVR")
        {

            Destroy(this.gameObject);

            Score.count += 1;

        }

        if (collision.gameObject.tag == "Target")
        {
            
            Score.roundStatus = "You lose";
            /*if (Extra > HS)
            {
                Values.highScore = Score.count;
                Values.Save();
            }
            */
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
            SceneManager.LoadScene(MainMenu);
        }



}

 

    public GameObject target;
    

    void Update()
    {

        float move = (speed + Extra) * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, move);

    }




}
