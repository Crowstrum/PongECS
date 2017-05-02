using Svelto.ECS;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Nodes;
using UnityEngine;

public class PlayerPaddleDescription : EntityDescriptor
{
    public static readonly INodeBuilder[] NodesToBuild;

    static PlayerPaddleDescription()
    {
        NodesToBuild = new INodeBuilder[]
        {
            new NodeBuilder<PlayerPaddleNode>(),
        };
    }

    public PlayerPaddleDescription(IComponent[] componentsImplementor): base(NodesToBuild, componentsImplementor) { }
}

[DisallowMultipleComponent]
public class PlayerPaddleDescriptionHolder : MonoBehaviour, IEntityDescriptorHolder
{
    public EntityDescriptor BuildDescriptorType(object[] extraImplentors = null)
    {
        return new PlayerPaddleDescription(GetComponentsInChildren<IComponent>());
    }
}
