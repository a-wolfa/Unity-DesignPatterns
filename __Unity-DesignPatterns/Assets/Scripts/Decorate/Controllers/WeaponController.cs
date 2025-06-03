using System;
using Decorate.Abstractions;
using Decorate.Weapons;
using UnityEngine;

namespace Decorate.Controllers
{
    public class WeaponController : MonoBehaviour
    {
        private IWeapon _weapon;

        private void Awake()
        {
            Init();
        }

        private void Init()
        {
            DecorateWeapon();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _weapon.Attack();
                Debug.Log($"Damage dealt: {_weapon.GetDamage()}");
            }
        }
        private void DecorateWeapon()
        {
            _weapon = new Sword();
            _weapon = new FireWeapon(_weapon);
            _weapon = new IceWeapon(_weapon);
        }
    }
    
}