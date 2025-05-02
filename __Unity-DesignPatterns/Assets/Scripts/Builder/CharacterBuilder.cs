using UnityEngine;

public class CharacterBuilder : ICharacterBuilder
{
    private Character _character = new Character();

    public ICharacterBuilder SetArmor(string armor)
    {
        _character.Armor = armor;
        return this;
    }

    public ICharacterBuilder SetHealth(int health)
    {
        _character.Health = health;
        return this;
    }

    public ICharacterBuilder SetName(string name)
    {
        _character.Name = name;
        return this;
    }

    public ICharacterBuilder SetWeapon(string weapon)
    {
        _character.Weapon = weapon;
        return this;
    }

    public Character Build()
    {
        return _character;
    }
}
