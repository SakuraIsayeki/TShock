using System;

namespace TShockAPI.DB.Models;

/// <summary>
/// Represents the research progress for a given item, associated by player/world.
/// </summary>
public class Research
{
	/// <summary>
	/// The ID of the world this research progress is associated with.
	/// </summary>
	public string WorldId { get; set; }

	/// <summary>
	/// The ID of the player this research progress is associated with.
	/// </summary>
	public string PlayerId { get; set; }

	/// <summary>
	/// The ID of the item this research progress is associated with.
	/// </summary>
	public int ItemId { get; set; }

	/// <summary>
	/// The amount sacrificed to unlock this item.
	/// </summary>
	public int AmountSacrificed { get; set; }

	/// <summary>
	/// The date/time at which this item was last sacrificed.
	/// </summary>
	public DateTime TimeSacrificed { get; set; }
}
