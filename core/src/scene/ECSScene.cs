using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Ladybug;
using Ladybug.ECS;
using Ladybug.ECS.Components;

public class ECSScene : Scene
{
	private ECS _ecs;

	public ECSScene()
	{
		_ecs = new ECS(this);
		_ecs.RegisterComponentSystem<TestComponent, TestComponentSystem>();
	}

	protected override void Initialize()
	{
		var inline = Component.Compose()
			.OnInitialize(() => { Console.WriteLine("Inline component initialized!"); })
			.OnUpdate((GameTime gameTime) => { Console.WriteLine("Inline component updated!"); });

		_ecs.CreateEntity()
			.AddComponent<SpriteComponent>()
			.AddComponent(inline)
			.AddComponent<TestComponent>();

		_ecs.Initialize();
	}

	protected override void Update(GameTime gameTime)
	{
		_ecs.Update(gameTime);
	}

	protected override void Draw(GameTime gameTime)
	{
		_ecs.Draw(gameTime, SpriteBatch);
	}
}