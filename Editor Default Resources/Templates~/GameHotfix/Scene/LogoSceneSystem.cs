/// <summary>
/// 2025-12-10 Game Framework Code By Hurley
/// </summary>

using System;

namespace Game
{
    /// <summary>
    /// Logo场景
    /// </summary>
    static class LogoSceneSystem
    {
        [OnAwake]
        static void Awake(this LogoScene self)
        {
        }

        [OnStart]
        static void Start(this LogoScene self)
        {
            Debugger.Info("hello world");
        }

        [OnDestroy]
        static void Destroy(this LogoScene self)
        {
        }
    }
}
