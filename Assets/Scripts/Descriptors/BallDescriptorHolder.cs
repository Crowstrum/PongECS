using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Nodes;
using Svelto.ECS;
using UnityEngine;

namespace Assets.Scripts.Descriptors
{
    public class BallDescriptor : EntityDescriptor
    {
        public static readonly INodeBuilder[] NodesToBuild;

        static BallDescriptor()
        {
            NodesToBuild = new INodeBuilder[]
            {
                new NodeBuilder<BallNode>(),
            };
        }

        public BallDescriptor(IComponent[] componentsImplementor) : base(NodesToBuild, componentsImplementor) { }
    }

    [DisallowMultipleComponent]
    public class BallDescriptorHolder : MonoBehaviour, IEntityDescriptorHolder
    {
        public EntityDescriptor BuildDescriptorType(object[] extraImplentors = null)
        {
            return new BallDescriptor(GetComponentsInChildren<IComponent>());
        }
    }
}