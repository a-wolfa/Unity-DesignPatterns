using UnityEngine;

namespace Command.Actors
{
    public class Player : MonoBehaviour
    {
        public void Jump() => Debug.Log("Jump");
        public void Shoot() => Debug.Log("Shoot");
    }
}
