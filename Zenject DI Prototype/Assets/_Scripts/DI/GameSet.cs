using UnityEngine;
using Zenject;

public class GameSet : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IPopManager>().To<PopManager>().AsSingle();

    }
}