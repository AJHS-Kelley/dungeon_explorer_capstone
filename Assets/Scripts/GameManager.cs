using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        if(GameManager.instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
    }

    // Resources
    public List<Sprite> playerSprites;
    public List<Sprite> weaponSprites;
    public List<int> weaponPrices;
    public List<int> xpTable;

    // References
    public Player Player;
    // public weapon weapon...

    // Logic
    public int rubies;
    public int experience;

    // Save state
    /*
        int preferedSkin
        int rubies
        int experience
        int weaponLevel
    */
    public void SaveState()
    {
        string s = "";

        s += "0" + "|";
        s += rubies.ToString() + "|";
        s += experience.ToString() + "|";
        s += "0";

        PlayerPrefs.SetString("SaveState", s);
    }

    public void LoadState()
    {
        if(!PlayerPrefs.HasKey("SaveState"))
            return;

        string[] data = PlayerPrefs.GetString("SaveState").Split('|');

        // Change player skin
        rubies = int.Parse(data[1]);
        experience = int.Parse(data[2]);
        // Change weapon level

        Debug.Log("LoadState");
    }
}
