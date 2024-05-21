using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System . IO;
using System . Runtime . Serialization . Formatters . Binary;


public static class SaveSystem  
{
  
    public static void SavePlayer( )
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application . persistentDataPath + "/user.SAVE";
        FileStream stream = new FileStream(path,FileMode.Create);

        PlayerData data  = new PlayerData();
       

        formatter . Serialize (stream , data);
        stream . Close();
        Debug . Log ("Saved");


    }



    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/user.SAVE";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream (path, FileMode.Open);

            PlayerData data = formatter . Deserialize (stream) as PlayerData;
            stream . Close ();
            Debug.Log("Loaded");
            return data;
        }
        else
        {
            SavePlayer ();
            Debug . LogError ("Save Could not be found in " + path);
            return null;
        }
    }

    public static void DeleteSaveData ( )
    {

        string path = Application.persistentDataPath + "/user.Save";
        File . Delete (path);

     
        Application . Quit();
        Debug . Log ("Removed" + path);
      
    }

}
