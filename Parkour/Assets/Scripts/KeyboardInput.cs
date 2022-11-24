using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    [SerializeField] private PhysicsMovement _movement;
    
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if (vertical != 0)
        {
            horizontal = 0;
        }

        _movement.Move(new Vector3(-horizontal, 0, -vertical));    
    }
}
