using UnityEngine;

public interface ICharacterBuilder
{
    ICharacterBuilder SetName(string name);
    ICharacterBuilder SetHealth(int health);
    ICharacterBuilder SetWeapon(string weapon);
    ICharacterBuilder SetArmor(string armor);
    Character Build();

}
