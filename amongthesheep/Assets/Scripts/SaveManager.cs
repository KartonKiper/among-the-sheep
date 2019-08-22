using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public SaveState state;
    public static SaveManager Instance { set; get; }

    private void Awake()
    {
        Instance = this;
        Load();

        Debug.Log(Helper.Serialize<SaveState>(state));
    }
    //Save the whole state of this saveState script to the player pref
    public void Save()
    {
        PlayerPrefs.SetString("Save",Helper.Serialize<SaveState>(state));
    }

    //Load previous saved satate from the player prefs

    public void Load()
    {
        if(PlayerPrefs.HasKey("save"))
        {
            state = Helper.Deserialize<SaveState>(PlayerPrefs.GetString("Save"));
        }
        else
        {
            state = new SaveState();
            Save();
            Debug.Log("No save file found, creating new one");
        }
    }


}

