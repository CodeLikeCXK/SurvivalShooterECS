using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

public class EnemyObject : MonoBehaviour
{
    public Entity entity;
}

public class EnemyObjectBaker : Baker<EnemyObject>
{

    public override void Bake(EnemyObject entity)
    {
        var settings = SurvivalShooterBootstrap.Settings;
        AddComponent(new EnemyData());
        AddComponent(new HealthData { Value = settings.StartingEnemyHealth });

    }
}
