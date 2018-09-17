using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

public class SaveLoad
{
    public static Game savedGame = new Game();

    public static void Save()
    {
        savedGame = Game.current;
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gamesave.ft");
        bf.Serialize(file, savedGame);
        file.Close();
    }

    public static void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/gamesave.ft"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gamesave.ft", FileMode.Open);
            savedGame = (Game)bf.Deserialize(file);
            Game.current = savedGame;
            Debug.Log(Game.player.x);
            file.Close();
        }
    }
}
