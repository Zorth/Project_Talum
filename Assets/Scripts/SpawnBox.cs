using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBox : MonoBehaviour {

    public GameObject Box;
    public GameObject RandomBox;
    public Vector3 ObjectSpawnPosition;
    public Vector3 RandomObjectSpawnPosition;

	// Use this for initialization
	void Start () {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        
	}



    public void SummonBox()
    {
        GameObject player = GameObject.Find("Player");
        Transform Player = player.GetComponent<Transform>();
        ObjectSpawnPosition = Player.transform.position;
        Instantiate(Box, ObjectSpawnPosition, Quaternion.identity);

    }


    // Update is called once per frame
    void Update () {

        if (Input.GetButtonDown("Box"))
        {
            SummonBox();
        }

        if (Input.GetButtonDown("RandomBox"))
        {
            GameObject player = GameObject.Find("Player");
            Transform Player = player.GetComponent<Transform>();
            RandomObjectSpawnPosition = Player.transform.position;
            StartCoroutine("SummonRandomBox");
        }

    }

    IEnumerator SummonRandomBox()
    {
        yield return new WaitForSeconds(3);
        Instantiate(RandomBox, RandomObjectSpawnPosition, Quaternion.identity);
    }

}
