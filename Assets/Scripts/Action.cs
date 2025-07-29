using UnityEngine;

public class Action
{
	/// <summary>
	/// The amount of action points that it costs to perform this action
	/// </summary>
	public int ActionPointCost { get => _actionPointCost; private set => _actionPointCost = value; }
	private int _actionPointCost;

	/// <summary>
	/// The entity that owns this action
	/// </summary>
	public Entity ParentEntity { get => _parentEntity; private set => _parentEntity = value; }
	private Entity _parentEntity;

	public Action (Entity parentEntity)
	{
		ParentEntity = parentEntity;
	}

	/// <summary>
	/// Perform this action
	/// </summary>
	/// <returns>true if the action was performed successfully, false otherwise</returns>
	public bool Perform ( )
	{
		return true;
	}
}
