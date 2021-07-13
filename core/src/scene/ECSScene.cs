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

		OnInitialize(Initialize);
		OnUpdate(Update);
		OnDraw(Draw);
	}

	private void Initialize()
	{
		var inline = new Component()
			.OnInitialize(() => { Console.WriteLine("Inline component initialized!"); })
			.OnUpdate((GameTime gameTime) => { Console.WriteLine("Inline component updated!"); });

		_ecs.CreateEntity()
			.AddComponent<SpriteComponent>()
			.AddComponent(inline)
			.AddComponent<TestComponent>();

		_ecs.Initialize();
	}

	private void Update(GameTime gameTime)
	{
		_ecs.Update(gameTime);
	}

	private void Draw(GameTime gameTime)
	{
		_ecs.Draw(gameTime, SpriteBatch);
	}
}