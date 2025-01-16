using UnityEngine;

namespace Platformer397
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private InputReader input;

        private void Start ()
        {
            input.EnablePlayerActions();
        }

        private void OnEnable ()
        {
            input.Move += GetMovement;
        }

        private void OnDisable ()
        {
            input.Move -= GetMovement;
        }

        private void OnDestroy ()
        {
            
        }

        private void GetMovement (Vector2 movement)
        {
            Debug.Log("Input working "+ movement);
        }
    }
}
