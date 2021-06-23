/*
using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Ladybug;
using Ladybug.Entities;

public class EntityScene : Scene
{
	private EntitySystem _entitySystem;

	public EntityScene()
	{
		_entitySystem = new EntitySystem(this);

		OnInitialize(Initialize);
		OnUpdate(Update);
		OnDraw(Draw);
	}

	private void Initialize()
	{
		_entitySystem.CreateEntity()
			.AddComponent<TestComponent>();

		_entitySystem.InitializeEntities();
	}

	private void Update(GameTime gameTime)
	{
		_entitySystem.Update(gameTime);
	}

	private void Draw(GameTime gameTime)
	{
		_entitySystem.Draw(gameTime, SpriteBatch);
	}
}
*/