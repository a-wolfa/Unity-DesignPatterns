using UnityEngine;

public class Character
{
    public string Name;
    public int Health;
    public string Weapon;
    public string Armor;

    public void PrintInfo()
    {
        Debug.Log($"Name: {Name}, Health: {Health}, Weapon: {Weapon}, Armor: {Armor}");
    }
}
