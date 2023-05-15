using Unity.Entities;
using UnityEngine;

public class RunFixedUpdateSystems : MonoBehaviour
{
    private PlayerInputSystem playerInputSystem;
    private PlayerMovementSystem playerMovementSystem;
    private PlayerTurningSystem playerTurningSystem;
    private PlayerAnimationSystem playerAnimationSystem;
    private CameraFollowSystem cameraFollowSystem;

    private void Start()
    {
        var world = World.DefaultGameObjectInjectionWorld;
        playerInputSystem = world.GetOrCreateSystemManaged<PlayerInputSystem>();
        playerMovementSystem = world.GetOrCreateSystemManaged<PlayerMovementSystem>();
        playerTurningSystem = world.GetOrCreateSystemManaged<PlayerTurningSystem>();
        playerAnimationSystem = world.GetOrCreateSystemManaged<PlayerAnimationSystem>();
        cameraFollowSystem = world.GetOrCreateSystemManaged<CameraFollowSystem>();
    }

    private void FixedUpdate()
    {
        playerInputSystem.Update();
        playerMovementSystem.Update();
        playerTurningSystem.Update();
        playerAnimationSystem.Update();
        cameraFollowSystem.Update();
    }
}
