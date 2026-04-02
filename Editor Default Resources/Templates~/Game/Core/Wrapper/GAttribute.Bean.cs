/// <summary>
/// Game Framework
/// 
/// 创建者：Hurley
/// 创建时间：2025-12-06
/// 功能描述：
/// </summary>

using System;

namespace Game
{
    /// <summary>
    /// 对象实现类声明属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class OnObjectConfigureAttribute : GameEngine.CObjectTemplateConfigurationAttribute
    {
        public OnObjectConfigureAttribute() : base() { }

        public OnObjectConfigureAttribute(string viewName) : base(viewName) { }

        public OnObjectConfigureAttribute(int priority) : base(priority) { }

        public OnObjectConfigureAttribute(string viewName, int priority) : base(viewName, priority) { }
    }

    /// <summary>
    /// 场景实现类声明属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class OnSceneConfigureAttribute : GameEngine.CSceneTemplateConfigurationAttribute
    {
        public OnSceneConfigureAttribute() : base() { }

        public OnSceneConfigureAttribute(string viewName) : base(viewName) { }

        public OnSceneConfigureAttribute(int priority) : base(priority) { }

        public OnSceneConfigureAttribute(string viewName, int priority) : base(viewName, priority) { }
    }

    /// <summary>
    /// 角色实现类声明属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class OnActorConfigureAttribute : GameEngine.CActorTemplateConfigurationAttribute
    {
        public OnActorConfigureAttribute() : base() { }

        public OnActorConfigureAttribute(string viewName) : base(viewName) { }

        public OnActorConfigureAttribute(int priority) : base(priority) { }

        public OnActorConfigureAttribute(string viewName, int priority) : base(viewName, priority) { }
    }

    /// <summary>
    /// 视图实现类声明属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class OnViewConfigureAttribute : GameEngine.CViewTemplateConfigurationAttribute
    {
        public OnViewConfigureAttribute() : base() { }

        public OnViewConfigureAttribute(string viewName) : base(viewName) { }

        public OnViewConfigureAttribute(int priority) : base(priority) { }

        public OnViewConfigureAttribute(string viewName, int priority) : base(viewName, priority) { }
    }

    /// <summary>
    /// 组件实现类声明属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class OnComponentConfigureAttribute : GameEngine.CComponentTemplateConfigurationAttribute
    {
        public OnComponentConfigureAttribute() : base() { }

        public OnComponentConfigureAttribute(string viewName) : base(viewName) { }

        public OnComponentConfigureAttribute(int priority) : base(priority) { }

        public OnComponentConfigureAttribute(string viewName, int priority) : base(viewName, priority) { }
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////

    /// <summary>
    /// 视图分组策略声明属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class GViewGroupAttribute : GameEngine.CViewGroupAttribute
    {
        public GViewGroupAttribute(string groupName) : base(groupName) { }
    }

    /// <summary>
    /// 实体自动挂载的目标组件的属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    public class GAutomaticallyActivatedComponentAttribute : GameEngine.CAutomaticallyActivatedComponentAttribute
    {
        public GAutomaticallyActivatedComponentAttribute(Type referenceType) : base(referenceType) { }

        public GAutomaticallyActivatedComponentAttribute(Type referenceType, int priority) : base(referenceType, priority) { }

        public GAutomaticallyActivatedComponentAttribute(Type referenceType, int priority, GameEngine.AspectBehaviourType activationBehaviourType) : base(referenceType, priority, activationBehaviourType) { }
    }
}
