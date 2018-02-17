using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public  class SaveLoad:MonoBehaviour
{
    public GameObject go;

    
    public static float playerx;
    public static float playery;
    public static List<float> playerPosition = new List<float>();

    private void Start()
    {
        Load();
        if(playerx!=0&&playery!=0)
        {
            go.transform.position = new Vector3(playerx, playery, go.transform.position.z);
        }
       
    }
    void Update()
    {
       

        playerx = go.transform.position.x;
        playery = go.transform.position.y;

        if (Input.GetKeyDown(KeyCode.E))
        {

            playerPosition.Add(playerx);
            playerPosition.Add(playery);
            Save();
        }


    }
    //it's static so we can call it from anywhere
    public static void Save()
    {
       
        BinaryFormatter bf = new BinaryFormatter();

        //Application.persistentDataPath is a string, so if you wanted you can put that into debug.log if you want to know where save games are located
        FileStream file = File.Create(Application.persistentDataPath + "/savedGames.gd"); //you can call it anything you want
        bf.Serialize(file, playerPosition);
       
        file.Close();
    }

    public static void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/savedGames.gd") && Application.persistentDataPath + "/savedGames.gd" !="")
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/savedGames.gd", FileMode.Open);
            playerPosition = (List<float>)bf.Deserialize(file);
            file.Close();

            foreach (float pos in playerPosition)
            {
              if(pos<=10&&pos>=-10)
                {
                    playery = pos;
                }
              else
                {
                    playerx = pos;
                }
              

            }
         

        }
     
    }
   /* private void OnTriggerStay(Collider other)
    {
        if(other.tag=="Player")
        {
           
        }
    }
    */
}