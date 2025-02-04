﻿using System.Collections.Generic;
using CrashKonijn.Goap.Classes.References;
using CrashKonijn.Goap.Enums;

namespace CrashKonijn.Goap.Interfaces
{
    public interface IAgent
    {
        AgentState State { get; }
        IGoapSet GoapSet { get; }
        IGoalBase CurrentGoal { get; }
        IActionBase CurrentAction { get; }
        IActionData CurrentActionData { get; }
        IWorldData WorldData { get; }
        List<IActionBase> CurrentActionPath { get; }
        IAgentEvents Events { get; }
        IDataReferenceInjector Injector { get; }

        void Run();
        
        void SetGoal<TGoal>(bool endAction) where TGoal : IGoalBase;

        void SetGoal(IGoalBase goal, bool endAction);
        void SetAction(IActionBase action, List<IActionBase> path, ITarget target);
        void EndAction(bool enqueue = true);
    }
}