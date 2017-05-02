using Svelto.ECS;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddleDescription : EntityDescriptor
{
    public static readonly INodeBuilder[] _nodesToBuild;

    static PlayerPaddleDescription()
    {
        _nodesToBuild = new INodeBuilder[]
        {
            new NodeBuilder<PlayerPaddleNode>(),
        };
    }

    public PlayerPaddleDescription(IComponent[] componentsImplementor): base(_nodesToBuild, componentsImplementor) { }
}

[DisallowMultipleComponent]
public class PlayerPaddleDescriptionHolder : MonoBehaviour
{
    public EntityDescriptor BuildDescriptorType(object[] extraImplentors = null)
    {
        return new PlayerPaddleDescription(GetComponentsInChildren<IComponent>());
    }
}
