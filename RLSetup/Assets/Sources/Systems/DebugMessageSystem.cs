using System;
using System.Collections.Generic;
using Entitas;

public class DebugMessageSystem : ReactiveSystem<GameEntity>
{
	public DebugMessageSystem(IContext<GameEntity> context) : base(context) {}
	protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
	{
		return context.CreateCollector(GameMatcher.DebugMessage);
	}
	protected override bool Filter(GameEntity entity)
	{
		return entity.hasDebugMessage;
	}

	protected override void Execute(List<GameEntity> entities)
	{
		foreach(var e in entities) {
			Console.WriteLine($"{e.ToString()} : {e.debugMessage.message}");
		}
	}

}