using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataHolder : MonoBehaviour
{
    public Player player = new Player();

    public List<MenuItem> menuItems = new List<MenuItem>();


    void Start()
    {
        LoadDataFromJson();
    }

    void LoadDataFromJson()
    {
        string path = Path.Combine(Application.streamingAssetsPath, "data.json");
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            DataWrapper data = JsonUtility.FromJson<DataWrapper>(json);
            SetPlayerData(data.player);
            SetMenuItemsData(data.menuItems);
        }
        else
        {
            Debug.LogError("Cannot find data.json file");
        }
    }

    private void SetPlayerData(Player data)
    {
        player.SetData(data);
    }

    private void SetMenuItemsData(List<MenuItem> data)
    {
        menuItems.Clear();
        foreach (MenuItem menuItemData in data)
        {
            MenuItem menuItem = new MenuItem();
            menuItem.SetData(menuItemData);
            menuItems.Add(menuItem);
        }
    }

    public void SaveDataToJson()
    {
        DataWrapper data = new DataWrapper();
        data.player = player;
        data.menuItems = menuItems;

        string json = JsonUtility.ToJson(data);
        string path = Path.Combine(Application.streamingAssetsPath, "data.json");
        File.WriteAllText(path, json);
    }
}

[System.Serializable]
public class DataWrapper
{
    public Player player;
    public List<MenuItem> menuItems;
}
