using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        CharacterBuilder builder = new CharacterBuilder();

        Character warrior = builder
            .SetName("Warrior")
            .SetHealth(100)
            .SetArmor("Plate Armor")
            .SetWeapon("Sword")
            .Build();

        warrior.PrintInfo();
    }
}
