using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;

public class Values : MonoBehaviour {

    public int highScore;
    public Text HighScore;
    
    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + "/Scores.dat", FileMode.Open);

        PlayerData data = new PlayerData();
        //save data here
        data.highScore = highScore;

        bf.Serialize(file, data);
        file.Close();
    }

    public void Load()
    {
        if(File.Exists(Application.persistentDataPath + "/Scores.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/Scores.dat", FileMode.Open);

            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();
            // load data here
            highScore = data.highScore;
        }
    }

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update () {

        HighScore.text = "High Score: " + highScore;
        

	}
}
[Serializable]
class PlayerData
{
    // put data to save here
    public int highScore;
}