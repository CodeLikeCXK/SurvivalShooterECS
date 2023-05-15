using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

public class PlayerObject : MonoBehaviour
{
    public Transform GunPivot;
    public Entity entity;
    
    public class PlayerObjectBaker : Baker<PlayerObject>
    {
        public override void Bake(PlayerObject entity)
        {
            var settings = SurvivalShooterBootstrap.Settings;
            AddComponent(new PlayerData());
            AddComponent(new HealthData { Value = settings.StartingPlayerHealth });
            AddComponent(new PlayerInputData { Move = new float2(0, 0) });
        }
    }
}


