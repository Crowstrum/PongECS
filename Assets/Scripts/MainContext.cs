using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Engines;
using Svelto.Context;
using Svelto.ECS;
using UnityEngine;

namespace Assets.Scripts
{
    public class Main : ICompositionRoot
    {
        private EnginesRoot _enginesRoot;
        private IEntityFactory _entityFactory;

        public Main()
        {
            SetupEnginesAndComponents();
        }

        private void SetupEnginesAndComponents()
        {
            _entityFactory = _enginesRoot = new EnginesRoot();
            GameObjectFactory factory = new GameObjectFactory();
            var ballMoveEngine = new BallMoveEngine();
            var playerPaddleMovementEngine = new PlayerPaddleMoveEngine();
            AddEngine(playerPaddleMovementEngine);
            AddEngine(ballMoveEngine);
        }

        private void AddEngine(IEngine engine)
        {
            _enginesRoot.AddEngine(engine);
        }

        public void OnContextCreated(UnityContext contextHolder)
        {
            IEntityDescriptorHolder[] entities = contextHolder.GetComponentsInChildren<IEntityDescriptorHolder>();
            for (int i = 0; i < entities.Length; i++)

                _entityFactory.BuildEntity((entities[i] as MonoBehaviour).gameObject.GetInstanceID(), entities[i].BuildDescriptorType());
        }

        public void OnContextInitialized()
        {
           // throw new System.NotImplementedException();
        }

        public void OnContextDestroyed()
        {
           // throw new System.NotImplementedException();
        }
    }




    public class MainContext : UnityContext<Main> {
    }
}