using UnityEngine;
using System.Collections;

public interface IDirectionComponent : IComponent
{

    Vector3 direction { get; }
}
