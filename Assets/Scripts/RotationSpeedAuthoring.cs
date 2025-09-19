using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

public class RotationSpeedAuthoring : MonoBehaviour
{
    public float DegreesPerSecond = 360f;
}

class RotationSpeedBaker : Unity.Entities.Baker<RotationSpeedAuthoring>
{
    public override void Bake(RotationSpeedAuthoring authoring)
    {
        var entity = GetEntity(TransformUsageFlags.Dynamic);
        AddComponent(entity, new RotationSpeed
        {
            RadiansPerSecond = math.radians(authoring.DegreesPerSecond)
        });
    }
}